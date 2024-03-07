namespace EventManagementSystem
{
    partial class FormEventDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventDelete));
            btnDeleteCancel = new Button();
            btnDeleteOK = new Button();
            label1 = new Label();
            eventListDelete = new ComboBox();
            SuspendLayout();
            // 
            // btnDeleteCancel
            // 
            btnDeleteCancel.BackColor = SystemColors.ControlLight;
            btnDeleteCancel.Location = new Point(29, 128);
            btnDeleteCancel.Name = "btnDeleteCancel";
            btnDeleteCancel.Size = new Size(108, 36);
            btnDeleteCancel.TabIndex = 0;
            btnDeleteCancel.Text = "Cancel";
            btnDeleteCancel.UseVisualStyleBackColor = false;
            btnDeleteCancel.Click += btnDeleteCancel_Click;
            // 
            // btnDeleteOK
            // 
            btnDeleteOK.BackColor = SystemColors.ControlLight;
            btnDeleteOK.Location = new Point(236, 128);
            btnDeleteOK.Name = "btnDeleteOK";
            btnDeleteOK.Size = new Size(108, 36);
            btnDeleteOK.TabIndex = 1;
            btnDeleteOK.Text = "OK";
            btnDeleteOK.UseVisualStyleBackColor = false;
            btnDeleteOK.Click += btnDeleteOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 56);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 2;
            label1.Text = "Event Name";
            // 
            // eventListDelete
            // 
            eventListDelete.BackColor = SystemColors.ControlLight;
            eventListDelete.FormattingEnabled = true;
            eventListDelete.Location = new Point(168, 53);
            eventListDelete.Name = "eventListDelete";
            eventListDelete.Size = new Size(151, 28);
            eventListDelete.TabIndex = 3;
            // 
            // FormEventDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(375, 176);
            Controls.Add(eventListDelete);
            Controls.Add(label1);
            Controls.Add(btnDeleteOK);
            Controls.Add(btnDeleteCancel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEventDelete";
            Text = "Delete Event";
            Load += FormEventDelete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteCancel;
        private Button btnDeleteOK;
        private Label label1;
        private ComboBox eventListDelete;
    }
}