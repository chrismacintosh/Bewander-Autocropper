using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Net.Http;


namespace Bewandercropper
{
    public partial class main : Form
    {
        //Filesystemwatcher instance.
        FileSystemWatcher watcher = new FileSystemWatcher();

        public class ReviewAPIViewModel
        {
            public int ReviewID { get; set; }
            public string UsersFullName { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
            public int ResidentType { get; set; }
            public int SubjectType { get; set; }
            public int StarRating { get; set; }
            public int CostRating { get; set; }
            public string DatePosted { get; set; }
            public string PlaceName { get; set; }
            public string Website { get; set; }

            //Image object... for later. Not sure how I'll handle this.
            //public Image profilepic { get; set; }


        }

        public async void updateLatestReview()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("http://bewander.com/api/ReviewAPI/");
                List<string> errors = new List<string>();

                
                response.EnsureSuccessStatusCode(); //This may or may not be irrelevant, since if the request fails the catch block will occur.
                string responseStr =  response.Content.ReadAsStringAsync().Result;
                //This is 100% necessary due to how IHTTPActionResult returns our HttpResponseMessage with extra's
                
                responseStr = responseStr
                                             .Replace("\\", "")
                                               .Trim(new char[1] { '"' });
                
                ReviewAPIViewModel result = new ReviewAPIViewModel();
                result = JsonConvert.DeserializeObject<ReviewAPIViewModel>(responseStr, new JsonSerializerSettings
                {
                    Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
                    {
                        //eror handling... because stuff happens!
                        errors.Add(args.ErrorContext.Error.Message);
                        args.ErrorContext.Handled = true;
                    },
                    Converters = { new Newtonsoft.Json.Converters.IsoDateTimeConverter() }
                });

                ReviewLabelDatePosted.Text = result.DatePosted;
                ReviewLabelLocation.Text = result.PlaceName;
                ReviewLabelUserFullName.Text = result.UsersFullName;
                ReviewLabelCost.Text = result.CostRating.ToString();
                ReviewLabelBody.Text = result.Body.ToString();
                ReviewLabelTitle.Text = result.Title.ToString();
                ReviewLabelHyperlink.Tag = result.Website.ToString();

                //Set hyperlink to unviewed
                ReviewLabelHyperlink.LinkVisited = false;

                //userimage.Image = new Bitmap(result.profilepic);

                result.StarRating = result.StarRating / 2; //Stars are actually 0-10... Did NOT even notice that when I wrote this.
                //This is fun. I need to learn a more efficient way to do this...
                if(result.StarRating == 1)
                {
                    var image = new Bitmap(Properties.Resources.goldstar_1);
                    ReviewLabelStars.Image = image;
                }
                else if(result.StarRating == 2)
                {
                    var image = new Bitmap(Properties.Resources.goldstar_2);
                    ReviewLabelStars.Image = image;
                }
                else if(result.StarRating == 3)
                {
                    var image = new Bitmap(Properties.Resources.goldstar_3);
                    ReviewLabelStars.Image = image;
                }
                else if(result.StarRating == 4)
                {
                    var image = new Bitmap(Properties.Resources.goldstar_4);
                    ReviewLabelStars.Image = image;
                }
                else if(result.StarRating == 5)
                {
                    var image = new Bitmap(Properties.Resources.goldstar_5);
                    ReviewLabelStars.Image = image;
                }


            }
            //This exception will occur if line 51 fails (if the server cannot be contacted).
            //Instead of crashing the app, just display in the status bar what happened.
            catch (HttpRequestException e)
            {
                toolStripStatusLabel.Text = "Failed to contact Bewander server.";
            }
            finally
            {
                
            }

        }
        public void watcher_start()
        {
            try
            {
                toolStripStatusLabel.Text = "Checking configuration settings...";

                //Check if config is valid... Cause we dun' like bugs round these neck o' da woods.
                if (isConfigValid())
                {
                    toolStripStatusLabel.Text = "Settings are valid, setting up FileSystemWatcher.";
                    //Set FileSystemWatcher to watch the input directory
                    watcher.Path = Properties.Settings.Default.inputdirectory;

                    //Maybe need to add more logic for this, not gonna enable it for now.
                    watcher.IncludeSubdirectories = false;

                    //What do we want the watcher to notice? New filenames...
                    watcher.NotifyFilter = NotifyFilters.FileName;

                    //Watch for all file types. File Type Validation is dealt with later.
                    watcher.Filter = "*.*";

                    //Register handler function when the event is raised
                    watcher.Created += new FileSystemEventHandler(handler_newfile);

                    //Start the watcher
                    watcher.EnableRaisingEvents = true;
                }
            }
            finally
            {
                //Update notifications or logging here. Some sort of status indicator.
                toolStripStatusLabel.Text = "Watching " + Properties.Settings.Default.inputdirectory + " for files";
            }
        }

        public void watcher_stop()
        {
            toolStripStatusLabel.Text = "Stopping FileSystemWatcher...";
            try
            {
                //Disable the filesystemwatcher.
                watcher.EnableRaisingEvents = false;
            }
            finally
            {
                //Logging. Status messages. Something.
                toolStripStatusLabel.Text = "Stopped.";
            }
        }
        public bool isConfigValid()
        {
            //Try to write an image to both directories, then delete it.
            //If that is possible, then we can return true. Otherwise, return false.
            using (Bitmap image = new Bitmap(Properties.Resources.logo_with_sides))
            {
                try
                {
                    //Declare full path name, including file.
                    string fullPathin = Properties.Settings.Default.inputdirectory + "configValidation.png";
                    string fullPathout = Properties.Settings.Default.outputdirectory + "configValidation.png";
                    //Save
                    image.Save(fullPathin);
                    image.Save(fullPathout);
                    //Delete
                    File.Delete(fullPathin);
                    File.Delete(fullPathout);

                    //Return true, since no exceptions were thrown.
                    return true;
                }
                catch (Exception e)
                {
                    toolStripStatusLabel.Text = "Failed to validate configuration settings! Check folder read/write permissions." + e.Message;
                    return false;
                }
                finally
                {
                    //Dispose
                    image.Dispose();
                }
            }
        }

        public void handler_newfile(object source, FileSystemEventArgs e)
        {
            toolStripStatusLabel.Text = "Received " + e.Name + "... Checking file type.";
            if (isFileTypeValid(e))
            {
                toolStripStatusLabel.Text = "Filetype ok! Processing " + e.Name + "...";
                //Declare
                string destinationFile = Properties.Settings.Default.outputdirectory + "\\" + e.Name;

                //Copy the untouched, original photo to the destination directory.
                File.Copy(e.FullPath, destinationFile);

                //Declare how much we're cropping.
                double width, height;
                Image target = Image.FromFile(e.FullPath);
                width = target.Width * .98;
                height = target.Height * .98;
                //Start at 0x, 0y, and crop keep X of the image to the right, and Y of the image down.
                //Throwing (int) in front of width and height tells them to act as integers.
                Rectangle cropArea = new Rectangle(0, 0, (int)width, (int)height);

                toolStripStatusLabel.Text = "Cropping...";
                //Make a new image from the above specs
                Bitmap croppedImage = cropImage(target, cropArea);
                toolStripStatusLabel.Text = "Finished cropping!";

                //Now that we're done with the target image object, let's get rid of it's resource usage.
                target.Dispose();

                //Delete the uncropped original image from the source directory.
                File.Delete(e.FullPath);

                //Declare where the output directory is, and format the file name.
                string newFullPath = Properties.Settings.Default.inputdirectory + "\\Cropped" + e.Name;

                //Now that we have a new image name, let's save it to the source directory.
                croppedImage.Save(newFullPath);

                //Now we can dispose that instance too.
                croppedImage.Dispose();

                toolStripStatusLabel.Text = "Successfully processed " + e.Name + "!";
            }
        }

        private static Bitmap cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }
        public bool isFileTypeValid(FileSystemEventArgs e)
        {
            //Get file extension
            string fileExtension = Path.GetExtension(e.FullPath);

            //Check file types, and make sure this photo hasn't been cropped already.
            if (Regex.IsMatch(fileExtension, @"\.jpeg|\.gif|\.png|\.jpg") && !Regex.IsMatch(e.Name, @"Cropped"))
            {
                return true;
            }
            else { return false; }
        }
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
                    BewanderTrayIcon.ShowBalloonTip(300);
                }
                //Don't display the tray icon, because the user doesn't want to start minimized.
                else
                {
                    BewanderTrayIcon.Visible = false;
                }
                updateLatestReview();
            }
        }

        //Called when window is resized (such as minimized)
        private void main_Resize(object sender, EventArgs e)
        {
            updateLatestReview();

            BewanderTrayIcon.BalloonTipTitle = "Notifcations";
            BewanderTrayIcon.BalloonTipText = "Bewander is running in the system tray!";

            //If the window is minimized
            if (FormWindowState.Minimized == this.WindowState)
            {
                //Make system tray icon visible
                BewanderTrayIcon.Visible = true;

                //Display balloon notifcation window
                BewanderTrayIcon.ShowBalloonTip(300);

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
            watcher_start();
            //Enable stop button, since they just clicked the start button.
            buttonStop.Enabled = true;
            //Disable start button, since they just clicked it.
            buttonStart.Enabled = false;
        }

        //Stop button
        private void buttonStop_Click(object sender, EventArgs e)
        {
            watcher_stop();
            //Enable start button, since they just clicked the stop button.
            buttonStart.Enabled = true;
            //Disable stop button, since they just clicked it.
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

        private void ReviewLabelHyperlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ReviewLabelHyperlink.LinkVisited = true;

            System.Diagnostics.Process.Start(ReviewLabelHyperlink.Tag.ToString());
        }
    }
}
