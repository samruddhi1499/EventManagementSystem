namespace EventManagementSystem
{
    partial class FormManipulateAttendee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManipulateAttendee));
            label1 = new Label();
            label2 = new Label();
            eventName = new ComboBox();
            attendeeName = new TextBox();
            add = new Button();
            delete = new Button();
            attendeeInfo = new ListBox();
            label3 = new Label();
            username = new ComboBox();
            menuStrip1 = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            viewProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 0;
            label1.Text = "Event Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 1;
            label2.Text = "Attendee Name";
            // 
            // eventName
            // 
            eventName.BackColor = SystemColors.ControlLight;
            eventName.FormattingEnabled = true;
            eventName.Location = new Point(169, 41);
            eventName.Name = "eventName";
            eventName.Size = new Size(184, 28);
            eventName.TabIndex = 2;
            eventName.SelectedIndexChanged += eventName_SelectedIndexChanged;
            // 
            // attendeeName
            // 
            attendeeName.BackColor = SystemColors.ControlLight;
            attendeeName.Location = new Point(169, 103);
            attendeeName.Name = "attendeeName";
            attendeeName.Size = new Size(184, 27);
            attendeeName.TabIndex = 3;
            // 
            // add
            // 
            add.BackColor = SystemColors.ControlLight;
            add.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            add.Location = new Point(35, 261);
            add.Name = "add";
            add.Size = new Size(108, 36);
            add.TabIndex = 4;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            add.MouseLeave += add_MouseLeave;
            add.MouseHover += add_MouseHover;
            // 
            // delete
            // 
            delete.BackColor = SystemColors.ControlLight;
            delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            delete.Location = new Point(234, 261);
            delete.Name = "delete";
            delete.Size = new Size(108, 36);
            delete.TabIndex = 5;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            delete.MouseLeave += delete_MouseLeave;
            delete.MouseHover += delete_MouseHover;
            // 
            // attendeeInfo
            // 
            attendeeInfo.BackColor = Color.Lavender;
            attendeeInfo.FormattingEnabled = true;
            attendeeInfo.Location = new Point(398, 27);
            attendeeInfo.Name = "attendeeInfo";
            attendeeInfo.Size = new Size(257, 324);
            attendeeInfo.TabIndex = 6;
            attendeeInfo.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(12, 171);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // username
            // 
            username.BackColor = SystemColors.ControlLight;
            username.FormattingEnabled = true;
            username.Location = new Point(169, 171);
            username.Name = "username";
            username.Size = new Size(184, 28);
            username.TabIndex = 10;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem, homeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(667, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewProfileToolStripMenuItem, logoutToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(66, 24);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // viewProfileToolStripMenuItem
            // 
            viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            viewProfileToolStripMenuItem.Size = new Size(171, 26);
            viewProfileToolStripMenuItem.Text = "View Profile";
            viewProfileToolStripMenuItem.Click += viewProfileToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(171, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // FormManipulateAttendee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(667, 401);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(attendeeInfo);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(attendeeName);
            Controls.Add(eventName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormManipulateAttendee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendee Manipulation";
            Load += FormManipulateAttendee_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox eventName;
        private TextBox attendeeName;
        private Button add;
        private Button delete;
        private ListBox attendeeInfo;
        private Label label3;
        private ComboBox username;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem viewProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
    }
}