namespace PlaylistRandomizer
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.playlistFolderTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.includeSubfoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(68, 37);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(211, 24);
            this.title.TabIndex = 0;
            this.title.Text = "Playlist Randomizer";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Randomize your playlist songs with a single button click";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playlistFolderTextBox
            // 
            this.playlistFolderTextBox.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistFolderTextBox.Location = new System.Drawing.Point(63, 137);
            this.playlistFolderTextBox.Name = "playlistFolderTextBox";
            this.playlistFolderTextBox.Size = new System.Drawing.Size(154, 20);
            this.playlistFolderTextBox.TabIndex = 2;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(60, 120);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(80, 14);
            this.inputLabel.TabIndex = 3;
            this.inputLabel.Text = "Playlist folder";
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolderButton.Location = new System.Drawing.Point(223, 137);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(56, 20);
            this.selectFolderButton.TabIndex = 4;
            this.selectFolderButton.Text = "Select";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // randomizeButton
            // 
            this.randomizeButton.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomizeButton.Location = new System.Drawing.Point(63, 191);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(216, 34);
            this.randomizeButton.TabIndex = 5;
            this.randomizeButton.Text = "Randomize";
            this.randomizeButton.UseVisualStyleBackColor = true;
            this.randomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // includeSubfoldersCheckBox
            // 
            this.includeSubfoldersCheckBox.AutoSize = true;
            this.includeSubfoldersCheckBox.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.includeSubfoldersCheckBox.Location = new System.Drawing.Point(151, 167);
            this.includeSubfoldersCheckBox.Name = "includeSubfoldersCheckBox";
            this.includeSubfoldersCheckBox.Size = new System.Drawing.Size(128, 18);
            this.includeSubfoldersCheckBox.TabIndex = 6;
            this.includeSubfoldersCheckBox.Text = "Include subfolders";
            this.includeSubfoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 275);
            this.Controls.Add(this.includeSubfoldersCheckBox);
            this.Controls.Add(this.randomizeButton);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.playlistFolderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Playlist Randomizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.TextBox playlistFolderTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.CheckBox includeSubfoldersCheckBox;
    }
}

