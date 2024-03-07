namespace EventManagementSystem
{
    partial class FormEventManipulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventManipulation));
            btnEventAdd = new Button();
            btnEventEdit = new Button();
            btnEventDelete = new Button();
            eventList = new ListBox();
            menuStrip1 = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            editProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            btnEventView = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEventAdd
            // 
            btnEventAdd.BackColor = SystemColors.ControlLight;
            btnEventAdd.Location = new Point(12, 397);
            btnEventAdd.Name = "btnEventAdd";
            btnEventAdd.Size = new Size(108, 36);
            btnEventAdd.TabIndex = 0;
            btnEventAdd.Text = "Add";
            btnEventAdd.UseVisualStyleBackColor = false;
            btnEventAdd.Click += btnEventAdd_Click;
            // 
            // btnEventEdit
            // 
            btnEventEdit.BackColor = SystemColors.ControlLight;
            btnEventEdit.Location = new Point(142, 397);
            btnEventEdit.Name = "btnEventEdit";
            btnEventEdit.Size = new Size(108, 36);
            btnEventEdit.TabIndex = 1;
            btnEventEdit.Text = "Edit";
            btnEventEdit.UseVisualStyleBackColor = false;
            btnEventEdit.Click += btnEventEdit_Click;
            // 
            // btnEventDelete
            // 
            btnEventDelete.BackColor = SystemColors.ControlLight;
            btnEventDelete.Location = new Point(271, 397);
            btnEventDelete.Name = "btnEventDelete";
            btnEventDelete.Size = new Size(108, 36);
            btnEventDelete.TabIndex = 2;
            btnEventDelete.Text = "Delete";
            btnEventDelete.UseVisualStyleBackColor = false;
            btnEventDelete.Click += btnEventDelete_Click;
            // 
            // eventList
            // 
            eventList.BackColor = SystemColors.Control;
            eventList.FormattingEnabled = true;
            eventList.Location = new Point(60, 47);
            eventList.Name = "eventList";
            eventList.Size = new Size(401, 304);
            eventList.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuBar;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem, homeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(522, 28);
            menuStrip1.TabIndex = 5;
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
            editProfileToolStripMenuItem.Size = new Size(165, 26);
            editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(165, 26);
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
            // btnEventView
            // 
            btnEventView.BackColor = SystemColors.ControlLight;
            btnEventView.Location = new Point(402, 397);
            btnEventView.Name = "btnEventView";
            btnEventView.Size = new Size(108, 36);
            btnEventView.TabIndex = 6;
            btnEventView.Text = "View";
            btnEventView.UseVisualStyleBackColor = false;
            btnEventView.Click += btnEventView_Click;
            // 
            // FormEventManipulation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(522, 458);
            Controls.Add(btnEventView);
            Controls.Add(eventList);
            Controls.Add(btnEventDelete);
            Controls.Add(btnEventEdit);
            Controls.Add(btnEventAdd);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormEventManipulation";
            Text = "Event Manipulation";
            Activated += FormEventManipulation_Activated;
            Load += FormEventManipulation_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEventAdd;
        private Button btnEventEdit;
        private Button btnEventDelete;
        private ListBox eventList;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem editProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private Button btnEventView;
    }
}