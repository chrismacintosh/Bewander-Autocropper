using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bewandercropper
{
    public partial class firstrun : Form
    {
        public firstrun()
        {
            InitializeComponent();
        }

        private void button_originDir_Click(object sender, EventArgs e)
        {
            //Prompt user to choose a directory
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //Set application user setting for input directory and save it
                    Properties.Settings.Default.inputdirectory = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                    //Enable next steps button (proactive form validation)
                    button_destinationDir.Enabled = true;
                }
            }
        }

        private void button_destinationDir_Click(object sender, EventArgs e)
        {
            //Prompt user to choose a directory
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //Set application user setting for input directory and save it
                    Properties.Settings.Default.outputdirectory = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                    //Enable continue button (proactive form validation)
                    button_continue.Enabled = true;
                }
            }
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            //Change firstrun flag to false and save, since we've gotten this far.
            Properties.Settings.Default.firstrun = false;
            Properties.Settings.Default.Save();
            //get rid of resources used by firstrun.cs
            main MainForm = new Bewandercropper.main();
            //Hide current setup form
            this.Hide();
            //Show new form
            MainForm.Show();
        }

        private void checkBox_startwithWin_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.startupLaunch = checkBox_startwithWin.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.startMinimized = checkBox_startMinimized.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
