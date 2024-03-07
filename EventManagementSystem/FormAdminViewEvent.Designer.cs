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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminViewEvent));
            eventViewList = new ListBox();
            btnCloseView = new Button();
            SuspendLayout();
            // 
            // eventViewList
            // 
            eventViewList.BackColor = SystemColors.Control;
            eventViewList.FormattingEnabled = true;
            eventViewList.Location = new Point(12, 18);
            eventViewList.Name = "eventViewList";
            eventViewList.Size = new Size(340, 324);
            eventViewList.TabIndex = 0;
            // 
            // btnCloseView
            // 
            btnCloseView.BackColor = SystemColors.ControlLight;
            btnCloseView.Location = new Point(94, 360);
            btnCloseView.Name = "btnCloseView";
            btnCloseView.Size = new Size(161, 36);
            btnCloseView.TabIndex = 1;
            btnCloseView.Text = "Close";
            btnCloseView.UseVisualStyleBackColor = false;
            btnCloseView.Click += btnCloseView_Click;
            // 
            // FormAdminViewEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(364, 413);
            Controls.Add(btnCloseView);
            Controls.Add(eventViewList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAdminViewEvent";
            Text = "View Event";
            Load += FormAdminViewEvent_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox eventViewList;
        private Button btnCloseView;
    }
}