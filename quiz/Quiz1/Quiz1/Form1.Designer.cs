namespace Quiz1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labNum1 = new Label();
            labNum2 = new Label();
            labResult = new Label();
            labValue = new Label();
            radioBtn1 = new RadioButton();
            radioBtn2 = new RadioButton();
            radioBtn3 = new RadioButton();
            radioBtn4 = new RadioButton();
            btnApp = new Button();
            btnSave = new Button();
            btnClr = new Button();
            btnExit = new Button();
            addlist = new ListBox();
            labVal = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // labNum1
            // 
            labNum1.AutoSize = true;
            labNum1.Location = new Point(111, 51);
            labNum1.Name = "labNum1";
            labNum1.Size = new Size(97, 20);
            labNum1.TabIndex = 2;
            labNum1.Text = "First Number:";
            // 
            // labNum2
            // 
            labNum2.AutoSize = true;
            labNum2.Location = new Point(111, 99);
            labNum2.Name = "labNum2";
            labNum2.Size = new Size(119, 20);
            labNum2.TabIndex = 3;
            labNum2.Text = "Second Number:";
            // 
            // labResult
            // 
            labResult.AutoSize = true;
            labResult.Location = new Point(112, 157);
            labResult.Name = "labResult";
            labResult.Size = new Size(49, 20);
            labResult.TabIndex = 4;
            labResult.Text = "Result";
            // 
            // labValue
            // 
            labValue.AutoSize = true;
            labValue.Location = new Point(480, 157);
            labValue.Name = "labValue";
            labValue.Size = new Size(0, 20);
            labValue.TabIndex = 5;
            // 
            // radioBtn1
            // 
            radioBtn1.AutoSize = true;
            radioBtn1.Location = new Point(102, 212);
            radioBtn1.Name = "radioBtn1";
            radioBtn1.Size = new Size(58, 24);
            radioBtn1.TabIndex = 6;
            radioBtn1.TabStop = true;
            radioBtn1.Text = "Add";
            radioBtn1.UseVisualStyleBackColor = true;
            // 
            // radioBtn2
            // 
            radioBtn2.AutoSize = true;
            radioBtn2.Location = new Point(183, 212);
            radioBtn2.Name = "radioBtn2";
            radioBtn2.Size = new Size(85, 24);
            radioBtn2.TabIndex = 7;
            radioBtn2.TabStop = true;
            radioBtn2.Text = "Subtract";
            radioBtn2.UseVisualStyleBackColor = true;
            // 
            // radioBtn3
            // 
            radioBtn3.AutoSize = true;
            radioBtn3.Location = new Point(291, 212);
            radioBtn3.Name = "radioBtn3";
            radioBtn3.Size = new Size(84, 24);
            radioBtn3.TabIndex = 8;
            radioBtn3.TabStop = true;
            radioBtn3.Text = "Multiply";
            radioBtn3.UseVisualStyleBackColor = true;
            // 
            // radioBtn4
            // 
            radioBtn4.AutoSize = true;
            radioBtn4.Location = new Point(409, 212);
            radioBtn4.Name = "radioBtn4";
            radioBtn4.Size = new Size(73, 24);
            radioBtn4.TabIndex = 9;
            radioBtn4.TabStop = true;
            radioBtn4.Text = "Divide";
            radioBtn4.UseVisualStyleBackColor = true;
            // 
            // btnApp
            // 
            btnApp.Location = new Point(33, 282);
            btnApp.Name = "btnApp";
            btnApp.Size = new Size(94, 29);
            btnApp.TabIndex = 10;
            btnApp.Text = "Apply";
            btnApp.UseVisualStyleBackColor = true;
            btnApp.Click += btnApp_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(159, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClr
            // 
            btnClr.Location = new Point(291, 282);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(94, 29);
            btnClr.TabIndex = 12;
            btnClr.Text = "Clear";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(425, 282);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // addlist
            // 
            addlist.FormattingEnabled = true;
            addlist.Location = new Point(409, 24);
            addlist.Name = "addlist";
            addlist.Size = new Size(141, 164);
            addlist.TabIndex = 14;
            // 
            // labVal
            // 
            labVal.AutoSize = true;
            labVal.BorderStyle = BorderStyle.FixedSingle;
            labVal.Location = new Point(291, 157);
            labVal.Name = "labVal";
            labVal.Size = new Size(17, 22);
            labVal.TabIndex = 15;
            labVal.Text = "-";
            labVal.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(labVal);
            Controls.Add(addlist);
            Controls.Add(btnExit);
            Controls.Add(btnClr);
            Controls.Add(btnSave);
            Controls.Add(btnApp);
            Controls.Add(radioBtn4);
            Controls.Add(radioBtn3);
            Controls.Add(radioBtn2);
            Controls.Add(radioBtn1);
            Controls.Add(labValue);
            Controls.Add(labResult);
            Controls.Add(labNum2);
            Controls.Add(labNum1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Quiz 1 - Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label labNum1;
        private Label labNum2;
        private Label labResult;
        private Label labValue;
        private RadioButton radioBtn1;
        private RadioButton radioBtn2;
        private RadioButton radioBtn3;
        private RadioButton radioBtn4;
        private Button btnApp;
        private Button btnSave;
        private Button btnClr;
        private Button btnExit;
        private ListBox addlist;
        private Label labVal;
    }
}
