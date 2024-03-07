namespace EventManagementSystem
{
    partial class FormEventEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventEdit));
            btnEditCancel = new Button();
            btnEditOK = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            eventListEdit = new ComboBox();
            txtLocEdit = new TextBox();
            txtCapaEdit = new TextBox();
            txtDesEdit = new TextBox();
            eventManagerListEdit = new ComboBox();
            dateTimePickerEdit = new DateTimePicker();
            timePickerEventEdit = new DateTimePicker();
            SuspendLayout();
            // 
            // btnEditCancel
            // 
            btnEditCancel.BackColor = SystemColors.ControlLight;
            btnEditCancel.Location = new Point(26, 429);
            btnEditCancel.Name = "btnEditCancel";
            btnEditCancel.Size = new Size(108, 36);
            btnEditCancel.TabIndex = 0;
            btnEditCancel.Text = "Cancel";
            btnEditCancel.UseVisualStyleBackColor = false;
            btnEditCancel.Click += btnEditCancel_Click;
            // 
            // btnEditOK
            // 
            btnEditOK.BackColor = SystemColors.ControlLight;
            btnEditOK.Location = new Point(215, 429);
            btnEditOK.Name = "btnEditOK";
            btnEditOK.Size = new Size(108, 36);
            btnEditOK.TabIndex = 1;
            btnEditOK.Text = "OK";
            btnEditOK.UseVisualStyleBackColor = false;
            btnEditOK.Click += btnEditOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 44);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 2;
            label1.Text = "Event Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 95);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 152);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 4;
            label3.Text = "Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 212);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 5;
            label4.Text = "Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 268);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 6;
            label5.Text = "Capacity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 320);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 7;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 374);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 8;
            label7.Text = "Event Manager";
            // 
            // eventListEdit
            // 
            eventListEdit.BackColor = SystemColors.ControlLight;
            eventListEdit.FormattingEnabled = true;
            eventListEdit.Location = new Point(143, 36);
            eventListEdit.Name = "eventListEdit";
            eventListEdit.Size = new Size(179, 28);
            eventListEdit.TabIndex = 9;
            eventListEdit.SelectedIndexChanged += eventListEdit_SelectedIndexChanged;
            // 
            // txtLocEdit
            // 
            txtLocEdit.BackColor = SystemColors.ControlLight;
            txtLocEdit.Location = new Point(143, 205);
            txtLocEdit.Name = "txtLocEdit";
            txtLocEdit.Size = new Size(179, 27);
            txtLocEdit.TabIndex = 12;
            // 
            // txtCapaEdit
            // 
            txtCapaEdit.BackColor = SystemColors.ControlLight;
            txtCapaEdit.Location = new Point(143, 261);
            txtCapaEdit.Name = "txtCapaEdit";
            txtCapaEdit.Size = new Size(179, 27);
            txtCapaEdit.TabIndex = 13;
            // 
            // txtDesEdit
            // 
            txtDesEdit.BackColor = SystemColors.ControlLight;
            txtDesEdit.Location = new Point(143, 317);
            txtDesEdit.Name = "txtDesEdit";
            txtDesEdit.Size = new Size(179, 27);
            txtDesEdit.TabIndex = 14;
            // 
            // eventManagerListEdit
            // 
            eventManagerListEdit.BackColor = SystemColors.ControlLight;
            eventManagerListEdit.DisplayMember = "(none)";
            eventManagerListEdit.FormattingEnabled = true;
            eventManagerListEdit.Items.AddRange(new object[] { "Saloni", "Sam", "Sruthi" });
            eventManagerListEdit.Location = new Point(143, 366);
            eventManagerListEdit.Name = "eventManagerListEdit";
            eventManagerListEdit.Size = new Size(179, 28);
            eventManagerListEdit.TabIndex = 15;
            eventManagerListEdit.Tag = "";
            eventManagerListEdit.Text = "Sam";
            // 
            // dateTimePickerEdit
            // 
            dateTimePickerEdit.CalendarMonthBackground = SystemColors.ControlLight;
            dateTimePickerEdit.Location = new Point(143, 90);
            dateTimePickerEdit.Name = "dateTimePickerEdit";
            dateTimePickerEdit.Size = new Size(179, 27);
            dateTimePickerEdit.TabIndex = 16;
            // 
            // timePickerEventEdit
            // 
            timePickerEventEdit.CalendarMonthBackground = SystemColors.ControlLight;
            timePickerEventEdit.Format = DateTimePickerFormat.Time;
            timePickerEventEdit.Location = new Point(143, 147);
            timePickerEventEdit.Name = "timePickerEventEdit";
            timePickerEventEdit.ShowUpDown = true;
            timePickerEventEdit.Size = new Size(179, 27);
            timePickerEventEdit.TabIndex = 17;
            // 
            // FormEventEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(349, 491);
            Controls.Add(timePickerEventEdit);
            Controls.Add(dateTimePickerEdit);
            Controls.Add(eventManagerListEdit);
            Controls.Add(txtDesEdit);
            Controls.Add(txtCapaEdit);
            Controls.Add(txtLocEdit);
            Controls.Add(eventListEdit);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEditOK);
            Controls.Add(btnEditCancel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEventEdit";
            Text = "Edit Event";
            Activated += FormEventEdit_Activated;
            Load += FormEventEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditCancel;
        private Button btnEditOK;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox eventListEdit;
        private TextBox txtLocEdit;
        private TextBox txtCapaEdit;
        private TextBox txtDesEdit;
        private ComboBox eventManagerListEdit;
        private DateTimePicker dateTimePickerEdit;
        private DateTimePicker timePickerEventEdit;
    }
}