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
            btnCancelEMEdit.Location = new Point(49, 380);
            btnCancelEMEdit.Name = "btnCancelEMEdit";
            btnCancelEMEdit.Size = new Size(94, 29);
            btnCancelEMEdit.TabIndex = 0;
            btnCancelEMEdit.Text = "Cancel";
            btnCancelEMEdit.UseVisualStyleBackColor = true;
            btnCancelEMEdit.Click += btnCancelEMEdit_Click;
            // 
            // btnOKEMEdit
            // 
            btnOKEMEdit.Location = new Point(225, 380);
            btnOKEMEdit.Name = "btnOKEMEdit";
            btnOKEMEdit.Size = new Size(94, 29);
            btnOKEMEdit.TabIndex = 1;
            btnOKEMEdit.Text = "OK";
            btnOKEMEdit.UseVisualStyleBackColor = true;
            btnOKEMEdit.Click += btnOKEMEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 45);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 2;
            label1.Text = "Event Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 99);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Event Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 151);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 4;
            label3.Text = "Event Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 200);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 5;
            label4.Text = "Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 247);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 6;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 300);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 7;
            label6.Text = "Capacity";
            // 
            // txtLocEMEdit
            // 
            txtLocEMEdit.Location = new Point(181, 197);
            txtLocEMEdit.Name = "txtLocEMEdit";
            txtLocEMEdit.Size = new Size(125, 27);
            txtLocEMEdit.TabIndex = 10;
            // 
            // txtDesEMEdit
            // 
            txtDesEMEdit.Location = new Point(181, 247);
            txtDesEMEdit.Name = "txtDesEMEdit";
            txtDesEMEdit.Size = new Size(125, 27);
            txtDesEMEdit.TabIndex = 11;
            // 
            // txtCapaEMEdit
            // 
            txtCapaEMEdit.Location = new Point(181, 300);
            txtCapaEMEdit.Name = "txtCapaEMEdit";
            txtCapaEMEdit.Size = new Size(125, 27);
            txtCapaEMEdit.TabIndex = 12;
            // 
            // eventListEMEdit
            // 
            eventListEMEdit.FormattingEnabled = true;
            eventListEMEdit.Location = new Point(168, 42);
            eventListEMEdit.Name = "eventListEMEdit";
            eventListEMEdit.Size = new Size(151, 28);
            eventListEMEdit.TabIndex = 13;
            eventListEMEdit.SelectedIndexChanged += eventListEMEdit_SelectedIndexChanged;
            // 
            // dateTimePickerEMEdit
            // 
            dateTimePickerEMEdit.Location = new Point(155, 94);
            dateTimePickerEMEdit.Name = "dateTimePickerEMEdit";
            dateTimePickerEMEdit.Size = new Size(188, 27);
            dateTimePickerEMEdit.TabIndex = 14;
            // 
            // timePickerEMEdit
            // 
            timePickerEMEdit.Format = DateTimePickerFormat.Time;
            timePickerEMEdit.Location = new Point(169, 144);
            timePickerEMEdit.Name = "timePickerEMEdit";
            timePickerEMEdit.ShowUpDown = true;
            timePickerEMEdit.Size = new Size(150, 27);
            timePickerEMEdit.TabIndex = 16;
            // 
            // FormEventEMEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 460);
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
            Name = "FormEventEMEdit";
            Text = "FormEventEMEdit";
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