namespace EventManagementSystem
{
    partial class FormSelectRole
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            name = new TextBox();
            addList = new ListBox();
            selectRole = new ComboBox();
            menuStrip1 = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            editProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            btnClear = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // roleDropDown
            // 
            roleDropDown.AutoSize = true;
            roleDropDown.Location = new Point(40, 106);
            roleDropDown.Margin = new Padding(2, 0, 2, 0);
            roleDropDown.Name = "roleDropDown";
            roleDropDown.Size = new Size(39, 20);
            roleDropDown.TabIndex = 1;
            roleDropDown.Text = "Role";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(19, 194);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 27);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(19, 194);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 27);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(297, 194);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 27);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // name
            // 
            name.Location = new Point(178, 38);
            name.Margin = new Padding(2);
            name.Name = "name";
            name.Size = new Size(146, 27);
            name.TabIndex = 5;
            // 
            // addList
            // 
            addList.FormattingEnabled = true;
            addList.Location = new Point(467, 18);
            addList.Margin = new Padding(2);
            addList.Name = "addList";
            addList.Size = new Size(145, 204);
            addList.TabIndex = 7;
            addList.DoubleClick += addList_DoubleClick;
            // 
            // selectRole
            // 
            selectRole.DropDownStyle = ComboBoxStyle.DropDownList;
            selectRole.FormattingEnabled = true;
            selectRole.Items.AddRange(new object[] { "Admin", "Event Manager", "Attendee" });
            selectRole.Location = new Point(178, 99);
            selectRole.Margin = new Padding(2);
            selectRole.Name = "selectRole";
            selectRole.Size = new Size(146, 28);
            selectRole.TabIndex = 8;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem, homeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(640, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editProfileToolStripMenuItem, logoutToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(66, 24);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // editProfileToolStripMenuItem
            // 
            editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            editProfileToolStripMenuItem.Size = new Size(165, 26);
            editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(165, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(158, 194);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 27);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // FormSelectRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnClear);
            Controls.Add(selectRole);
            Controls.Add(addList);
            Controls.Add(name);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(roleDropDown);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "FormSelectRole";
            Text = "FormSelectRole";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label roleDropDown;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox name;
        private ListBox addList;
        private ComboBox selectRole;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem editProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private Button btnClear;
    }
}