namespace EventManagementSystem
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            name = new Label();
            phone = new Label();
            email = new Label();
            studentno = new Label();
            nameVal = new TextBox();
            phoneval = new TextBox();
            emailval = new TextBox();
            student = new TextBox();
            register = new Button();
            Close = new Button();
            eventName = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            name.Location = new Point(420, 135);
            name.Name = "name";
            name.Size = new Size(56, 23);
            name.TabIndex = 0;
            name.Text = "Name";
            name.Click += label1_Click;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            phone.Location = new Point(419, 195);
            phone.Name = "phone";
            phone.Size = new Size(59, 23);
            phone.TabIndex = 1;
            phone.Text = "Phone";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            email.Location = new Point(419, 257);
            email.Name = "email";
            email.Size = new Size(68, 23);
            email.TabIndex = 2;
            email.Text = "EmailID";
            // 
            // studentno
            // 
            studentno.AutoSize = true;
            studentno.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            studentno.Location = new Point(406, 329);
            studentno.Name = "studentno";
            studentno.RightToLeft = RightToLeft.No;
            studentno.Size = new Size(98, 23);
            studentno.TabIndex = 3;
            studentno.Text = "Student No";
            // 
            // nameVal
            // 
            nameVal.BackColor = SystemColors.ControlLight;
            nameVal.Location = new Point(557, 135);
            nameVal.Name = "nameVal";
            nameVal.Size = new Size(168, 27);
            nameVal.TabIndex = 6;
            // 
            // phoneval
            // 
            phoneval.BackColor = SystemColors.ControlLight;
            phoneval.Location = new Point(557, 192);
            phoneval.Name = "phoneval";
            phoneval.Size = new Size(168, 27);
            phoneval.TabIndex = 7;
            // 
            // emailval
            // 
            emailval.BackColor = SystemColors.ControlLight;
            emailval.Location = new Point(557, 254);
            emailval.Name = "emailval";
            emailval.Size = new Size(168, 27);
            emailval.TabIndex = 8;
            // 
            // student
            // 
            student.BackColor = SystemColors.ControlLight;
            student.Location = new Point(557, 322);
            student.Name = "student";
            student.Size = new Size(168, 27);
            student.TabIndex = 9;
            // 
            // register
            // 
            register.BackColor = SystemColors.ControlLight;
            register.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            register.Location = new Point(588, 387);
            register.Name = "register";
            register.Size = new Size(108, 36);
            register.TabIndex = 10;
            register.Text = "Register";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            register.MouseLeave += register_MouseLeave;
            register.MouseHover += register_MouseHover;
            // 
            // Close
            // 
            Close.BackColor = SystemColors.ControlLight;
            Close.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Close.Location = new Point(406, 387);
            Close.Name = "Close";
            Close.Size = new Size(108, 36);
            Close.TabIndex = 11;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = false;
            Close.Click += button1_Click;
            Close.MouseLeave += Close_MouseLeave;
            Close.MouseHover += Close_MouseHover;
            // 
            // eventName
            // 
            eventName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventName.ForeColor = Color.MediumSlateBlue;
            eventName.Location = new Point(437, 43);
            eventName.Name = "eventName";
            eventName.ReadOnly = true;
            eventName.Size = new Size(354, 31);
            eventName.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 246);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(803, 450);
            Controls.Add(pictureBox1);
            Controls.Add(eventName);
            Controls.Add(Close);
            Controls.Add(register);
            Controls.Add(student);
            Controls.Add(emailval);
            Controls.Add(phoneval);
            Controls.Add(nameVal);
            Controls.Add(studentno);
            Controls.Add(email);
            Controls.Add(phone);
            Controls.Add(name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atendee Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label phone;
        private Label email;
        private Label studentno;
        private TextBox nameVal;
        private TextBox phoneval;
        private TextBox emailval;
        private TextBox student;
        private Button register;
        private Button Close;
        private TextBox eventName;
        private PictureBox pictureBox1;
    }
}