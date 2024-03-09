namespace EventManagementSystem
{
    partial class editRole
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
            roleDropDown = new Label();
            btnCancel = new Button();
            btnOK = new Button();
            selectRole = new ComboBox();
            name = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 68);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // roleDropDown
            // 
            roleDropDown.AutoSize = true;
            roleDropDown.Location = new Point(129, 171);
            roleDropDown.Name = "roleDropDown";
            roleDropDown.Size = new Size(46, 25);
            roleDropDown.TabIndex = 1;
            roleDropDown.Text = "Role";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(129, 267);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(402, 267);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // selectRole
            // 
            selectRole.FormattingEnabled = true;
            selectRole.Items.AddRange(new object[] { "Admin", "Event Manager", "Attendee" });
            selectRole.Location = new Point(332, 163);
            selectRole.Name = "selectRole";
            selectRole.Size = new Size(182, 33);
            selectRole.TabIndex = 4;
            selectRole.SelectedIndexChanged += selectRole_SelectedIndexChanged_1;
            // 
            // name
            // 
            name.Location = new Point(332, 68);
            name.Name = "name";
            name.Size = new Size(182, 31);
            name.TabIndex = 5;
            // 
            // editRole
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 367);
            Controls.Add(name);
            Controls.Add(selectRole);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(roleDropDown);
            Controls.Add(label1);
            Name = "editRole";
            Text = "editRole";
            Load += editRole_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label roleDropDown;
        private Button btnCancel;
        private Button btnOK;
        private ComboBox selectRole;
        private TextBox name;
    }
}