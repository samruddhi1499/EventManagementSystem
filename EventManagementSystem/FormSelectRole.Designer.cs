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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectRole));
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
            pass = new TextBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(108, 179);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 55);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // roleDropDown
            // 
            roleDropDown.AutoSize = true;
            roleDropDown.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            roleDropDown.Location = new Point(183, 474);
            roleDropDown.Margin = new Padding(5, 0, 5, 0);
            roleDropDown.Name = "roleDropDown";
            roleDropDown.Size = new Size(106, 55);
            roleDropDown.TabIndex = 1;
            roleDropDown.Text = "Role";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlLight;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAdd.Location = new Point(28, 689);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(270, 86);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseLeave += btnAdd_MouseLeave;
            btnAdd.MouseHover += btnAdd_MouseHover;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ControlLight;
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEdit.Location = new Point(28, 689);
            btnEdit.Margin = new Padding(5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(270, 86);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            btnEdit.MouseLeave += btnEdit_MouseLeave;
            btnEdit.MouseHover += btnEdit_MouseHover;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLight;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(742, 689);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(270, 86);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseLeave += btnDelete_MouseLeave;
            btnDelete.MouseHover += btnDelete_MouseHover;
            // 
            // name
            // 
            name.BackColor = SystemColors.ControlLight;
            name.Location = new Point(442, 179);
            name.Margin = new Padding(5);
            name.Name = "name";
            name.Size = new Size(404, 55);
            name.TabIndex = 5;
            // 
            // addList
            // 
            addList.BackColor = Color.Lavender;
            addList.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addList.FormattingEnabled = true;
            addList.ItemHeight = 55;
            addList.Location = new Point(1115, 111);
            addList.Margin = new Padding(5);
            addList.Name = "addList";
            addList.Size = new Size(513, 664);
            addList.TabIndex = 7;
            addList.SelectedIndexChanged += addList_SelectedIndexChanged;
            addList.DoubleClick += addList_DoubleClick;
            // 
            // selectRole
            // 
            selectRole.BackColor = SystemColors.ControlLight;
            selectRole.DropDownStyle = ComboBoxStyle.DropDownList;
            selectRole.ForeColor = SystemColors.WindowText;
            selectRole.FormattingEnabled = true;
            selectRole.Items.AddRange(new object[] { "Admin", "EM", "Attendee" });
            selectRole.Location = new Point(442, 476);
            selectRole.Margin = new Padding(5);
            selectRole.Name = "selectRole";
            selectRole.Size = new Size(404, 56);
            selectRole.TabIndex = 8;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuBar;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem, homeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(15, 5, 0, 5);
            menuStrip1.Size = new Size(1664, 62);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editProfileToolStripMenuItem, logoutToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(150, 52);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // editProfileToolStripMenuItem
            // 
            editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            editProfileToolStripMenuItem.Size = new Size(406, 66);
            editProfileToolStripMenuItem.Text = "View Profile";
            editProfileToolStripMenuItem.Click += editProfileToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(406, 66);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(145, 52);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnClear.Location = new Point(380, 689);
            btnClear.Margin = new Padding(5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(270, 86);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            btnClear.MouseLeave += btnClear_MouseLeave;
            btnClear.MouseHover += btnClear_MouseHover;
            // 
            // pass
            // 
            pass.BackColor = SystemColors.ControlLight;
            pass.Location = new Point(442, 331);
            pass.Margin = new Padding(8, 7, 8, 7);
            pass.Name = "pass";
            pass.Size = new Size(404, 55);
            pass.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 332);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 54);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // FormSelectRole
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1664, 864);
            Controls.Add(label2);
            Controls.Add(pass);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "FormSelectRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Maipulation";
            Load += FormSelectRole_Load;
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
        private TextBox pass;
        private Label label2;
    }
}