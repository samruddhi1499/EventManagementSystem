namespace EventManagementSystem
{
    partial class FormAdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminHome));
            btnUserMan = new Button();
            btnEventMan = new Button();
            btnAttendeeMan = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            editProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUserMan
            // 
            btnUserMan.BackColor = SystemColors.ControlLight;
            btnUserMan.Location = new Point(289, 249);
            btnUserMan.Name = "btnUserMan";
            btnUserMan.Size = new Size(108, 36);
            btnUserMan.TabIndex = 0;
            btnUserMan.Text = "User";
            btnUserMan.UseVisualStyleBackColor = false;
            btnUserMan.Click += btnUserMan_Click;
            // 
            // btnEventMan
            // 
            btnEventMan.BackColor = Color.Gainsboro;
            btnEventMan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEventMan.ForeColor = Color.Black;
            btnEventMan.Location = new Point(12, 249);
            btnEventMan.Name = "btnEventMan";
            btnEventMan.Size = new Size(108, 36);
            btnEventMan.TabIndex = 1;
            btnEventMan.Text = "Event";
            btnEventMan.UseVisualStyleBackColor = false;
            btnEventMan.Click += btnEventMan_Click;
            btnEventMan.MouseLeave += btnEventMan_MouseLeave;
            btnEventMan.MouseHover += btnEventMan_MouseHover;
            // 
            // btnAttendeeMan
            // 
            btnAttendeeMan.BackColor = SystemColors.ControlLight;
            btnAttendeeMan.Location = new Point(144, 249);
            btnAttendeeMan.Name = "btnAttendeeMan";
            btnAttendeeMan.Size = new Size(108, 36);
            btnAttendeeMan.TabIndex = 2;
            btnAttendeeMan.Text = "Attendee";
            btnAttendeeMan.UseVisualStyleBackColor = false;
            btnAttendeeMan.Click += btnAttendeeMan_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuBar;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(409, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { editProfileToolStripMenuItem, logoutToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(66, 24);
            toolStripMenuItem1.Text = "Profile";
            // 
            // editProfileToolStripMenuItem
            // 
            editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            editProfileToolStripMenuItem.Size = new Size(171, 26);
            editProfileToolStripMenuItem.Text = "View Profile";
            editProfileToolStripMenuItem.Click += editProfileToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(171, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 170);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormAdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(409, 320);
            Controls.Add(pictureBox1);
            Controls.Add(btnAttendeeMan);
            Controls.Add(btnEventMan);
            Controls.Add(btnUserMan);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormAdminHome";
            Text = "Admin Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUserMan;
        private Button btnEventMan;
        private Button btnAttendeeMan;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem editProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}