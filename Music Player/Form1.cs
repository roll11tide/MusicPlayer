using System;
using System.Windows.Forms;
using System.IO;
using TagLib;
using System.Collections.Generic;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        #region TODOs
        /*
        Add key shortcuts
        Fix multiple play prevention function
        Add a GUI for viewing songs in a folder
        Make this the default music player for windows
        */
        #endregion

        #region Variable Declarations
        Random random = new Random();
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        TrayIconScript tis = new TrayIconScript();
        public string[] universalShufflePaths;
        public static Settings.SettingsObject settings = new Settings.SettingsObject();
        string tempFolderPath = "";
        #endregion

        #region Global Boolean Flags
        bool songSelected = false;
        bool isShuffling = false;
        bool isPaused = false;
        bool changingDuration = false;
        #endregion

        public Form1()
        {
            InitializeComponent();
            Settings.initializeSettings();

            wplayer.settings.volume = settings.DefaultVolume;
            volumeSlider.Value = wplayer.settings.volume;
            tis.initializeTrayIcon(this);
            volumeLabel.Text = wplayer.settings.volume.ToString();
        }

        #region Event Handlers
        private void selectSong_Click(object sender, EventArgs e)
        {
            if (songSelector.ShowDialog() == DialogResult.OK)
            {
                songSelected = true;
                isPaused = false;
            }
        }

        private void shuffleSongs_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(settings.DefaultShufflePath))
            {
                MessageBox.Show("No default folder selected.", "Missing Default Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                NoRepeat.emptySongCache();
                tempFolderPath = "";
                shuffleSongRoutine();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopPlayer();
        }

        private void shuffleFolder_Click(object sender, EventArgs e)
        {
            musicFolderSelector.Reset();

            if (!String.IsNullOrWhiteSpace(settings.LastDirectoryViewed))
            {
                musicFolderSelector.SelectedPath = settings.LastDirectoryViewed;
            }

            if (musicFolderSelector.ShowDialog() == DialogResult.OK)
            {
                tempFolderPath = musicFolderSelector.SelectedPath;
            }

            NoRepeat.emptySongCache();
            shuffleSongRoutine();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            universalSkip();
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            if (wplayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                universalPause();
            } else
            {
                universalPlay();
            }
        }

        private void setDefaultFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(settings.LastDirectoryViewed))
            {
                musicFolderSelector.Reset();
                musicFolderSelector.SelectedPath = settings.LastDirectoryViewed;
            }

            DialogResult dr = musicFolderSelector.ShowDialog();

            if (dr == DialogResult.OK)
            {
                settings.DefaultShufflePath = musicFolderSelector.SelectedPath;
                settings.LastDirectoryViewed = musicFolderSelector.SelectedPath;
                Settings.saveSettings();
            }
        }

        private void defaultSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.defaultSettings();
        }

        private void viewFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderViewScript fvs = new FolderViewScript();
            fvs.Show();
            if (universalShufflePaths != null)
            {
                fvs.setContentView(universalShufflePaths);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tis.diposeAll();
            Application.Exit();
        }

        private void songTimer_Tick(object sender, EventArgs e)
        {
            // The song finished and if the player is in shuffling mode, play another song
            if (isShuffling)
            {
                if (changingDuration)
                {
                    songTimer.Interval = (int)wplayer.controls.currentItem.duration - (int)wplayer.controls.currentPosition;
                    changingDuration = false;
                    songTimer.Start();
                }
                else
                {
                    shuffleSongRoutine();
                    songTimer.Start();
                    songDurationMaximum.Text = wplayer.currentMedia.durationString;
                    durationBar.Maximum = Convert.ToInt32(wplayer.controls.currentItem.duration);
                    songNameLabel.Text = wplayer.currentMedia.name + " ";
                    titleScrollTimer.Start();
                }
            }
        }

        private void progressBarUpdate_Tick(object sender, EventArgs e)
        {
            try
            {
                songDurationMaximum.Text = wplayer.currentMedia.durationString;
                durationBar.Maximum = Convert.ToInt32(wplayer.controls.currentItem.duration);

                if (wplayer != null)
                {
                    double percent = 0;
                    percent = ((double)wplayer.controls.currentPosition / wplayer.controls.currentItem.duration);
                    durationBar.Value = Convert.ToInt32(Convert.ToDecimal(wplayer.controls.currentPosition));
                    songCurrentDurationLabel.Text = wplayer.controls.currentPositionString;
                }

                // Laziest fix possible
                if (songCurrentDurationLabel.Text == "")
                {
                    universalSkip();
                }

                progressBarUpdate.Start();
            } catch
            {
                
            }
        }

        private void volumeSlider_ValueChanged(object sender, EventArgs e)
        {
            wplayer.settings.volume = volumeSlider.Value;
            volumeLabel.Text = wplayer.settings.volume.ToString();
        }

        private void durationBar_MouseUp(object sender, MouseEventArgs e)
        {
            wplayer.controls.currentPosition = durationBar.Value;
            songTimer.Stop();
            changingDuration = true;
            songTimer.Start();
            progressBarUpdate.Start();
        }

        private void durationBar_MouseDown(object sender, MouseEventArgs e)
        {
            progressBarUpdate.Stop();
        }

        private void titleScrollTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                songNameLabel.Text = songNameLabel.Text.Substring(1, songNameLabel.Text.Length - 1) + songNameLabel.Text.Substring(0, 1);
                titleScrollTimer.Start();
            } catch
            {

            }
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            tis.diposeAll();
        }
        #endregion

        #region Universal Declarations
        public void universalPlay()
        {
            if (isPaused)
            {
                wplayer.controls.play();
            } else if (songSelected)
            {
                string path = songSelector.FileName;
                Stream songPath = Return_Methods.GenerateStreamFromString(path);
                if (Return_Methods.returnTypeOfFile(path) == ".wav" || Return_Methods.returnTypeOfFile(path) == ".mp3")
                {
                    if (wplayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        wplayer.URL = path;
                        wplayer.controls.play();
                        isPaused = false;
                        songDurationMaximum.Text = wplayer.currentMedia.durationString;
                        durationBar.Maximum = Convert.ToInt32(wplayer.controls.currentItem.duration);
                        songNameLabel.Text = wplayer.currentMedia.name + " ";
                        titleScrollTimer.Start();

                        #region Old Code
                        /*if (NoRepeat.checkIfNew(path) | !noRepeatsCheckbox.Checked)
                        {
                            wplayer.URL = path;
                            wplayer.controls.play();
                            isPaused = false;
                            songDurationMaximum.Text = wplayer.currentMedia.durationString;
                            durationBar.Maximum = Convert.ToInt32(wplayer.controls.currentItem.duration);
                            songNameLabel.Text = wplayer.currentMedia.name + " ";
                            titleScrollTimer.Start();
                            NoRepeat.logSong(path);
                        } else
                        {
                            bool availableSong = false;
                            string[] filePathsArray = Directory.GetFiles(settings.DefaultShufflePath);
                            foreach (string item in filePathsArray)
                            {
                                if (!NoRepeat.playedSongs.Contains(item))
                                {
                                    availableSong = true;
                                }
                            }

                            if (availableSong)
                            {
                                shuffleSongRoutine();
                            } else
                            {
                                stopPlayer();
                                MessageBox.Show("Finished playing through directory.", "Finished Playing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }*/
                        #endregion
                    }
                }
                else
                {
                    MessageBox.Show("This file extension is unsupported.");
                }
            }
            else if (isShuffling)
            {
                wplayer.controls.play();
                songTimer.Start();
            }
            else
            {
                MessageBox.Show("A song has not been selected.", "No Song Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            progressBarUpdate.Start();
        }

        private void shuffleSongRoutine()
        {
            if (songTimer.Enabled)
            {
                songTimer.Stop();
            }

            string[] filePathsArray = new string[] { };
            if (String.IsNullOrWhiteSpace(tempFolderPath))
            {
                // No temp shuffle folder - using default
                if (System.IO.Directory.Exists(settings.DefaultShufflePath))
                {
                    filePathsArray = Directory.GetFiles(settings.DefaultShufflePath);
                } else
                {
                    MessageBox.Show("Default shuffle directory does not exist.", "Invalid Default Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                filePathsArray = Directory.GetFiles(tempFolderPath);
            }
            
            if (filePathsArray.Length != 0)
            {
                universalShufflePaths = filePathsArray;
                int fileCounter = filePathsArray.Length;
                int index = random.Next(0, fileCounter);
                string filePath = filePathsArray[index];
                
                if (!NoRepeat.activeList & noRepeatsCheckbox.Checked)
                {
                    NoRepeat.newSongs = new List<string>(filePathsArray);
                    NoRepeat.activeList = true;
                }
                
                Stream songPath = Return_Methods.GenerateStreamFromString(filePath);

                if (Return_Methods.returnTypeOfFile(filePath) == ".wav" || Return_Methods.returnTypeOfFile(filePath) == ".mp3")
                {
                    wplayer.controls.stop();
                    bool playSong = true;

                    if (noRepeatsCheckbox.Checked)
                    {
                        // User asked for no repeats
                        filePath = NoRepeat.returnNewSongPath();
                        
                        if (filePath == "empty")
                        {
                            stopPlayer();
                            playSong = false;
                        } else if (!System.IO.File.Exists(filePath))
                        {
                            stopPlayer();
                            playSong = false;
                            MessageBox.Show("Invalid file path.", "Unable to Play", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (playSong)
                    {
                        // Set the song path and play it
                        wplayer.URL = filePath;
                        wplayer.controls.play();

                        // Set global flags
                        isShuffling = true;
                        songSelected = false;

                        // Set timer interval and begin its counting
                        songTimer.Interval = Return_Methods.getLengthOfSong(filePath);
                        songTimer.Start();

                        // Sets the duration maximum label on the righthand side of the progress bar and starts the progress bar
                        songDurationMaximum.Text = wplayer.currentMedia.durationString;
                        durationBar.Maximum = Convert.ToInt32(wplayer.controls.currentItem.duration);
                        progressBarUpdate.Start();

                        // Sets the song label so the user can see which song is playing and begins the name scroll method so the user can see the entire name
                        songNameLabel.Text = wplayer.currentMedia.name + " ";
                        titleScrollTimer.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Unsupported file extension.", "Unable to Play File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void stopPlayer()
        {
            NoRepeat.emptySongCache();
            isShuffling = false;
            isPaused = false;

            if (wplayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wplayer.controls.stop();
            }
            
            songNameLabel.Text = "";
        }

        public void universalPause()
        {
            try
            {
                wplayer.controls.pause();
                songTimer.Stop();
                isPaused = true;

                int currentPosition = (int)wplayer.controls.currentPosition;
                songTimer.Interval = ((int)wplayer.controls.currentItem.duration - currentPosition) * 1000;
            }
            catch
            {

            }
        }

        public void universalSkip()
        {
            // This method only works while the player is shuffling
            if (isShuffling)
            {
                wplayer.controls.stop();
                shuffleSongRoutine();
            }
        }
        #endregion
    }
}