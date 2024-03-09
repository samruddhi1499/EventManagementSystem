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
            label1 = new Label();
            label2 = new Label();
            eventName = new ComboBox();
            attendeeName = new TextBox();
            add = new Button();
            delete = new Button();
            attendeeInfo = new ListBox();
            menuStrip1 = new MenuStrip();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 0;
            label1.Text = "Event Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 132);
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
            attendeeName.Location = new Point(169, 128);
            attendeeName.Name = "attendeeName";
            attendeeName.Size = new Size(184, 27);
            attendeeName.TabIndex = 3;
            // 
            // add
            // 
            add.BackColor = SystemColors.ControlLight;
            add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(12, 235);
            add.Name = "add";
            add.Size = new Size(94, 29);
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
            delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete.Location = new Point(132, 235);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 5;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            delete.MouseLeave += delete_MouseLeave;
            delete.MouseHover += delete_MouseHover;
            // 
            // attendeeInfo
            // 
            attendeeInfo.BackColor = Color.FromArgb(192, 192, 255);
            attendeeInfo.FormattingEnabled = true;
            attendeeInfo.Location = new Point(398, 27);
            attendeeInfo.Name = "attendeeInfo";
            attendeeInfo.Size = new Size(257, 324);
            attendeeInfo.TabIndex = 6;
            attendeeInfo.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(667, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(273, 235);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // FormManipulateAttendee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(667, 401);
            Controls.Add(button1);
            Controls.Add(attendeeInfo);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(attendeeName);
            Controls.Add(eventName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormManipulateAttendee";
            Text = "FormManipulateAttendee";
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
        private MenuStrip menuStrip1;
        private Button button1;
    }
}