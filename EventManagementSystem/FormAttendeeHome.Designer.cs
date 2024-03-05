﻿
namespace EventManagementSystem
{
    partial class FormAttendeeHome
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
            chooseEvent = new Button();
            listEvents = new ComboBox();
            viewEvent = new Button();
            register = new Button();
            viewRegisteredEvent = new Button();
            regiterEvents = new ComboBox();
            View = new Button();
            listEventDetails = new ListBox();
            SuspendLayout();
            // 
            // chooseEvent
            // 
            chooseEvent.Location = new Point(49, 106);
            chooseEvent.Name = "chooseEvent";
            chooseEvent.Size = new Size(132, 40);
            chooseEvent.TabIndex = 0;
            chooseEvent.Text = "Events";
            chooseEvent.UseVisualStyleBackColor = true;
            chooseEvent.Click += button1_Click;
            // 
            // listEvents
            // 
            listEvents.FormattingEnabled = true;
            listEvents.Location = new Point(227, 107);
            listEvents.Name = "listEvents";
            listEvents.Size = new Size(151, 28);
            listEvents.TabIndex = 1;
            listEvents.SelectedIndexChanged += listEvents_SelectedIndexChanged;
            // 
            // viewEvent
            // 
            viewEvent.Location = new Point(49, 175);
            viewEvent.Name = "viewEvent";
            viewEvent.Size = new Size(94, 29);
            viewEvent.TabIndex = 2;
            viewEvent.Text = "View";
            viewEvent.UseVisualStyleBackColor = true;
            viewEvent.Click += viewEvent_Click;
            // 
            // register
            // 
            register.Location = new Point(244, 175);
            register.Name = "register";
            register.Size = new Size(94, 29);
            register.TabIndex = 3;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // viewRegisteredEvent
            // 
            viewRegisteredEvent.Location = new Point(22, 284);
            viewRegisteredEvent.Name = "viewRegisteredEvent";
            viewRegisteredEvent.Size = new Size(233, 58);
            viewRegisteredEvent.TabIndex = 4;
            viewRegisteredEvent.Text = "View Registered Event";
            viewRegisteredEvent.UseVisualStyleBackColor = true;
            viewRegisteredEvent.Click += button4_Click;
            // 
            // regiterEvents
            // 
            regiterEvents.FormattingEnabled = true;
            regiterEvents.Location = new Point(272, 300);
            regiterEvents.Name = "regiterEvents";
            regiterEvents.Size = new Size(151, 28);
            regiterEvents.TabIndex = 5;
            // 
            // View
            // 
            View.Location = new Point(161, 387);
            View.Name = "View";
            View.Size = new Size(94, 29);
            View.TabIndex = 6;
            View.Text = "View";
            View.UseVisualStyleBackColor = true;
            View.Click += View_Click;
            // 
            // listEventDetails
            // 
            listEventDetails.FormattingEnabled = true;
            listEventDetails.Location = new Point(520, 59);
            listEventDetails.Name = "listEventDetails";
            listEventDetails.Size = new Size(258, 344);
            listEventDetails.TabIndex = 7;
            listEventDetails.SelectedIndexChanged += listEventDetails_SelectedIndexChanged;
            // 
            // FormAttendeeHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listEventDetails);
            Controls.Add(View);
            Controls.Add(regiterEvents);
            Controls.Add(viewRegisteredEvent);
            Controls.Add(register);
            Controls.Add(viewEvent);
            Controls.Add(listEvents);
            Controls.Add(chooseEvent);
            Name = "FormAttendeeHome";
            Text = "FormAttendeeHome";
            Activated += FormAttendeeHome_Activated;
            ResumeLayout(false);
        }

        private void listEventDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button chooseEvent;
        private ComboBox listEvents;
        private Button viewEvent;
        private Button register;
        private Button viewRegisteredEvent;
        private ComboBox regiterEvents;
        private Button View;
        private ListBox listEventDetails;
    }
}