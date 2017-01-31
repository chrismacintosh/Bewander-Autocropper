namespace Bewandercropper
{
    partial class firstrun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firstrun));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_originDir = new System.Windows.Forms.Button();
            this.button_destinationDir = new System.Windows.Forms.Button();
            this.button_continue = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_startwithWin = new System.Windows.Forms.CheckBox();
            this.checkBox_startMinimized = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setup Instructions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1.) Select the directory you put your newly captured photos in:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2.) Select the directory to copy your original uncropped photos to:";
            // 
            // button_originDir
            // 
            this.button_originDir.Location = new System.Drawing.Point(333, 34);
            this.button_originDir.Name = "button_originDir";
            this.button_originDir.Size = new System.Drawing.Size(75, 23);
            this.button_originDir.TabIndex = 3;
            this.button_originDir.Text = "Browse";
            this.button_originDir.UseVisualStyleBackColor = true;
            this.button_originDir.Click += new System.EventHandler(this.button_originDir_Click);
            // 
            // button_destinationDir
            // 
            this.button_destinationDir.Enabled = false;
            this.button_destinationDir.Location = new System.Drawing.Point(333, 71);
            this.button_destinationDir.Name = "button_destinationDir";
            this.button_destinationDir.Size = new System.Drawing.Size(75, 23);
            this.button_destinationDir.TabIndex = 4;
            this.button_destinationDir.Text = "Browse";
            this.button_destinationDir.UseVisualStyleBackColor = true;
            this.button_destinationDir.Click += new System.EventHandler(this.button_destinationDir_Click);
            // 
            // button_continue
            // 
            this.button_continue.Enabled = false;
            this.button_continue.Location = new System.Drawing.Point(175, 173);
            this.button_continue.Name = "button_continue";
            this.button_continue.Size = new System.Drawing.Size(75, 23);
            this.button_continue.TabIndex = 5;
            this.button_continue.Text = "Continue";
            this.button_continue.UseVisualStyleBackColor = true;
            this.button_continue.Click += new System.EventHandler(this.button_continue_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Startup Options";
            // 
            // checkBox_startwithWin
            // 
            this.checkBox_startwithWin.AutoSize = true;
            this.checkBox_startwithWin.Location = new System.Drawing.Point(19, 127);
            this.checkBox_startwithWin.Name = "checkBox_startwithWin";
            this.checkBox_startwithWin.Size = new System.Drawing.Size(260, 17);
            this.checkBox_startwithWin.TabIndex = 7;
            this.checkBox_startwithWin.Text = "Launch Bewander Cropper on Windows Start-Up.";
            this.checkBox_startwithWin.UseVisualStyleBackColor = true;
            this.checkBox_startwithWin.CheckedChanged += new System.EventHandler(this.checkBox_startwithWin_CheckedChanged);
            // 
            // checkBox_startMinimized
            // 
            this.checkBox_startMinimized.AutoSize = true;
            this.checkBox_startMinimized.Location = new System.Drawing.Point(19, 150);
            this.checkBox_startMinimized.Name = "checkBox_startMinimized";
            this.checkBox_startMinimized.Size = new System.Drawing.Size(257, 17);
            this.checkBox_startMinimized.TabIndex = 8;
            this.checkBox_startMinimized.Text = "Start Bewander Cropper minimized to system tray.";
            this.checkBox_startMinimized.UseVisualStyleBackColor = true;
            this.checkBox_startMinimized.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // firstrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 211);
            this.Controls.Add(this.checkBox_startMinimized);
            this.Controls.Add(this.checkBox_startwithWin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_continue);
            this.Controls.Add(this.button_destinationDir);
            this.Controls.Add(this.button_originDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "firstrun";
            this.Text = "Bewander Initial Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_originDir;
        private System.Windows.Forms.Button button_destinationDir;
        private System.Windows.Forms.Button button_continue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_startwithWin;
        private System.Windows.Forms.CheckBox checkBox_startMinimized;
    }
}