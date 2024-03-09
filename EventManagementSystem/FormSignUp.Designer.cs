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
            Login.Location = new Point(66, 265);
            Login.Margin = new Padding(2, 2, 2, 2);
            Login.Name = "Login";
            Login.Size = new Size(90, 27);
            Login.TabIndex = 0;
            Login.Text = "LogIn";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Signup
            // 
            Signup.Location = new Point(328, 265);
            Signup.Margin = new Padding(2, 2, 2, 2);
            Signup.Name = "Signup";
            Signup.Size = new Size(90, 27);
            Signup.TabIndex = 1;
            Signup.Text = "Submit";
            Signup.UseVisualStyleBackColor = true;
            Signup.Click += Signup_Click;
            // 
            // txtusername
            // 
            txtusername.AutoSize = true;
            txtusername.Location = new Point(66, 54);
            txtusername.Margin = new Padding(2, 0, 2, 0);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(75, 20);
            txtusername.TabIndex = 2;
            txtusername.Text = "Username";
            // 
            // txtPass
            // 
            txtPass.AutoSize = true;
            txtPass.Location = new Point(66, 121);
            txtPass.Margin = new Padding(2, 0, 2, 0);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(70, 20);
            txtPass.TabIndex = 3;
            txtPass.Text = "Password";
            // 
            // txtCnfPass
            // 
            txtCnfPass.AutoSize = true;
            txtCnfPass.Location = new Point(66, 182);
            txtCnfPass.Margin = new Padding(2, 0, 2, 0);
            txtCnfPass.Name = "txtCnfPass";
            txtCnfPass.Size = new Size(127, 20);
            txtCnfPass.TabIndex = 4;
            txtCnfPass.Text = "Confirm Password";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(247, 54);
            txtuser.Margin = new Padding(2, 2, 2, 2);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(171, 27);
            txtuser.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(247, 118);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(171, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtConfrmPass
            // 
            txtConfrmPass.Location = new Point(247, 182);
            txtConfrmPass.Margin = new Padding(2, 2, 2, 2);
            txtConfrmPass.Name = "txtConfrmPass";
            txtConfrmPass.Size = new Size(171, 27);
            txtConfrmPass.TabIndex = 7;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 349);
            Controls.Add(txtConfrmPass);
            Controls.Add(txtPassword);
            Controls.Add(txtuser);
            Controls.Add(txtCnfPass);
            Controls.Add(txtPass);
            Controls.Add(txtusername);
            Controls.Add(Signup);
            Controls.Add(Login);
            Margin = new Padding(2, 2, 2, 2);
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