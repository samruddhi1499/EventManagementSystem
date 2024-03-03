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
            label1 = new Label();
            login = new Button();
            signup = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(125, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 28);
            label1.TabIndex = 0;
            label1.Text = "Event Management System";
            // 
            // login
            // 
            login.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.ForeColor = SystemColors.ActiveCaptionText;
            login.Location = new Point(23, 143);
            login.Margin = new Padding(4);
            login.Name = "login";
            login.Size = new Size(157, 44);
            login.TabIndex = 1;
            login.Text = "LogIn";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // signup
            // 
            signup.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup.Location = new Point(334, 143);
            signup.Margin = new Padding(4);
            signup.Name = "signup";
            signup.Size = new Size(157, 44);
            signup.TabIndex = 2;
            signup.Text = "SignUp";
            signup.UseVisualStyleBackColor = true;
            signup.Click += signup_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 231);
            Controls.Add(signup);
            Controls.Add(login);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button login;
        private Button signup;
    }
}