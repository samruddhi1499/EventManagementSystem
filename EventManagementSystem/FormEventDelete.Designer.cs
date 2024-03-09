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
            btnDeleteCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDeleteCancel.Location = new Point(36, 147);
            btnDeleteCancel.Margin = new Padding(4, 3, 4, 3);
            btnDeleteCancel.Name = "btnDeleteCancel";
            btnDeleteCancel.Size = new Size(135, 41);
            btnDeleteCancel.TabIndex = 0;
            btnDeleteCancel.Text = "Cancel";
            btnDeleteCancel.UseVisualStyleBackColor = false;
            btnDeleteCancel.Click += btnDeleteCancel_Click;
            btnDeleteCancel.MouseLeave += btnDeleteCancel_MouseLeave;
            btnDeleteCancel.MouseHover += btnDeleteCancel_MouseHover;
            // 
            // btnDeleteOK
            // 
            btnDeleteOK.BackColor = SystemColors.ControlLight;
            btnDeleteOK.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDeleteOK.Location = new Point(295, 147);
            btnDeleteOK.Margin = new Padding(4, 3, 4, 3);
            btnDeleteOK.Name = "btnDeleteOK";
            btnDeleteOK.Size = new Size(135, 41);
            btnDeleteOK.TabIndex = 1;
            btnDeleteOK.Text = "OK";
            btnDeleteOK.UseVisualStyleBackColor = false;
            btnDeleteOK.Click += btnDeleteOK_Click;
            btnDeleteOK.MouseLeave += btnDeleteOK_MouseLeave;
            btnDeleteOK.MouseHover += btnDeleteOK_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 2;
            label1.Text = "Event Name";
            // 
            // eventListDelete
            // 
            eventListDelete.BackColor = SystemColors.ControlLight;
            eventListDelete.FormattingEnabled = true;
            eventListDelete.Location = new Point(210, 61);
            eventListDelete.Margin = new Padding(4, 3, 4, 3);
            eventListDelete.Name = "eventListDelete";
            eventListDelete.Size = new Size(188, 31);
            eventListDelete.TabIndex = 3;
            // 
            // FormEventDelete
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(469, 202);
            Controls.Add(eventListDelete);
            Controls.Add(label1);
            Controls.Add(btnDeleteOK);
            Controls.Add(btnDeleteCancel);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormEventDelete";
            StartPosition = FormStartPosition.CenterScreen;
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