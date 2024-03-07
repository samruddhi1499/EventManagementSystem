namespace EventManagementSystem
{
    partial class FormLogIn
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
            LogIn = new Button();
            SignUp = new Button();
            Username = new Label();
            Password = new Label();
            txtUser = new TextBox();
            txtPass = new MaskedTextBox();
            SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.Location = new Point(85, 282);
            LogIn.Margin = new Padding(2);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(112, 34);
            LogIn.TabIndex = 0;
            LogIn.Text = "LogIn";
            LogIn.UseVisualStyleBackColor = true;
            LogIn.Click += LogIn_Click;
            // 
            // SignUp
            // 
            SignUp.Location = new Point(255, 282);
            SignUp.Margin = new Padding(2);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(112, 34);
            SignUp.TabIndex = 1;
            SignUp.Text = "SignUp";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(85, 72);
            Username.Margin = new Padding(2, 0, 2, 0);
            Username.Name = "Username";
            Username.Size = new Size(91, 25);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(85, 154);
            Password.Margin = new Padding(2, 0, 2, 0);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(255, 72);
            txtUser.Margin = new Padding(2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(150, 31);
            txtUser.TabIndex = 4;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(250, 154);
            txtPass.Margin = new Padding(4, 4, 4, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(155, 31);
            txtPass.TabIndex = 6;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 346);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(SignUp);
            Controls.Add(LogIn);
            Margin = new Padding(2);
            Name = "FormLogIn";
            Text = "FormLogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogIn;
        private Button SignUp;
        private Label Username;
        private Label Password;
        private TextBox txtUser;
        private MaskedTextBox txtPass;
    }
}