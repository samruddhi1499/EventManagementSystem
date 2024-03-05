namespace EventManagementSystem
{
    partial class FormAdminViewEvent
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
            eventViewList = new ListBox();
            btnCloseView = new Button();
            SuspendLayout();
            // 
            // eventViewList
            // 
            eventViewList.FormattingEnabled = true;
            eventViewList.Location = new Point(12, 18);
            eventViewList.Name = "eventViewList";
            eventViewList.Size = new Size(340, 324);
            eventViewList.TabIndex = 0;
            // 
            // btnCloseView
            // 
            btnCloseView.Location = new Point(94, 360);
            btnCloseView.Name = "btnCloseView";
            btnCloseView.Size = new Size(155, 29);
            btnCloseView.TabIndex = 1;
            btnCloseView.Text = "Close";
            btnCloseView.UseVisualStyleBackColor = true;
            btnCloseView.Click += btnCloseView_Click;
            // 
            // FormAdminViewEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 401);
            Controls.Add(btnCloseView);
            Controls.Add(eventViewList);
            Name = "FormAdminViewEvent";
            Text = "FormAdminViewEvent";
            Load += FormAdminViewEvent_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox eventViewList;
        private Button btnCloseView;
    }
}