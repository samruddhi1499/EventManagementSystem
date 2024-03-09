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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = SystemColors.ControlLight;
            Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.Location = new Point(401, 265);
            Login.Margin = new Padding(2);
            Login.Name = "Login";
            Login.Size = new Size(90, 27);
            Login.TabIndex = 0;
            Login.Text = "LogIn";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            Login.MouseLeave += Login_MouseLeave;
            Login.MouseHover += Login_MouseHover;
            // 
            // Signup
            // 
            Signup.BackColor = SystemColors.ControlLight;
            Signup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signup.Location = new Point(580, 265);
            Signup.Margin = new Padding(2);
            Signup.Name = "Signup";
            Signup.Size = new Size(90, 27);
            Signup.TabIndex = 1;
            Signup.Text = "Submit";
            Signup.UseVisualStyleBackColor = false;
            Signup.Click += Signup_Click;
            Signup.MouseLeave += Signup_MouseLeave;
            Signup.MouseHover += Signup_MouseHover;
            // 
            // txtusername
            // 
            txtusername.AutoSize = true;
            txtusername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(389, 58);
            txtusername.Margin = new Padding(2, 0, 2, 0);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(87, 23);
            txtusername.TabIndex = 2;
            txtusername.Text = "Username";
            // 
            // txtPass
            // 
            txtPass.AutoSize = true;
            txtPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(394, 128);
            txtPass.Margin = new Padding(2, 0, 2, 0);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(80, 23);
            txtPass.TabIndex = 3;
            txtPass.Text = "Password";
            // 
            // txtCnfPass
            // 
            txtCnfPass.AutoSize = true;
            txtCnfPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCnfPass.Location = new Point(364, 201);
            txtCnfPass.Margin = new Padding(2, 0, 2, 0);
            txtCnfPass.Name = "txtCnfPass";
            txtCnfPass.Size = new Size(146, 23);
            txtCnfPass.TabIndex = 4;
            txtCnfPass.Text = "Confirm Password";
            // 
            // txtuser
            // 
            txtuser.BackColor = SystemColors.ControlLight;
            txtuser.Location = new Point(554, 51);
            txtuser.Margin = new Padding(2);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(171, 27);
            txtuser.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLight;
            txtPassword.Location = new Point(554, 121);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(171, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtConfrmPass
            // 
            txtConfrmPass.BackColor = SystemColors.ControlLight;
            txtConfrmPass.Location = new Point(554, 194);
            txtConfrmPass.Margin = new Padding(2);
            txtConfrmPass.Name = "txtConfrmPass";
            txtConfrmPass.Size = new Size(171, 27);
            txtConfrmPass.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Wavy_Gen_03_Single_02__1_;
            pictureBox1.Location = new Point(37, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 256);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(779, 349);
            Controls.Add(pictureBox1);
            Controls.Add(txtConfrmPass);
            Controls.Add(txtPassword);
            Controls.Add(txtuser);
            Controls.Add(txtCnfPass);
            Controls.Add(txtPass);
            Controls.Add(txtusername);
            Controls.Add(Signup);
            Controls.Add(Login);
            Margin = new Padding(2);
            Name = "FormSignUp";
            Text = "FormSignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}