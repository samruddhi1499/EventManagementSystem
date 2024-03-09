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
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(78, 164);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 0;
            name.Text = "Name";
            name.Click += label1_Click;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(78, 215);
            phone.Name = "phone";
            phone.Size = new Size(50, 20);
            phone.TabIndex = 1;
            phone.Text = "Phone";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(78, 260);
            email.Name = "email";
            email.Size = new Size(61, 20);
            email.TabIndex = 2;
            email.Text = "EmailID";
            // 
            // studentno
            // 
            studentno.AutoSize = true;
            studentno.Location = new Point(78, 311);
            studentno.Name = "studentno";
            studentno.RightToLeft = RightToLeft.No;
            studentno.Size = new Size(84, 20);
            studentno.TabIndex = 3;
            studentno.Text = "Student No";
            // 
            // nameVal
            // 
            nameVal.Location = new Point(295, 161);
            nameVal.Name = "nameVal";
            nameVal.Size = new Size(125, 27);
            nameVal.TabIndex = 6;
            // 
            // phoneval
            // 
            phoneval.Location = new Point(295, 212);
            phoneval.Name = "phoneval";
            phoneval.Size = new Size(125, 27);
            phoneval.TabIndex = 7;
            // 
            // emailval
            // 
            emailval.Location = new Point(295, 260);
            emailval.Name = "emailval";
            emailval.Size = new Size(125, 27);
            emailval.TabIndex = 8;
            // 
            // student
            // 
            student.Location = new Point(295, 308);
            student.Name = "student";
            student.Size = new Size(125, 27);
            student.TabIndex = 9;
            // 
            // register
            // 
            register.Location = new Point(138, 387);
            register.Name = "register";
            register.Size = new Size(94, 29);
            register.TabIndex = 10;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // Close
            // 
            Close.Location = new Point(343, 387);
            Close.Name = "Close";
            Close.Size = new Size(94, 29);
            Close.TabIndex = 11;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += button1_Click;
            // 
            // eventName
            // 
            eventName.Location = new Point(312, 40);
            eventName.Name = "eventName";
            eventName.ReadOnly = true;
            eventName.Size = new Size(125, 27);
            eventName.TabIndex = 12;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FormRegister";
            Text = "FormRegister";
            Activated += FormRegister_Activated;
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
    }
}