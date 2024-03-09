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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.BackColor = SystemColors.ControlLight;
            LogIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogIn.Location = new Point(311, 226);
            LogIn.Margin = new Padding(2);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(90, 27);
            LogIn.TabIndex = 0;
            LogIn.Text = "LogIn";
            LogIn.UseVisualStyleBackColor = false;
            LogIn.Click += LogIn_Click;
            LogIn.MouseLeave += LogIn_MouseLeave;
            LogIn.MouseHover += LogIn_MouseHover;
            // 
            // SignUp
            // 
            SignUp.BackColor = SystemColors.ControlLight;
            SignUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUp.Location = new Point(445, 226);
            SignUp.Margin = new Padding(2);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(90, 27);
            SignUp.TabIndex = 1;
            SignUp.Text = "SignUp";
            SignUp.UseVisualStyleBackColor = false;
            SignUp.Click += SignUp_Click;
            SignUp.MouseLeave += SignUp_MouseLeave;
            SignUp.MouseHover += SignUp_MouseHover;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(288, 62);
            Username.Margin = new Padding(2, 0, 2, 0);
            Username.Name = "Username";
            Username.Size = new Size(87, 23);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(295, 133);
            Password.Margin = new Padding(2, 0, 2, 0);
            Password.Name = "Password";
            Password.Size = new Size(80, 23);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.ControlLight;
            txtUser.Location = new Point(404, 58);
            txtUser.Margin = new Padding(2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(153, 27);
            txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.ControlLight;
            txtPass.Location = new Point(400, 132);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(157, 27);
            txtPass.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Tablet_login_amico__1_;
            pictureBox1.Location = new Point(26, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 210);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(600, 298);
            Controls.Add(pictureBox1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(SignUp);
            Controls.Add(LogIn);
            Margin = new Padding(2);
            Name = "FormLogIn";
            Text = "FormLogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}