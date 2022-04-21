using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Media;
using Music_Player;
using WMPLib;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variable Declarations
        int fileCounter = 0;
        Random random = new Random();
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        bool songIsPlaying = false;
        #endregion

        #region Button Event Handlers
        private void selectSong_Click(object sender, EventArgs e)
        {
            songSelector.ShowDialog();
        }

        private void playSong_Click(object sender, EventArgs e)
        {
            try
            {
                string path = songSelector.FileName;
                Stream songPath = GenerateStreamFromString(path);
                if (returnTypeOfFile(path) == ".wav" || returnTypeOfFile(path) == ".mp3")
                {
                    if (songIsPlaying)
                    {
                        wplayer.controls.play();
                    } else
                    {
                        songIsPlaying = true;
                        wplayer.URL = path;
                        wplayer.controls.play();
                    }
                }
                else
                {
                    MessageBox.Show("This file extension is unsupported.");
                }
            }
            catch
            {
                MessageBox.Show("Either you have not selected a song or there is a bug, more likely the former.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void shuffleSongs_Click(object sender, EventArgs e)
        {
            string path = createRandomSongPath();
            Stream songPath = GenerateStreamFromString(path);

            if (returnTypeOfFile(path) == ".wav" || returnTypeOfFile(path) == ".mp3")
            {
                if (songIsPlaying)
                {
                    wplayer.controls.play();
                } else
                {
                    songIsPlaying = true;
                    wplayer.URL = createRandomSongPath();
                    wplayer.controls.play();
                }
            }
            else
            {
                MessageBox.Show("This file extension is not supported.", "File Extension Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopShuffle_Click(object sender, EventArgs e)
        {

        }

        private void pauseSong_Click(object sender, EventArgs e)
        {
            songIsPlaying = false;
            wplayer.controls.pause();
        }

        private void wplayer_EndOfStream(object sender, EventArgs e)
        {
            songIsPlaying = false;
        }
        #endregion

        #region Functional Methods and Routines
        private string returnTypeOfFile(string path)
        {
            string extension = Path.GetExtension(path);
            return extension;
        }

        private MemoryStream GenerateStreamFromString(string value)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(value ?? ""));
        }

        public string createRandomSongPath()
        {
            try
            {
                musicFolderSelector.ShowDialog();
                string folderPath = musicFolderSelector.SelectedPath;
                // string[] filePaths = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.System) + "/MusicPlayer");
                string[] filePaths = Directory.GetFiles(folderPath);
                // TODO Use the .count method to improve the resposiveness of this code.
                fileCounter = 0;
                foreach (string path in filePaths)
                {
                    fileCounter++;
                }
                int index = random.Next(0, fileCounter);
                MessageBox.Show(index.ToString());
                return filePaths[index];
            }
            catch
            {
                return "";
            }
        }
        #endregion
    }
}