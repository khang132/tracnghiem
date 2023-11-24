namespace tracnghiem
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(170, 122);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 13;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(38, 173);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(33, 17);
            this.radioButtonD.TabIndex = 12;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "D";
            this.radioButtonD.UseVisualStyleBackColor = true;
            this.radioButtonD.CheckedChanged += new System.EventHandler(this.radioButtonD_CheckedChanged);
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(39, 138);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(32, 17);
            this.radioButtonC.TabIndex = 11;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.CheckedChanged += new System.EventHandler(this.radioButtonC_CheckedChanged);
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(39, 104);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(32, 17);
            this.radioButtonB.TabIndex = 10;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(39, 66);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(32, 17);
            this.radioButtonA.TabIndex = 9;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            this.radioButtonA.CheckedChanged += new System.EventHandler(this.radioButtonA_CheckedChanged);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(36, 32);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(35, 13);
            this.labelQuestion.TabIndex = 8;
            this.labelQuestion.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.labelQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.Label labelQuestion;
    }
}

