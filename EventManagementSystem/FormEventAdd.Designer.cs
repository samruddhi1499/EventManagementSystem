namespace EventManagementSystem
{
    partial class FormEventAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventAdd));
            label1 = new Label();
            txtAddEventName = new TextBox();
            btnAddEventCancel = new Button();
            btnAddEventOk = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtLocAddEvent = new TextBox();
            txtCapaAddEvent = new TextBox();
            txtDesAddEvent = new TextBox();
            dateTimePickerEventAdd = new DateTimePicker();
            emListAddEvent = new ComboBox();
            timePickerEventAdd = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 36);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 0;
            label1.Text = "Event Name";
            // 
            // txtAddEventName
            // 
            txtAddEventName.BackColor = SystemColors.Control;
            txtAddEventName.Location = new Point(174, 36);
            txtAddEventName.Name = "txtAddEventName";
            txtAddEventName.Size = new Size(180, 27);
            txtAddEventName.TabIndex = 1;
            // 
            // btnAddEventCancel
            // 
            btnAddEventCancel.BackColor = SystemColors.ControlLight;
            btnAddEventCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAddEventCancel.Location = new Point(23, 407);
            btnAddEventCancel.Name = "btnAddEventCancel";
            btnAddEventCancel.Size = new Size(108, 36);
            btnAddEventCancel.TabIndex = 2;
            btnAddEventCancel.Text = "Cancel";
            btnAddEventCancel.UseVisualStyleBackColor = false;
            btnAddEventCancel.Click += btnAddEventCancel_Click;
            btnAddEventCancel.MouseLeave += btnAddEventCancel_MouseLeave;
            btnAddEventCancel.MouseHover += btnAddEventCancel_MouseHover;
            // 
            // btnAddEventOk
            // 
            btnAddEventOk.BackColor = SystemColors.ControlLight;
            btnAddEventOk.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAddEventOk.Location = new Point(228, 407);
            btnAddEventOk.Name = "btnAddEventOk";
            btnAddEventOk.Size = new Size(114, 36);
            btnAddEventOk.TabIndex = 3;
            btnAddEventOk.Text = "OK";
            btnAddEventOk.UseVisualStyleBackColor = false;
            btnAddEventOk.Click += btnAddEventOk_Click;
            btnAddEventOk.MouseLeave += btnAddEventOk_MouseLeave;
            btnAddEventOk.MouseHover += btnAddEventOk_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 88);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 4;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 136);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 5;
            label3.Text = "Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 181);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 6;
            label4.Text = "Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 227);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 7;
            label5.Text = "Capacity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 276);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 8;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 321);
            label7.Name = "label7";
            label7.Size = new Size(127, 23);
            label7.TabIndex = 9;
            label7.Text = "Event Manager";
            // 
            // txtLocAddEvent
            // 
            txtLocAddEvent.BackColor = SystemColors.Control;
            txtLocAddEvent.Location = new Point(174, 177);
            txtLocAddEvent.Name = "txtLocAddEvent";
            txtLocAddEvent.Size = new Size(180, 27);
            txtLocAddEvent.TabIndex = 12;
            // 
            // txtCapaAddEvent
            // 
            txtCapaAddEvent.BackColor = SystemColors.Control;
            txtCapaAddEvent.Location = new Point(174, 223);
            txtCapaAddEvent.Name = "txtCapaAddEvent";
            txtCapaAddEvent.Size = new Size(180, 27);
            txtCapaAddEvent.TabIndex = 13;
            // 
            // txtDesAddEvent
            // 
            txtDesAddEvent.BackColor = SystemColors.Control;
            txtDesAddEvent.Location = new Point(174, 272);
            txtDesAddEvent.Name = "txtDesAddEvent";
            txtDesAddEvent.Size = new Size(180, 27);
            txtDesAddEvent.TabIndex = 14;
            // 
            // dateTimePickerEventAdd
            // 
            dateTimePickerEventAdd.CalendarMonthBackground = SystemColors.Control;
            dateTimePickerEventAdd.Location = new Point(174, 84);
            dateTimePickerEventAdd.Name = "dateTimePickerEventAdd";
            dateTimePickerEventAdd.Size = new Size(180, 27);
            dateTimePickerEventAdd.TabIndex = 16;
            // 
            // emListAddEvent
            // 
            emListAddEvent.BackColor = SystemColors.Control;
            emListAddEvent.DropDownStyle = ComboBoxStyle.DropDownList;
            emListAddEvent.FormattingEnabled = true;
            emListAddEvent.Location = new Point(174, 321);
            emListAddEvent.Name = "emListAddEvent";
            emListAddEvent.Size = new Size(180, 28);
            emListAddEvent.TabIndex = 17;
            // 
            // timePickerEventAdd
            // 
            timePickerEventAdd.CalendarMonthBackground = SystemColors.Control;
            timePickerEventAdd.Format = DateTimePickerFormat.Time;
            timePickerEventAdd.Location = new Point(174, 132);
            timePickerEventAdd.Name = "timePickerEventAdd";
            timePickerEventAdd.ShowUpDown = true;
            timePickerEventAdd.Size = new Size(180, 27);
            timePickerEventAdd.TabIndex = 18;
            // 
            // FormEventAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(382, 465);
            Controls.Add(timePickerEventAdd);
            Controls.Add(emListAddEvent);
            Controls.Add(dateTimePickerEventAdd);
            Controls.Add(txtDesAddEvent);
            Controls.Add(txtCapaAddEvent);
            Controls.Add(txtLocAddEvent);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAddEventOk);
            Controls.Add(btnAddEventCancel);
            Controls.Add(txtAddEventName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEventAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Event";
            Load += FormEventAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAddEventName;
        private Button btnAddEventCancel;
        private Button btnAddEventOk;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtLocAddEvent;
        private TextBox txtCapaAddEvent;
        private TextBox txtDesAddEvent;
        private DateTimePicker dateTimePickerEventAdd;
        private ComboBox emListAddEvent;
        private DateTimePicker timePickerEventAdd;
    }
}