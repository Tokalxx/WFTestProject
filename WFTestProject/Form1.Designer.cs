namespace WFTestProject
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
            this.MultiChoicePanel = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.text = new System.Windows.Forms.RadioButton();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.GenButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.MultiChoicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MultiChoicePanel
            // 
            this.MultiChoicePanel.Controls.Add(this.radioButton3);
            this.MultiChoicePanel.Controls.Add(this.radioButton2);
            this.MultiChoicePanel.Controls.Add(this.radioButton1);
            this.MultiChoicePanel.Controls.Add(this.text);
            this.MultiChoicePanel.Location = new System.Drawing.Point(108, 85);
            this.MultiChoicePanel.Name = "MultiChoicePanel";
            this.MultiChoicePanel.Size = new System.Drawing.Size(200, 228);
            this.MultiChoicePanel.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(21, 162);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 20);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "...";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 121);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "...";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 79);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "...";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(21, 37);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(37, 20);
            this.text.TabIndex = 0;
            this.text.TabStop = true;
            this.text.Text = "...";
            this.text.UseVisualStyleBackColor = true;
            // 
            // AnswerButton
            // 
            this.AnswerButton.Location = new System.Drawing.Point(429, 109);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(75, 23);
            this.AnswerButton.TabIndex = 1;
            this.AnswerButton.Text = "Answer";
            this.AnswerButton.UseVisualStyleBackColor = true;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // GenButton
            // 
            this.GenButton.Location = new System.Drawing.Point(429, 161);
            this.GenButton.Name = "GenButton";
            this.GenButton.Size = new System.Drawing.Size(75, 23);
            this.GenButton.TabIndex = 2;
            this.GenButton.Text = "Gen";
            this.GenButton.UseVisualStyleBackColor = true;
            this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(108, 35);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(16, 16);
            this.answerLabel.TabIndex = 3;
            this.answerLabel.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.GenButton);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.MultiChoicePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MultiChoicePanel.ResumeLayout(false);
            this.MultiChoicePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MultiChoicePanel;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton text;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.Button GenButton;
        private System.Windows.Forms.Label answerLabel;
    }
}

