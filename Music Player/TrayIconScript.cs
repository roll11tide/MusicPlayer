using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    class TrayIconScript
    {
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private Form1 form1;

        public void initializeTrayIcon(Form1 form1)
        {
            this.form1 = form1;
            trayIcon = new NotifyIcon();
            trayIcon.Text = "Music Player";
            Icon icon = new Icon("Music Note.ico");
            trayIcon.Icon = icon;

            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Play", contextPlay_Click);
            trayMenu.MenuItems.Add("Pause", contextPause_Click);
            trayMenu.MenuItems.Add("Skip", contextSkip_Click);

            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
        }

        public void diposeAll()
        {
            trayIcon.Visible = false;
            trayIcon.Icon = null;
            trayIcon.Dispose();
            trayIcon = null;

            trayMenu.Dispose();
            form1.Dispose();
        }

        private void contextPlay_Click(object sender, EventArgs e)
        {
            form1.universalPlay();
        }

        private void contextPause_Click(object sender, EventArgs e)
        {
            form1.universalPause();
        }

        private void contextSkip_Click(object sender, EventArgs e)
        {
            form1.universalSkip();
        }
    }
}