using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace Music_Player
{
    public partial class FolderViewScript : Form
    {
        public FolderViewScript()
        {
            InitializeComponent();
        }

        public void setContentView(string[] filePaths)
        {
            contentView.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            contentView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contentView.AutoSize = true;
            contentView.SuspendLayout();
            Array.Sort(filePaths);

            foreach (string filePath in filePaths)
            {
                TagLib.File file = TagLib.File.Create(filePath);
                int timeInSeconds = (int)file.Properties.Duration.TotalSeconds;
                int spareSeconds = timeInSeconds % 60;
                int timeInMinutes = timeInSeconds - spareSeconds;
                string duration = timeInMinutes.ToString() + ":" + spareSeconds.ToString();

                contentView.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                contentView.Controls.Add(new Label() { Text =  Path.GetFileNameWithoutExtension(filePath)}, 1, contentView.RowCount - 1);
                contentView.Controls.Add(new Label() { Text = duration }, 1, contentView.RowCount - 1);
            }

            contentView.AutoScrollMinSize = new Size(400, (contentView.Height * 5 - 270));
            contentView.ResumeLayout();
        }

        public void playSong(string path)
        {
            // Add in playing songs using the Form1 script
        }
    }
}
