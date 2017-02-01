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

namespace Bewandercropper
{
    public partial class main : Form
    {
        //Filesystemwatcher instance.
        //FileSystemWatcher watcher = new FileSystemWatcher();
        public main()
        {
            InitializeComponent();
        }

        //Called when main window loads
        private void main_Load(object sender, EventArgs e)
        {
            //Check that the config is indeed loaded and not blank.
            if (Properties.Settings.Default.inputdirectory != "" && Properties.Settings.Default.outputdirectory != "")
            {
                //If user setting startMinimized = true
                if (Properties.Settings.Default.startMinimized)
                {
                    //Make system tray icon visible
                    BewanderTrayIcon.Visible = true;
                    //Don't show Bewander app in taskbar
                    this.ShowInTaskbar = false;
                    //Hide bewander window.
                    this.Hide();
                    //Set balloon tip information to notify user that the app successfully launched (some people might not notice! darn end users!)
                    BewanderTrayIcon.BalloonTipTitle = "Notifcations";
                    BewanderTrayIcon.BalloonTipText = "Bewander started in system tray!";
                    //Display balloon tip for 5 seconds
                    BewanderTrayIcon.ShowBalloonTip(500);
                }
                else
                {
                    BewanderTrayIcon.Visible = false;
                }
            }
        }

        //Called when window is resized (such as minimized)
        private void main_Resize(object sender, EventArgs e)
        {
            BewanderTrayIcon.BalloonTipTitle = "Notifcations";
            BewanderTrayIcon.BalloonTipText = "Bewander is running in the system tray!";

            //If the window is minimized
            if (FormWindowState.Minimized == this.WindowState)
            {
                //Make system tray icon visible
                BewanderTrayIcon.Visible = true;

                //Display balloon notifcation window
                BewanderTrayIcon.ShowBalloonTip(500);

                //Remove application from taskbar
                this.ShowInTaskbar = false;
                //Hide form window
                this.Hide();
            }
            else if (FormWindowState.Maximized == this.WindowState)
            {
                //If the window is maximized, don't display the system tray icon anymore.
                BewanderTrayIcon.Visible = false;
            }
        }

        //Start button
        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;
        }

        //Stop button
        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        //Called when you double click the system tray Bewander icon
        private void BewanderTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Show form on display
            this.Show();
            //Set Window State
            this.WindowState = FormWindowState.Normal;
            //Show application in taskbar
            this.ShowInTaskbar = true;
            //Remove system tray icon
            BewanderTrayIcon.Visible = false;
        }
    }
}
