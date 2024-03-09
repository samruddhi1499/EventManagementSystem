namespace EventManagementSystem
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            login = new Button();
            signup = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login
            // 
            login.BackColor = Color.Gainsboro;
            login.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            login.ForeColor = SystemColors.ActiveCaptionText;
            login.Location = new Point(72, 283);
            login.Margin = new Padding(4);
            login.Name = "login";
            login.Size = new Size(108, 36);
            login.TabIndex = 1;
            login.Text = "LogIn";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            login.MouseLeave += login_MouseLeave;
            login.MouseHover += login_MouseHover;
            // 
            // signup
            // 
            signup.BackColor = Color.Gainsboro;
            signup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            signup.Location = new Point(332, 283);
            signup.Margin = new Padding(4);
            signup.Name = "signup";
            signup.Size = new Size(108, 36);
            signup.TabIndex = 2;
            signup.Text = "SignUp";
            signup.UseVisualStyleBackColor = false;
            signup.Click += signup_Click;
            signup.MouseLeave += signup_MouseLeave;
            signup.MouseHover += signup_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(148, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 206);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(518, 381);
            Controls.Add(pictureBox1);
            Controls.Add(signup);
            Controls.Add(login);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event Management";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button login;
        private Button signup;
        private PictureBox pictureBox1;
    }
}