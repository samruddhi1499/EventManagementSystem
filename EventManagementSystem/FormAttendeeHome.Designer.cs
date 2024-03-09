
namespace EventManagementSystem
{
    partial class FormAttendeeHome
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
            listEvents = new ComboBox();
            viewEvent = new Button();
            register = new Button();
            regiterEvents = new ComboBox();
            View = new Button();
            listEventDetails = new ListBox();
            menuStrip1 = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            editProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listEvents
            // 
            listEvents.BackColor = SystemColors.ControlLight;
            listEvents.FormattingEnabled = true;
            listEvents.Location = new Point(223, 103);
            listEvents.Name = "listEvents";
            listEvents.Size = new Size(203, 28);
            listEvents.TabIndex = 1;
            listEvents.SelectedIndexChanged += listEvents_SelectedIndexChanged;
            // 
            // viewEvent
            // 
            viewEvent.BackColor = SystemColors.ControlLight;
            viewEvent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewEvent.Location = new Point(82, 163);
            viewEvent.Name = "viewEvent";
            viewEvent.Size = new Size(94, 29);
            viewEvent.TabIndex = 2;
            viewEvent.Text = "View";
            viewEvent.UseVisualStyleBackColor = false;
            viewEvent.Click += viewEvent_Click;
            viewEvent.MouseLeave += viewEvent_MouseLeave_1;
            viewEvent.MouseHover += viewEvent_MouseHover;
            // 
            // register
            // 
            register.BackColor = SystemColors.ControlLight;
            register.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register.Location = new Point(255, 163);
            register.Name = "register";
            register.Size = new Size(94, 29);
            register.TabIndex = 3;
            register.Text = "Register";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            register.MouseLeave += register_MouseLeave_1;
            register.MouseHover += register_MouseHover_1;
            // 
            // regiterEvents
            // 
            regiterEvents.BackColor = SystemColors.ControlLight;
            regiterEvents.FormattingEnabled = true;
            regiterEvents.Location = new Point(232, 292);
            regiterEvents.Name = "regiterEvents";
            regiterEvents.Size = new Size(194, 28);
            regiterEvents.TabIndex = 5;
            // 
            // View
            // 
            View.BackColor = SystemColors.ControlLight;
            View.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            View.Location = new Point(183, 366);
            View.Name = "View";
            View.Size = new Size(94, 29);
            View.TabIndex = 6;
            View.Text = "View";
            View.UseVisualStyleBackColor = false;
            View.Click += View_Click;
            View.MouseLeave += View_MouseLeave;
            View.MouseHover += View_MouseHover;
            // 
            // listEventDetails
            // 
            listEventDetails.BackColor = Color.FromArgb(192, 192, 255);
            listEventDetails.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listEventDetails.FormattingEnabled = true;
            listEventDetails.ItemHeight = 23;
            listEventDetails.Location = new Point(515, 43);
            listEventDetails.Name = "listEventDetails";
            listEventDetails.Size = new Size(242, 303);
            listEventDetails.TabIndex = 7;
            listEventDetails.SelectedIndexChanged += listEventDetails_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 8;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 103);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 9;
            label1.Text = "Events";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 297);
            label2.Name = "label2";
            label2.Size = new Size(144, 23);
            label2.TabIndex = 10;
            label2.Text = "Registered Events";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 79);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 12;
            // 
            // FormAttendeeHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listEventDetails);
            Controls.Add(View);
            Controls.Add(regiterEvents);
            Controls.Add(register);
            Controls.Add(viewEvent);
            Controls.Add(listEvents);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormAttendeeHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAttendeeHome";
            Activated += FormAttendeeHome_Activated;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void listEventDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private ComboBox listEvents;
        private Button viewEvent;
        private Button register;
        private ComboBox regiterEvents;
        private Button View;
        private ListBox listEventDetails;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem editProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}