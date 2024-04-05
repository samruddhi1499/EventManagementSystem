namespace EventManagementSystem
{
    partial class EMAfterLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMAfterLogin));
            btnEMEditEvent = new Button();
            btnAttendee = new Button();
            menuStrip1 = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            editProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            registerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEMEditEvent
            // 
            btnEMEditEvent.BackColor = SystemColors.ControlLight;
            btnEMEditEvent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEMEditEvent.Location = new Point(387, 72);
            btnEMEditEvent.Name = "btnEMEditEvent";
            btnEMEditEvent.Size = new Size(157, 36);
            btnEMEditEvent.TabIndex = 0;
            btnEMEditEvent.Text = "Edit Event";
            btnEMEditEvent.UseVisualStyleBackColor = false;
            btnEMEditEvent.Click += btnEMEditEvent_Click;
            btnEMEditEvent.MouseLeave += btnEMEditEvent_MouseLeave;
            btnEMEditEvent.MouseHover += btnEMEditEvent_MouseHover;
            // 
            // btnAttendee
            // 
            btnAttendee.BackColor = SystemColors.ControlLight;
            btnAttendee.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAttendee.Location = new Point(387, 156);
            btnAttendee.Name = "btnAttendee";
            btnAttendee.Size = new Size(157, 36);
            btnAttendee.TabIndex = 1;
            btnAttendee.Text = "Edit Attendee";
            btnAttendee.UseVisualStyleBackColor = false;
            btnAttendee.Click += btnAttendee_Click;
            btnAttendee.MouseLeave += btnAttendee_MouseLeave;
            btnAttendee.MouseHover += btnAttendee_MouseHover;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuBar;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem, registerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(591, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editProfileToolStripMenuItem, logoutToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(66, 24);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // editProfileToolStripMenuItem
            // 
            editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            editProfileToolStripMenuItem.Size = new Size(224, 26);
            editProfileToolStripMenuItem.Text = "View Profile";
            editProfileToolStripMenuItem.Click += editProfileToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 162);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(77, 24);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // EMAfterLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(591, 259);
            Controls.Add(pictureBox1);
            Controls.Add(btnAttendee);
            Controls.Add(btnEMEditEvent);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "EMAfterLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EM Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEMEditEvent;
        private Button btnAttendee;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem editProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem registerToolStripMenuItem;
    }
}