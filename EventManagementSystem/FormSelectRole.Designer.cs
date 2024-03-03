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
            dropDown = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            name = new TextBox();
            addList = new ListBox();
            selectRole = new ComboBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 51);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // dropDown
            // 
            dropDown.AutoSize = true;
            dropDown.Location = new Point(50, 132);
            dropDown.Name = "dropDown";
            dropDown.Size = new Size(46, 25);
            dropDown.TabIndex = 1;
            dropDown.Text = "Role";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 243);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(198, 243);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(371, 243);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // name
            // 
            name.Location = new Point(223, 48);
            name.Name = "name";
            name.Size = new Size(182, 31);
            name.TabIndex = 5;
            name.TextChanged += name_TextChanged;
            // 
            // addList
            // 
            addList.FormattingEnabled = true;
            addList.ItemHeight = 25;
            addList.Location = new Point(584, 23);
            addList.Name = "addList";
            addList.Size = new Size(180, 254);
            addList.TabIndex = 7;
            addList.SelectedIndexChanged += addList_SelectedIndexChanged;
            // 
            // selectRole
            // 
            selectRole.FormattingEnabled = true;
            selectRole.Items.AddRange(new object[] { "Sam", "Saloni", "Sruthi" });
            selectRole.Location = new Point(223, 186);
            selectRole.Name = "selectRole";
            selectRole.Size = new Size(182, 33);
            selectRole.TabIndex = 8;
            selectRole.SelectedIndexChanged += selectRole_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 31);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // FormSelectRole
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(selectRole);
            Controls.Add(addList);
            Controls.Add(name);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dropDown);
            Controls.Add(label1);
            Name = "FormSelectRole";
            Text = "FormSelectRole";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label dropDown;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox name;
        private ListBox addList;
        private ComboBox selectRole;
        private TextBox textBox1;
    }
}