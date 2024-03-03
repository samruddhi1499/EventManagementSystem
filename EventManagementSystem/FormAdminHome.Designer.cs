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
            btnUserMan = new Button();
            btnEventMan = new Button();
            btnAttendeeMan = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            editProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUserMan
            // 
            btnUserMan.Location = new Point(54, 98);
            btnUserMan.Name = "btnUserMan";
            btnUserMan.Size = new Size(94, 29);
            btnUserMan.TabIndex = 0;
            btnUserMan.Text = "User";
            btnUserMan.UseVisualStyleBackColor = true;
            btnUserMan.Click += btnUserMan_Click;
            // 
            // btnEventMan
            // 
            btnEventMan.Location = new Point(236, 101);
            btnEventMan.Name = "btnEventMan";
            btnEventMan.Size = new Size(94, 29);
            btnEventMan.TabIndex = 1;
            btnEventMan.Text = "Event";
            btnEventMan.UseVisualStyleBackColor = true;
            btnEventMan.Click += btnEventMan_Click;
            // 
            // btnAttendeeMan
            // 
            btnAttendeeMan.Location = new Point(439, 107);
            btnAttendeeMan.Name = "btnAttendeeMan";
            btnAttendeeMan.Size = new Size(94, 29);
            btnAttendeeMan.TabIndex = 2;
            btnAttendeeMan.Text = "Attendee";
            btnAttendeeMan.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(652, 28);
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
            editProfileToolStripMenuItem.Size = new Size(224, 26);
            editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // FormAdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 215);
            Controls.Add(btnAttendeeMan);
            Controls.Add(btnEventMan);
            Controls.Add(btnUserMan);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormAdminHome";
            Text = "FormAdminHome";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}