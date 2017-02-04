namespace Bewandercropper
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.BewanderTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ReviewLabelBody = new System.Windows.Forms.Label();
            this.ReviewLabelTitle = new System.Windows.Forms.Label();
            this.ReviewLabelStars = new System.Windows.Forms.Label();
            this.ReviewLabelCost = new System.Windows.Forms.Label();
            this.ReviewLabelUserFullName = new System.Windows.Forms.Label();
            this.ReviewLabelLocation = new System.Windows.Forms.Label();
            this.ReviewLabelDatePosted = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReviewLabelHyperlink = new System.Windows.Forms.LinkLabel();
            this.ReviewLabelUserPhoto = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(753, 86);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(753, 115);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // BewanderTrayIcon
            // 
            this.BewanderTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("BewanderTrayIcon.Icon")));
            this.BewanderTrayIcon.Text = "Bewander Autocropper";
            this.BewanderTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BewanderTrayIcon_MouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 649);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1249, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Location = new System.Drawing.Point(0, 144);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.ReviewLabelUserPhoto);
            this.splitContainer1.Panel1.Controls.Add(this.ReviewLabelHyperlink);
            this.splitContainer1.Panel1.Controls.Add(this.ReviewLabelBody);
            this.splitContainer1.Panel1.Controls.Add(this.ReviewLabelTitle);
            this.splitContainer1.Panel1.Controls.Add(this.ReviewLabelStars);
            this.splitContainer1.Panel1.Controls.Add(this.ReviewLabelCost);
            this.splitContainer1.Panel1.Controls.Add(this.ReviewLabelUserFullName);
            this.splitContainer1.Panel1.Controls.Add(this.ReviewLabelLocation);
            this.splitContainer1.Panel1.Controls.Add(this.ReviewLabelDatePosted);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Size = new System.Drawing.Size(1234, 442);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.TabIndex = 3;
            // 
            // ReviewLabelBody
            // 
            this.ReviewLabelBody.AutoSize = true;
            this.ReviewLabelBody.Location = new System.Drawing.Point(12, 71);
            this.ReviewLabelBody.Name = "ReviewLabelBody";
            this.ReviewLabelBody.Size = new System.Drawing.Size(31, 13);
            this.ReviewLabelBody.TabIndex = 11;
            this.ReviewLabelBody.Text = "Body";
            // 
            // ReviewLabelTitle
            // 
            this.ReviewLabelTitle.AutoSize = true;
            this.ReviewLabelTitle.Location = new System.Drawing.Point(170, 48);
            this.ReviewLabelTitle.Name = "ReviewLabelTitle";
            this.ReviewLabelTitle.Size = new System.Drawing.Size(27, 13);
            this.ReviewLabelTitle.TabIndex = 10;
            this.ReviewLabelTitle.Text = "Title";
            // 
            // ReviewLabelStars
            // 
            this.ReviewLabelStars.AutoSize = true;
            this.ReviewLabelStars.Location = new System.Drawing.Point(136, 349);
            this.ReviewLabelStars.MaximumSize = new System.Drawing.Size(110, 22);
            this.ReviewLabelStars.MinimumSize = new System.Drawing.Size(110, 22);
            this.ReviewLabelStars.Name = "ReviewLabelStars";
            this.ReviewLabelStars.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReviewLabelStars.Size = new System.Drawing.Size(110, 22);
            this.ReviewLabelStars.TabIndex = 9;
            // 
            // ReviewLabelCost
            // 
            this.ReviewLabelCost.AutoSize = true;
            this.ReviewLabelCost.Location = new System.Drawing.Point(49, 48);
            this.ReviewLabelCost.Name = "ReviewLabelCost";
            this.ReviewLabelCost.Size = new System.Drawing.Size(60, 13);
            this.ReviewLabelCost.TabIndex = 8;
            this.ReviewLabelCost.Text = "CostRange";
            // 
            // ReviewLabelUserFullName
            // 
            this.ReviewLabelUserFullName.AutoSize = true;
            this.ReviewLabelUserFullName.Location = new System.Drawing.Point(272, 256);
            this.ReviewLabelUserFullName.Name = "ReviewLabelUserFullName";
            this.ReviewLabelUserFullName.Size = new System.Drawing.Size(73, 13);
            this.ReviewLabelUserFullName.TabIndex = 7;
            this.ReviewLabelUserFullName.Text = "UserFullName";
            // 
            // ReviewLabelLocation
            // 
            this.ReviewLabelLocation.AutoSize = true;
            this.ReviewLabelLocation.Location = new System.Drawing.Point(155, 336);
            this.ReviewLabelLocation.Name = "ReviewLabelLocation";
            this.ReviewLabelLocation.Size = new System.Drawing.Size(62, 13);
            this.ReviewLabelLocation.TabIndex = 6;
            this.ReviewLabelLocation.Text = "PlaceName";
            // 
            // ReviewLabelDatePosted
            // 
            this.ReviewLabelDatePosted.AutoSize = true;
            this.ReviewLabelDatePosted.Location = new System.Drawing.Point(254, 48);
            this.ReviewLabelDatePosted.Name = "ReviewLabelDatePosted";
            this.ReviewLabelDatePosted.Size = new System.Drawing.Size(53, 13);
            this.ReviewLabelDatePosted.TabIndex = 5;
            this.ReviewLabelDatePosted.Text = "DateTime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vladimir Script", 30F);
            this.label1.Location = new System.Drawing.Point(95, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latest Review";
            // 
            // ReviewLabelHyperlink
            // 
            this.ReviewLabelHyperlink.AutoSize = true;
            this.ReviewLabelHyperlink.Location = new System.Drawing.Point(15, 380);
            this.ReviewLabelHyperlink.Name = "ReviewLabelHyperlink";
            this.ReviewLabelHyperlink.Size = new System.Drawing.Size(238, 13);
            this.ReviewLabelHyperlink.TabIndex = 12;
            this.ReviewLabelHyperlink.TabStop = true;
            this.ReviewLabelHyperlink.Text = "Other reviews for this location (click here to view)";
            this.ReviewLabelHyperlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReviewLabelHyperlink_LinkClicked);
            // 
            // ReviewLabelUserPhoto
            // 
            this.ReviewLabelUserPhoto.AutoSize = true;
            this.ReviewLabelUserPhoto.Location = new System.Drawing.Point(245, 71);
            this.ReviewLabelUserPhoto.MaximumSize = new System.Drawing.Size(150, 150);
            this.ReviewLabelUserPhoto.MinimumSize = new System.Drawing.Size(150, 150);
            this.ReviewLabelUserPhoto.Name = "ReviewLabelUserPhoto";
            this.ReviewLabelUserPhoto.Size = new System.Drawing.Size(150, 150);
            this.ReviewLabelUserPhoto.TabIndex = 13;
            this.ReviewLabelUserPhoto.Text = "User Profile Photo";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bewandercropper.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1249, 671);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1265, 710);
            this.MinimumSize = new System.Drawing.Size(1265, 710);
            this.Name = "main";
            this.Text = "Bewander Cropper";
            this.Load += new System.EventHandler(this.main_Load);
            this.Resize += new System.EventHandler(this.main_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.NotifyIcon BewanderTrayIcon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ReviewLabelCost;
        private System.Windows.Forms.Label ReviewLabelUserFullName;
        private System.Windows.Forms.Label ReviewLabelLocation;
        private System.Windows.Forms.Label ReviewLabelDatePosted;
        private System.Windows.Forms.Label ReviewLabelStars;
        private System.Windows.Forms.Label ReviewLabelBody;
        private System.Windows.Forms.Label ReviewLabelTitle;
        private System.Windows.Forms.LinkLabel ReviewLabelHyperlink;
        private System.Windows.Forms.Label ReviewLabelUserPhoto;
    }
}

