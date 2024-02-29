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
            label1.Location = new Point(23, 36);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Event Name";
            // 
            // txtAddEventName
            // 
            txtAddEventName.Location = new Point(153, 36);
            txtAddEventName.Name = "txtAddEventName";
            txtAddEventName.Size = new Size(125, 27);
            txtAddEventName.TabIndex = 1;
            // 
            // btnAddEventCancel
            // 
            btnAddEventCancel.Location = new Point(37, 394);
            btnAddEventCancel.Name = "btnAddEventCancel";
            btnAddEventCancel.Size = new Size(94, 29);
            btnAddEventCancel.TabIndex = 2;
            btnAddEventCancel.Text = "Cancel";
            btnAddEventCancel.UseVisualStyleBackColor = true;
            btnAddEventCancel.Click += btnAddEventCancel_Click;
            // 
            // btnAddEventOk
            // 
            btnAddEventOk.Location = new Point(226, 394);
            btnAddEventOk.Name = "btnAddEventOk";
            btnAddEventOk.Size = new Size(94, 29);
            btnAddEventOk.TabIndex = 3;
            btnAddEventOk.Text = "OK";
            btnAddEventOk.UseVisualStyleBackColor = true;
            btnAddEventOk.Click += btnAddEventOk_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 88);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 4;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 136);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 5;
            label3.Text = "Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 181);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 6;
            label4.Text = "Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 227);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 7;
            label5.Text = "Capacity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 276);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 8;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 321);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 9;
            label7.Text = "Event Manager";
            // 
            // txtLocAddEvent
            // 
            txtLocAddEvent.Location = new Point(153, 174);
            txtLocAddEvent.Name = "txtLocAddEvent";
            txtLocAddEvent.Size = new Size(125, 27);
            txtLocAddEvent.TabIndex = 12;
            // 
            // txtCapaAddEvent
            // 
            txtCapaAddEvent.Location = new Point(153, 220);
            txtCapaAddEvent.Name = "txtCapaAddEvent";
            txtCapaAddEvent.Size = new Size(125, 27);
            txtCapaAddEvent.TabIndex = 13;
            // 
            // txtDesAddEvent
            // 
            txtDesAddEvent.Location = new Point(153, 269);
            txtDesAddEvent.Name = "txtDesAddEvent";
            txtDesAddEvent.Size = new Size(125, 27);
            txtDesAddEvent.TabIndex = 14;
            // 
            // dateTimePickerEventAdd
            // 
            dateTimePickerEventAdd.Location = new Point(153, 83);
            dateTimePickerEventAdd.Name = "dateTimePickerEventAdd";
            dateTimePickerEventAdd.Size = new Size(200, 27);
            dateTimePickerEventAdd.TabIndex = 16;
            // 
            // emListAddEvent
            // 
            emListAddEvent.FormattingEnabled = true;
            emListAddEvent.Items.AddRange(new object[] { "Sam", "Saloni", "Sruthi" });
            emListAddEvent.Location = new Point(153, 318);
            emListAddEvent.Name = "emListAddEvent";
            emListAddEvent.Size = new Size(151, 28);
            emListAddEvent.TabIndex = 17;
            // 
            // timePickerEventAdd
            // 
            timePickerEventAdd.Format = DateTimePickerFormat.Time;
            timePickerEventAdd.Location = new Point(153, 131);
            timePickerEventAdd.Name = "timePickerEventAdd";
            timePickerEventAdd.ShowUpDown = true;
            timePickerEventAdd.Size = new Size(180, 27);
            timePickerEventAdd.TabIndex = 18;
            // 
            // FormEventAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 465);
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
            Name = "FormEventAdd";
            Text = "FormEventAdd";
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