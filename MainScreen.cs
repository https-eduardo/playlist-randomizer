using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PlaylistRandomizer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void RandomizeFileName(string filePath)
        {
            string filename = Path.GetFileName(filePath);
            Regex extensionRegex = new Regex("^.*\\.(mp3|mp4|m4a|wav|wma|aac|flac|ogg)$");
            if (!extensionRegex.IsMatch(filename)) return;

            string randomString = Path.GetRandomFileName().Substring(0, 2);
            string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), $"{randomString} {filename}");

            File.Move(filePath, newFilePath);
        }

        private void RandomizeFolderFiles(string folderPath)
        {
            string[] filenames = Directory.GetFiles(folderPath);
            foreach (string filename in filenames)
            {
                RandomizeFileName(filename);
            }
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderDialog.ShowDialog();
            if (result != DialogResult.OK) return;

            playlistFolderTextBox.Text = folderDialog.SelectedPath;
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            string folderPath = playlistFolderTextBox.Text;
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Inserted directory not found!", "Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<string> folders = new List<string>
            {
                folderPath
            };

            if (includeSubfoldersCheckBox.Checked)
                folders.AddRange(Directory.GetDirectories(folderPath));
            
            foreach (string folder in folders)
            {
                RandomizeFolderFiles(folder);
            }

            MessageBox.Show("All audio files have been randomized. \n(extensions: mp3, mp4, m4a, wav, wma, aac, flac, ogg)", 
                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
