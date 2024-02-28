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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            eventManagerListEdit = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnEditCancel
            // 
            btnEditCancel.Location = new Point(26, 429);
            btnEditCancel.Name = "btnEditCancel";
            btnEditCancel.Size = new Size(94, 29);
            btnEditCancel.TabIndex = 0;
            btnEditCancel.Text = "Cancel";
            btnEditCancel.UseVisualStyleBackColor = true;
            btnEditCancel.Click += btnEditCancel_Click;
            // 
            // btnEditOK
            // 
            btnEditOK.Location = new Point(192, 429);
            btnEditOK.Name = "btnEditOK";
            btnEditOK.Size = new Size(94, 29);
            btnEditOK.TabIndex = 1;
            btnEditOK.Text = "OK";
            btnEditOK.UseVisualStyleBackColor = true;
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
            eventListEdit.FormattingEnabled = true;
            eventListEdit.Location = new Point(135, 36);
            eventListEdit.Name = "eventListEdit";
            eventListEdit.Size = new Size(151, 28);
            eventListEdit.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(143, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(143, 317);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 14;
            // 
            // eventManagerListEdit
            // 
            eventManagerListEdit.FormattingEnabled = true;
            eventManagerListEdit.Location = new Point(135, 366);
            eventManagerListEdit.Name = "eventManagerListEdit";
            eventManagerListEdit.Size = new Size(151, 28);
            eventManagerListEdit.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(371, 378);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 16;
            label8.Text = "label8";
            // 
            // FormEventEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 519);
            Controls.Add(label8);
            Controls.Add(eventManagerListEdit);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            Name = "FormEventEdit";
            Text = "FormEventEdit";
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox eventManagerListEdit;
        private Label label8;
    }
}