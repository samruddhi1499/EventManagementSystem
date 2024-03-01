namespace EventManagementSystem
{
    partial class FormSignUp
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
            Login = new Button();
            Signup = new Button();
            txtusername = new Label();
            txtPass = new Label();
            txtCnfPass = new Label();
            txtuser = new TextBox();
            txtPassword = new TextBox();
            txtConfrmPass = new TextBox();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Location = new Point(83, 331);
            Login.Name = "Login";
            Login.Size = new Size(112, 34);
            Login.TabIndex = 0;
            Login.Text = "LogIn";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Signup
            // 
            Signup.Location = new Point(410, 331);
            Signup.Name = "Signup";
            Signup.Size = new Size(112, 34);
            Signup.TabIndex = 1;
            Signup.Text = "Submit";
            Signup.UseVisualStyleBackColor = true;
            Signup.Click += Signup_Click;
            // 
            // txtusername
            // 
            txtusername.AutoSize = true;
            txtusername.Location = new Point(83, 68);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(91, 25);
            txtusername.TabIndex = 2;
            txtusername.Text = "Username";
            // 
            // txtPass
            // 
            txtPass.AutoSize = true;
            txtPass.Location = new Point(83, 151);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(87, 25);
            txtPass.TabIndex = 3;
            txtPass.Text = "Password";
            // 
            // txtCnfPass
            // 
            txtCnfPass.AutoSize = true;
            txtCnfPass.Location = new Point(83, 228);
            txtCnfPass.Name = "txtCnfPass";
            txtCnfPass.Size = new Size(156, 25);
            txtCnfPass.TabIndex = 4;
            txtCnfPass.Text = "Confirm Password";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(309, 68);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(213, 31);
            txtuser.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(309, 148);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(213, 31);
            txtPassword.TabIndex = 6;
            // 
            // txtConfrmPass
            // 
            txtConfrmPass.Location = new Point(309, 228);
            txtConfrmPass.Name = "txtConfrmPass";
            txtConfrmPass.Size = new Size(213, 31);
            txtConfrmPass.TabIndex = 7;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtConfrmPass);
            Controls.Add(txtPassword);
            Controls.Add(txtuser);
            Controls.Add(txtCnfPass);
            Controls.Add(txtPass);
            Controls.Add(txtusername);
            Controls.Add(Signup);
            Controls.Add(Login);
            Name = "FormSignUp";
            Text = "FormSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private Button Signup;
        private Label txtusername;
        private Label txtPass;
        private Label txtCnfPass;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtuser;
        private TextBox txtPassword;
        private TextBox txtConfrmPass;
    }
}