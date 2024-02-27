namespace EventManagementSystem
{
    partial class FormEventManipulation
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
            btnEventAdd = new Button();
            btnEventEdit = new Button();
            btnEventDelete = new Button();
            eventList = new ListBox();
            SuspendLayout();
            // 
            // btnEventAdd
            // 
            btnEventAdd.Location = new Point(38, 188);
            btnEventAdd.Name = "btnEventAdd";
            btnEventAdd.Size = new Size(94, 29);
            btnEventAdd.TabIndex = 0;
            btnEventAdd.Text = "Add";
            btnEventAdd.UseVisualStyleBackColor = true;
            btnEventAdd.Click += btnEventAdd_Click;
            // 
            // btnEventEdit
            // 
            btnEventEdit.Location = new Point(170, 188);
            btnEventEdit.Name = "btnEventEdit";
            btnEventEdit.Size = new Size(94, 29);
            btnEventEdit.TabIndex = 1;
            btnEventEdit.Text = "Edit";
            btnEventEdit.UseVisualStyleBackColor = true;
            // 
            // btnEventDelete
            // 
            btnEventDelete.Location = new Point(307, 188);
            btnEventDelete.Name = "btnEventDelete";
            btnEventDelete.Size = new Size(94, 29);
            btnEventDelete.TabIndex = 2;
            btnEventDelete.Text = "Delete";
            btnEventDelete.UseVisualStyleBackColor = true;
            // 
            // eventList
            // 
            eventList.FormattingEnabled = true;
            eventList.Location = new Point(507, 12);
            eventList.Name = "eventList";
            eventList.Size = new Size(281, 304);
            eventList.TabIndex = 3;
            // 
            // FormEventManipulation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(eventList);
            Controls.Add(btnEventDelete);
            Controls.Add(btnEventEdit);
            Controls.Add(btnEventAdd);
            Name = "FormEventManipulation";
            Text = "FormEventManipulation";
            Activated += FormEventManipulation_Activated;
            Load += FormEventManipulation_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEventAdd;
        private Button btnEventEdit;
        private Button btnEventDelete;
        private ListBox eventList;
    }
}