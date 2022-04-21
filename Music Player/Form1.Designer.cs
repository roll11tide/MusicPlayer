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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectSong = new System.Windows.Forms.Button();
            this.songSelector = new System.Windows.Forms.OpenFileDialog();
            this.musicFolderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.songTimer = new System.Windows.Forms.Timer(this.components);
            this.skipButton = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleSongs = new System.Windows.Forms.PictureBox();
            this.progressBarUpdate = new System.Windows.Forms.Timer(this.components);
            this.volumeSlider = new System.Windows.Forms.TrackBar();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.durationBar = new System.Windows.Forms.TrackBar();
            this.songCurrentDurationLabel = new System.Windows.Forms.Label();
            this.songDurationMaximum = new System.Windows.Forms.Label();
            this.songNameLabel = new System.Windows.Forms.TextBox();
            this.titleScrollTimer = new System.Windows.Forms.Timer(this.components);
            this.noRepeatsCheckbox = new System.Windows.Forms.CheckBox();
            this.shuffleFolder = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.PictureBox();
            this.playPauseButton = new System.Windows.Forms.PictureBox();
            this.defaultSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.skipButton)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shuffleSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPauseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // selectSong
            // 
            this.selectSong.Location = new System.Drawing.Point(12, 27);
            this.selectSong.Name = "selectSong";
            this.selectSong.Size = new System.Drawing.Size(75, 23);
            this.selectSong.TabIndex = 1;
            this.selectSong.Text = "Select Song";
            this.selectSong.UseVisualStyleBackColor = true;
            this.selectSong.Click += new System.EventHandler(this.selectSong_Click);
            // 
            // songSelector
            // 
            this.songSelector.FileName = "Song_Name";
            // 
            // musicFolderSelector
            // 
            this.musicFolderSelector.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // songTimer
            // 
            this.songTimer.Interval = 1000;
            this.songTimer.Tick += new System.EventHandler(this.songTimer_Tick);
            // 
            // skipButton
            // 
            this.skipButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipButton.Image = ((System.Drawing.Image)(resources.GetObject("skipButton.Image")));
            this.skipButton.Location = new System.Drawing.Point(358, 27);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(64, 52);
            this.skipButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skipButton.TabIndex = 7;
            this.skipButton.TabStop = false;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFolderToolStripMenuItem,
            this.setDefaultFolderToolStripMenuItem,
            this.defaultSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewFolderToolStripMenuItem
            // 
            this.viewFolderToolStripMenuItem.Name = "viewFolderToolStripMenuItem";
            this.viewFolderToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.viewFolderToolStripMenuItem.Text = "View Folder";
            this.viewFolderToolStripMenuItem.Click += new System.EventHandler(this.viewFolderToolStripMenuItem_Click);
            // 
            // setDefaultFolderToolStripMenuItem
            // 
            this.setDefaultFolderToolStripMenuItem.Name = "setDefaultFolderToolStripMenuItem";
            this.setDefaultFolderToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.setDefaultFolderToolStripMenuItem.Text = "Set Default Folder...";
            this.setDefaultFolderToolStripMenuItem.Click += new System.EventHandler(this.setDefaultFolderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // shuffleSongs
            // 
            this.shuffleSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shuffleSongs.Image = ((System.Drawing.Image)(resources.GetObject("shuffleSongs.Image")));
            this.shuffleSongs.Location = new System.Drawing.Point(293, 27);
            this.shuffleSongs.Name = "shuffleSongs";
            this.shuffleSongs.Size = new System.Drawing.Size(51, 52);
            this.shuffleSongs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shuffleSongs.TabIndex = 11;
            this.shuffleSongs.TabStop = false;
            this.shuffleSongs.Click += new System.EventHandler(this.shuffleSongs_Click);
            // 
            // progressBarUpdate
            // 
            this.progressBarUpdate.Interval = 500;
            this.progressBarUpdate.Tick += new System.EventHandler(this.progressBarUpdate_Tick);
            // 
            // volumeSlider
            // 
            this.volumeSlider.AutoSize = false;
            this.volumeSlider.Location = new System.Drawing.Point(472, 11);
            this.volumeSlider.Maximum = 100;
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(100, 39);
            this.volumeSlider.TabIndex = 0;
            this.volumeSlider.TickFrequency = 5;
            this.volumeSlider.ValueChanged += new System.EventHandler(this.volumeSlider_ValueChanged);
            // 
            // volumeLabel
            // 
            this.volumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLabel.Location = new System.Drawing.Point(428, 11);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(50, 23);
            this.volumeLabel.TabIndex = 13;
            this.volumeLabel.Text = "50";
            this.volumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // durationBar
            // 
            this.durationBar.AutoSize = false;
            this.durationBar.Location = new System.Drawing.Point(162, 79);
            this.durationBar.Maximum = 100;
            this.durationBar.Name = "durationBar";
            this.durationBar.Size = new System.Drawing.Size(260, 22);
            this.durationBar.TabIndex = 14;
            this.durationBar.TickFrequency = 5;
            this.durationBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.durationBar_MouseDown);
            this.durationBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.durationBar_MouseUp);
            // 
            // songCurrentDurationLabel
            // 
            this.songCurrentDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songCurrentDurationLabel.Location = new System.Drawing.Point(106, 79);
            this.songCurrentDurationLabel.Name = "songCurrentDurationLabel";
            this.songCurrentDurationLabel.Size = new System.Drawing.Size(50, 22);
            this.songCurrentDurationLabel.TabIndex = 15;
            this.songCurrentDurationLabel.Text = "00:00";
            this.songCurrentDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songDurationMaximum
            // 
            this.songDurationMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songDurationMaximum.Location = new System.Drawing.Point(428, 79);
            this.songDurationMaximum.Name = "songDurationMaximum";
            this.songDurationMaximum.Size = new System.Drawing.Size(50, 22);
            this.songDurationMaximum.TabIndex = 16;
            this.songDurationMaximum.Text = "00:00";
            this.songDurationMaximum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songNameLabel
            // 
            this.songNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.songNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songNameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.songNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.songNameLabel.Location = new System.Drawing.Point(162, 4);
            this.songNameLabel.Multiline = true;
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.ReadOnly = true;
            this.songNameLabel.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.songNameLabel.Size = new System.Drawing.Size(260, 20);
            this.songNameLabel.TabIndex = 18;
            this.songNameLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleScrollTimer
            // 
            this.titleScrollTimer.Interval = 500;
            this.titleScrollTimer.Tick += new System.EventHandler(this.titleScrollTimer_Tick);
            // 
            // noRepeatsCheckbox
            // 
            this.noRepeatsCheckbox.Checked = true;
            this.noRepeatsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noRepeatsCheckbox.Location = new System.Drawing.Point(474, 49);
            this.noRepeatsCheckbox.Name = "noRepeatsCheckbox";
            this.noRepeatsCheckbox.Size = new System.Drawing.Size(98, 24);
            this.noRepeatsCheckbox.TabIndex = 19;
            this.noRepeatsCheckbox.Text = "No Repeats";
            this.noRepeatsCheckbox.UseVisualStyleBackColor = true;
            // 
            // shuffleFolder
            // 
            this.shuffleFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.shuffleFolder.Location = new System.Drawing.Point(12, 56);
            this.shuffleFolder.Name = "shuffleFolder";
            this.shuffleFolder.Size = new System.Drawing.Size(75, 23);
            this.shuffleFolder.TabIndex = 20;
            this.shuffleFolder.Text = "Shuffle Dir";
            this.shuffleFolder.UseVisualStyleBackColor = true;
            this.shuffleFolder.Click += new System.EventHandler(this.shuffleFolder_Click);
            // 
            // stopButton
            // 
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.Location = new System.Drawing.Point(162, 27);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(43, 52);
            this.stopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stopButton.TabIndex = 21;
            this.stopButton.TabStop = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playPauseButton.Image = ((System.Drawing.Image)(resources.GetObject("playPauseButton.Image")));
            this.playPauseButton.Location = new System.Drawing.Point(211, 27);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(76, 52);
            this.playPauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playPauseButton.TabIndex = 22;
            this.playPauseButton.TabStop = false;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // defaultSettingsToolStripMenuItem
            // 
            this.defaultSettingsToolStripMenuItem.Name = "defaultSettingsToolStripMenuItem";
            this.defaultSettingsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.defaultSettingsToolStripMenuItem.Text = "Default settings";
            this.defaultSettingsToolStripMenuItem.Click += new System.EventHandler(this.defaultSettingsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 113);
            this.Controls.Add(this.playPauseButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.shuffleFolder);
            this.Controls.Add(this.noRepeatsCheckbox);
            this.Controls.Add(this.songNameLabel);
            this.Controls.Add(this.songDurationMaximum);
            this.Controls.Add(this.songCurrentDurationLabel);
            this.Controls.Add(this.durationBar);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.shuffleSongs);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.selectSong);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.skipButton)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shuffleSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPauseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectSong;
        private System.Windows.Forms.OpenFileDialog songSelector;
        private System.Windows.Forms.FolderBrowserDialog musicFolderSelector;
        private System.Windows.Forms.Timer songTimer;
        private System.Windows.Forms.PictureBox skipButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultFolderToolStripMenuItem;
        private System.Windows.Forms.PictureBox shuffleSongs;
        private System.Windows.Forms.Timer progressBarUpdate;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TrackBar volumeSlider;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.TrackBar durationBar;
        private System.Windows.Forms.Label songCurrentDurationLabel;
        private System.Windows.Forms.Label songDurationMaximum;
        private System.Windows.Forms.TextBox songNameLabel;
        private System.Windows.Forms.Timer titleScrollTimer;
        private System.Windows.Forms.ToolStripMenuItem viewFolderToolStripMenuItem;
        private System.Windows.Forms.CheckBox noRepeatsCheckbox;
        private System.Windows.Forms.Button shuffleFolder;
        private System.Windows.Forms.PictureBox stopButton;
        private System.Windows.Forms.PictureBox playPauseButton;
        private System.Windows.Forms.ToolStripMenuItem defaultSettingsToolStripMenuItem;
    }
}

