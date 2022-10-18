namespace MessageBoxCSharp
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnText1 = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btnTextCaptionButton2OkCancel = new System.Windows.Forms.Button();
            this.btnTextCaptionButton3YesNoCancel = new System.Windows.Forms.Button();
            this.btnTextCaptionButton4RetryCancel = new System.Windows.Forms.Button();
            this.btnTextCaptionButton5AbortRetryIgnore = new System.Windows.Forms.Button();
            this.btnTextCaption2 = new System.Windows.Forms.Button();
            this.btnTextCaption1 = new System.Windows.Forms.Button();
            this.btnTextCaptionButtonIcon4Information = new System.Windows.Forms.Button();
            this.btnTextCaptionButtonIcon3Error = new System.Windows.Forms.Button();
            this.btnTextCaptionButtonIcon2Warning = new System.Windows.Forms.Button();
            this.btnTextCaptionButtonIcon1Question = new System.Windows.Forms.Button();
            this.btnOthers1Details = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTextCaptionButton1Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.LightSalmon;
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(191, 50);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Text";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnText1
            // 
            this.btnText1.Location = new System.Drawing.Point(26, 87);
            this.btnText1.Name = "btnText1";
            this.btnText1.Size = new System.Drawing.Size(159, 47);
            this.btnText1.TabIndex = 5;
            this.btnText1.Text = "Click 1 | Text";
            this.btnText1.UseVisualStyleBackColor = true;
            this.btnText1.Click += new System.EventHandler(this.btnText1_Click);
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Salmon;
            this.lbl2.Location = new System.Drawing.Point(209, 9);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(191, 50);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Text | Caption";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Tomato;
            this.lbl3.Location = new System.Drawing.Point(406, 9);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(191, 50);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Text | Caption | Buttons";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.DarkSalmon;
            this.lbl4.Location = new System.Drawing.Point(603, 9);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(202, 50);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "Text | Caption | Buttons | Icons";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.Coral;
            this.lbl5.Location = new System.Drawing.Point(811, 9);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(187, 50);
            this.lbl5.TabIndex = 0;
            this.lbl5.Text = "Others";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTextCaptionButton2OkCancel
            // 
            this.btnTextCaptionButton2OkCancel.Location = new System.Drawing.Point(428, 149);
            this.btnTextCaptionButton2OkCancel.Name = "btnTextCaptionButton2OkCancel";
            this.btnTextCaptionButton2OkCancel.Size = new System.Drawing.Size(159, 47);
            this.btnTextCaptionButton2OkCancel.TabIndex = 16;
            this.btnTextCaptionButton2OkCancel.Text = "Click 16 | OK - Cancel";
            this.btnTextCaptionButton2OkCancel.UseVisualStyleBackColor = true;
            this.btnTextCaptionButton2OkCancel.Click += new System.EventHandler(this.btnTextCaptionButton2OkCancel_Click);
            // 
            // btnTextCaptionButton3YesNoCancel
            // 
            this.btnTextCaptionButton3YesNoCancel.Location = new System.Drawing.Point(428, 212);
            this.btnTextCaptionButton3YesNoCancel.Name = "btnTextCaptionButton3YesNoCancel";
            this.btnTextCaptionButton3YesNoCancel.Size = new System.Drawing.Size(159, 47);
            this.btnTextCaptionButton3YesNoCancel.TabIndex = 17;
            this.btnTextCaptionButton3YesNoCancel.Text = "Click 17 | Yes - No - Cancel";
            this.btnTextCaptionButton3YesNoCancel.UseVisualStyleBackColor = true;
            this.btnTextCaptionButton3YesNoCancel.Click += new System.EventHandler(this.btnTextCaptionButton3YesNoCancel_Click);
            // 
            // btnTextCaptionButton4RetryCancel
            // 
            this.btnTextCaptionButton4RetryCancel.Location = new System.Drawing.Point(428, 277);
            this.btnTextCaptionButton4RetryCancel.Name = "btnTextCaptionButton4RetryCancel";
            this.btnTextCaptionButton4RetryCancel.Size = new System.Drawing.Size(159, 47);
            this.btnTextCaptionButton4RetryCancel.TabIndex = 18;
            this.btnTextCaptionButton4RetryCancel.Text = "Click 18 | Retry - Cancel";
            this.btnTextCaptionButton4RetryCancel.UseVisualStyleBackColor = true;
            this.btnTextCaptionButton4RetryCancel.Click += new System.EventHandler(this.btnTextCaptionButton4RetryCancel_Click);
            // 
            // btnTextCaptionButton5AbortRetryIgnore
            // 
            this.btnTextCaptionButton5AbortRetryIgnore.Location = new System.Drawing.Point(428, 339);
            this.btnTextCaptionButton5AbortRetryIgnore.Name = "btnTextCaptionButton5AbortRetryIgnore";
            this.btnTextCaptionButton5AbortRetryIgnore.Size = new System.Drawing.Size(159, 47);
            this.btnTextCaptionButton5AbortRetryIgnore.TabIndex = 19;
            this.btnTextCaptionButton5AbortRetryIgnore.Text = "Click 19 | Abort - Retry - Ignore";
            this.btnTextCaptionButton5AbortRetryIgnore.UseVisualStyleBackColor = true;
            this.btnTextCaptionButton5AbortRetryIgnore.Click += new System.EventHandler(this.btnTextCaptionButton5AbortRetryIgnore_Click);
            // 
            // btnTextCaption2
            // 
            this.btnTextCaption2.Location = new System.Drawing.Point(224, 149);
            this.btnTextCaption2.Name = "btnTextCaption2";
            this.btnTextCaption2.Size = new System.Drawing.Size(159, 47);
            this.btnTextCaption2.TabIndex = 11;
            this.btnTextCaption2.Text = "Click 6 | Long text";
            this.btnTextCaption2.UseVisualStyleBackColor = true;
            this.btnTextCaption2.Click += new System.EventHandler(this.btnTextCaption2_Click);
            // 
            // btnTextCaption1
            // 
            this.btnTextCaption1.Location = new System.Drawing.Point(224, 87);
            this.btnTextCaption1.Name = "btnTextCaption1";
            this.btnTextCaption1.Size = new System.Drawing.Size(159, 47);
            this.btnTextCaption1.TabIndex = 10;
            this.btnTextCaption1.Text = "Click 5 | Caption";
            this.btnTextCaption1.UseVisualStyleBackColor = true;
            this.btnTextCaption1.Click += new System.EventHandler(this.btnTextCaption1_Click);
            // 
            // btnTextCaptionButtonIcon4Information
            // 
            this.btnTextCaptionButtonIcon4Information.Location = new System.Drawing.Point(623, 277);
            this.btnTextCaptionButtonIcon4Information.Name = "btnTextCaptionButtonIcon4Information";
            this.btnTextCaptionButtonIcon4Information.Size = new System.Drawing.Size(159, 47);
            this.btnTextCaptionButtonIcon4Information.TabIndex = 43;
            this.btnTextCaptionButtonIcon4Information.Text = "Click 33 | Information";
            this.btnTextCaptionButtonIcon4Information.UseVisualStyleBackColor = true;
            this.btnTextCaptionButtonIcon4Information.Click += new System.EventHandler(this.btnTextCaptionButtonIcon4Information_Click);
            // 
            // btnTextCaptionButtonIcon3Error
            // 
            this.btnTextCaptionButtonIcon3Error.Location = new System.Drawing.Point(623, 212);
            this.btnTextCaptionButtonIcon3Error.Name = "btnTextCaptionButtonIcon3Error";
            this.btnTextCaptionButtonIcon3Error.Size = new System.Drawing.Size(159, 47);
            this.btnTextCaptionButtonIcon3Error.TabIndex = 42;
            this.btnTextCaptionButtonIcon3Error.Text = "Click 32 | Error - STOP";
            this.btnTextCaptionButtonIcon3Error.UseVisualStyleBackColor = true;
            this.btnTextCaptionButtonIcon3Error.Click += new System.EventHandler(this.btnTextCaptionButtonIcon3Error_Click);
            // 
            // btnTextCaptionButtonIcon2Warning
            // 
            this.btnTextCaptionButtonIcon2Warning.Location = new System.Drawing.Point(623, 149);
            this.btnTextCaptionButtonIcon2Warning.Name = "btnTextCaptionButtonIcon2Warning";
            this.btnTextCaptionButtonIcon2Warning.Size = new System.Drawing.Size(159, 47);
            this.btnTextCaptionButtonIcon2Warning.TabIndex = 41;
            this.btnTextCaptionButtonIcon2Warning.Text = "Click 31 | Exclamation - Warning";
            this.btnTextCaptionButtonIcon2Warning.UseVisualStyleBackColor = true;
            this.btnTextCaptionButtonIcon2Warning.Click += new System.EventHandler(this.btnTextCaptionButtonIcon2Warning_Click);
            // 
            // btnTextCaptionButtonIcon1Question
            // 
            this.btnTextCaptionButtonIcon1Question.Location = new System.Drawing.Point(623, 87);
            this.btnTextCaptionButtonIcon1Question.Name = "btnTextCaptionButtonIcon1Question";
            this.btnTextCaptionButtonIcon1Question.Size = new System.Drawing.Size(159, 47);
            this.btnTextCaptionButtonIcon1Question.TabIndex = 40;
            this.btnTextCaptionButtonIcon1Question.Text = "Click 30 | Question | Yes - No";
            this.btnTextCaptionButtonIcon1Question.UseVisualStyleBackColor = true;
            this.btnTextCaptionButtonIcon1Question.Click += new System.EventHandler(this.btnTextCaptionButtonIcon1Question_Click);
            // 
            // btnOthers1Details
            // 
            this.btnOthers1Details.Location = new System.Drawing.Point(825, 87);
            this.btnOthers1Details.Name = "btnOthers1Details";
            this.btnOthers1Details.Size = new System.Drawing.Size(159, 47);
            this.btnOthers1Details.TabIndex = 60;
            this.btnOthers1Details.Text = "Click 40 | Details";
            this.btnOthers1Details.UseVisualStyleBackColor = true;
            this.btnOthers1Details.Click += new System.EventHandler(this.btnOthers1Details_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(825, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 47);
            this.button2.TabIndex = 61;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(825, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 47);
            this.button3.TabIndex = 62;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnTextCaptionButton1Ok
            // 
            this.btnTextCaptionButton1Ok.Location = new System.Drawing.Point(428, 87);
            this.btnTextCaptionButton1Ok.Name = "btnTextCaptionButton1Ok";
            this.btnTextCaptionButton1Ok.Size = new System.Drawing.Size(159, 47);
            this.btnTextCaptionButton1Ok.TabIndex = 15;
            this.btnTextCaptionButton1Ok.Text = "Click 15 | OK";
            this.btnTextCaptionButton1Ok.UseVisualStyleBackColor = true;
            this.btnTextCaptionButton1Ok.Click += new System.EventHandler(this.btnTextCaptionButton1Ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 472);
            this.Controls.Add(this.btnTextCaptionButton1Ok);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOthers1Details);
            this.Controls.Add(this.btnTextCaptionButtonIcon4Information);
            this.Controls.Add(this.btnTextCaptionButtonIcon3Error);
            this.Controls.Add(this.btnTextCaptionButtonIcon2Warning);
            this.Controls.Add(this.btnTextCaptionButtonIcon1Question);
            this.Controls.Add(this.btnTextCaption2);
            this.Controls.Add(this.btnTextCaption1);
            this.Controls.Add(this.btnTextCaptionButton5AbortRetryIgnore);
            this.Controls.Add(this.btnTextCaptionButton4RetryCancel);
            this.Controls.Add(this.btnTextCaptionButton3YesNoCancel);
            this.Controls.Add(this.btnTextCaptionButton2OkCancel);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnText1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Box Examples";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnText1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btnTextCaptionButton2OkCancel;
        private System.Windows.Forms.Button btnTextCaptionButton3YesNoCancel;
        private System.Windows.Forms.Button btnTextCaptionButton4RetryCancel;
        private System.Windows.Forms.Button btnTextCaptionButton5AbortRetryIgnore;
        private System.Windows.Forms.Button btnTextCaption2;
        private System.Windows.Forms.Button btnTextCaption1;
        private System.Windows.Forms.Button btnTextCaptionButtonIcon4Information;
        private System.Windows.Forms.Button btnTextCaptionButtonIcon3Error;
        private System.Windows.Forms.Button btnTextCaptionButtonIcon2Warning;
        private System.Windows.Forms.Button btnTextCaptionButtonIcon1Question;
        private System.Windows.Forms.Button btnOthers1Details;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTextCaptionButton1Ok;
    }
}

