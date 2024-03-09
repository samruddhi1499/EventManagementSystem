namespace EventManagementSystem
{
    partial class FormEventEMEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventEMEdit));
            btnCancelEMEdit = new Button();
            btnOKEMEdit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtLocEMEdit = new TextBox();
            txtDesEMEdit = new TextBox();
            txtCapaEMEdit = new TextBox();
            eventListEMEdit = new ComboBox();
            dateTimePickerEMEdit = new DateTimePicker();
            timePickerEMEdit = new DateTimePicker();
            SuspendLayout();
            // 
            // btnCancelEMEdit
            // 
            btnCancelEMEdit.BackColor = SystemColors.ControlLight;
            btnCancelEMEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelEMEdit.Location = new Point(50, 437);
            btnCancelEMEdit.Margin = new Padding(4, 3, 4, 3);
            btnCancelEMEdit.Name = "btnCancelEMEdit";
            btnCancelEMEdit.Size = new Size(135, 41);
            btnCancelEMEdit.TabIndex = 0;
            btnCancelEMEdit.Text = "Cancel";
            btnCancelEMEdit.UseVisualStyleBackColor = false;
            btnCancelEMEdit.Click += btnCancelEMEdit_Click;
            btnCancelEMEdit.MouseLeave += btnCancelEMEdit_MouseLeave;
            btnCancelEMEdit.MouseHover += btnCancelEMEdit_MouseHover;
            // 
            // btnOKEMEdit
            // 
            btnOKEMEdit.BackColor = SystemColors.ControlLight;
            btnOKEMEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOKEMEdit.Location = new Point(269, 437);
            btnOKEMEdit.Margin = new Padding(4, 3, 4, 3);
            btnOKEMEdit.Name = "btnOKEMEdit";
            btnOKEMEdit.Size = new Size(135, 41);
            btnOKEMEdit.TabIndex = 1;
            btnOKEMEdit.Text = "OK";
            btnOKEMEdit.UseVisualStyleBackColor = false;
            btnOKEMEdit.Click += btnOKEMEdit_Click;
            btnOKEMEdit.MouseLeave += btnOKEMEdit_MouseLeave;
            btnOKEMEdit.MouseHover += btnOKEMEdit_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(50, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 2;
            label1.Text = "Event Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(50, 114);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 3;
            label2.Text = "Event Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(50, 174);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 4;
            label3.Text = "Event Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(50, 230);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 5;
            label4.Text = "Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(50, 284);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 23);
            label5.TabIndex = 6;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(50, 345);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 7;
            label6.Text = "Capacity";
            // 
            // txtLocEMEdit
            // 
            txtLocEMEdit.BackColor = SystemColors.ControlLight;
            txtLocEMEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocEMEdit.Location = new Point(201, 227);
            txtLocEMEdit.Margin = new Padding(4, 3, 4, 3);
            txtLocEMEdit.Name = "txtLocEMEdit";
            txtLocEMEdit.Size = new Size(223, 27);
            txtLocEMEdit.TabIndex = 10;
            // 
            // txtDesEMEdit
            // 
            txtDesEMEdit.BackColor = SystemColors.ControlLight;
            txtDesEMEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesEMEdit.Location = new Point(201, 284);
            txtDesEMEdit.Margin = new Padding(4, 3, 4, 3);
            txtDesEMEdit.Name = "txtDesEMEdit";
            txtDesEMEdit.Size = new Size(223, 27);
            txtDesEMEdit.TabIndex = 11;
            // 
            // txtCapaEMEdit
            // 
            txtCapaEMEdit.BackColor = SystemColors.ControlLight;
            txtCapaEMEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCapaEMEdit.Location = new Point(201, 345);
            txtCapaEMEdit.Margin = new Padding(4, 3, 4, 3);
            txtCapaEMEdit.Name = "txtCapaEMEdit";
            txtCapaEMEdit.Size = new Size(223, 27);
            txtCapaEMEdit.TabIndex = 12;
            // 
            // eventListEMEdit
            // 
            eventListEMEdit.BackColor = SystemColors.ControlLight;
            eventListEMEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventListEMEdit.FormattingEnabled = true;
            eventListEMEdit.Location = new Point(201, 43);
            eventListEMEdit.Margin = new Padding(4, 3, 4, 3);
            eventListEMEdit.Name = "eventListEMEdit";
            eventListEMEdit.Size = new Size(223, 28);
            eventListEMEdit.TabIndex = 13;
            eventListEMEdit.SelectedIndexChanged += eventListEMEdit_SelectedIndexChanged;
            // 
            // dateTimePickerEMEdit
            // 
            dateTimePickerEMEdit.CalendarMonthBackground = SystemColors.ControlLight;
            dateTimePickerEMEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerEMEdit.Location = new Point(201, 108);
            dateTimePickerEMEdit.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerEMEdit.Name = "dateTimePickerEMEdit";
            dateTimePickerEMEdit.Size = new Size(223, 27);
            dateTimePickerEMEdit.TabIndex = 14;
            // 
            // timePickerEMEdit
            // 
            timePickerEMEdit.CalendarMonthBackground = SystemColors.ControlLight;
            timePickerEMEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timePickerEMEdit.Format = DateTimePickerFormat.Time;
            timePickerEMEdit.Location = new Point(201, 166);
            timePickerEMEdit.Margin = new Padding(4, 3, 4, 3);
            timePickerEMEdit.Name = "timePickerEMEdit";
            timePickerEMEdit.ShowUpDown = true;
            timePickerEMEdit.Size = new Size(223, 27);
            timePickerEMEdit.TabIndex = 16;
            // 
            // FormEventEMEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(460, 529);
            Controls.Add(timePickerEMEdit);
            Controls.Add(dateTimePickerEMEdit);
            Controls.Add(eventListEMEdit);
            Controls.Add(txtCapaEMEdit);
            Controls.Add(txtDesEMEdit);
            Controls.Add(txtLocEMEdit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOKEMEdit);
            Controls.Add(btnCancelEMEdit);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormEventEMEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EM Event Edit";
            Load += FormEventEMEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelEMEdit;
        private Button btnOKEMEdit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtLocEMEdit;
        private TextBox txtDesEMEdit;
        private TextBox txtCapaEMEdit;
        private ComboBox eventListEMEdit;
        private DateTimePicker dateTimePickerEMEdit;
        private DateTimePicker timePickerEMEdit;
    }
}