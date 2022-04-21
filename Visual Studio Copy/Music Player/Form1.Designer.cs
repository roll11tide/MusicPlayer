namespace Music_Player
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.selectSong = new System.Windows.Forms.Button();
            this.playSong = new System.Windows.Forms.Button();
            this.pauseSong = new System.Windows.Forms.Button();
            this.songSelector = new System.Windows.Forms.OpenFileDialog();
            this.shuffleSongs = new System.Windows.Forms.Button();
            this.musicFolderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.stopShuffle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectSong
            // 
            this.selectSong.Location = new System.Drawing.Point(93, 68);
            this.selectSong.Name = "selectSong";
            this.selectSong.Size = new System.Drawing.Size(75, 23);
            this.selectSong.TabIndex = 1;
            this.selectSong.Text = "Select Song";
            this.selectSong.UseVisualStyleBackColor = true;
            this.selectSong.Click += new System.EventHandler(this.selectSong_Click);
            // 
            // playSong
            // 
            this.playSong.Location = new System.Drawing.Point(174, 68);
            this.playSong.Name = "playSong";
            this.playSong.Size = new System.Drawing.Size(75, 23);
            this.playSong.TabIndex = 2;
            this.playSong.Text = "Play";
            this.playSong.UseVisualStyleBackColor = true;
            this.playSong.Click += new System.EventHandler(this.playSong_Click);
            // 
            // pauseSong
            // 
            this.pauseSong.Location = new System.Drawing.Point(255, 68);
            this.pauseSong.Name = "pauseSong";
            this.pauseSong.Size = new System.Drawing.Size(75, 23);
            this.pauseSong.TabIndex = 3;
            this.pauseSong.Text = "Pause";
            this.pauseSong.UseVisualStyleBackColor = true;
            this.pauseSong.Click += new System.EventHandler(this.pauseSong_Click);
            // 
            // songSelector
            // 
            this.songSelector.FileName = "Song_Name";
            // 
            // shuffleSongs
            // 
            this.shuffleSongs.Location = new System.Drawing.Point(336, 68);
            this.shuffleSongs.Name = "shuffleSongs";
            this.shuffleSongs.Size = new System.Drawing.Size(75, 23);
            this.shuffleSongs.TabIndex = 5;
            this.shuffleSongs.Text = "Shuffle";
            this.shuffleSongs.UseVisualStyleBackColor = true;
            this.shuffleSongs.Click += new System.EventHandler(this.shuffleSongs_Click);
            // 
            // musicFolderSelector
            // 
            this.musicFolderSelector.RootFolder = System.Environment.SpecialFolder.MyMusic;
            // 
            // stopShuffle
            // 
            this.stopShuffle.Location = new System.Drawing.Point(417, 68);
            this.stopShuffle.Name = "stopShuffle";
            this.stopShuffle.Size = new System.Drawing.Size(75, 23);
            this.stopShuffle.TabIndex = 6;
            this.stopShuffle.Text = "Stop Shuffle";
            this.stopShuffle.UseVisualStyleBackColor = true;
            this.stopShuffle.Click += new System.EventHandler(this.stopShuffle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 111);
            this.Controls.Add(this.stopShuffle);
            this.Controls.Add(this.shuffleSongs);
            this.Controls.Add(this.pauseSong);
            this.Controls.Add(this.playSong);
            this.Controls.Add(this.selectSong);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectSong;
        private System.Windows.Forms.Button playSong;
        private System.Windows.Forms.Button pauseSong;
        private System.Windows.Forms.OpenFileDialog songSelector;
        private System.Windows.Forms.Button shuffleSongs;
        private System.Windows.Forms.FolderBrowserDialog musicFolderSelector;
        private System.Windows.Forms.Button stopShuffle;
    }
}

