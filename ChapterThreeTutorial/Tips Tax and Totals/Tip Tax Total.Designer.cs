namespace Programming_Problems
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
            this.foodAmountLabel = new System.Windows.Forms.Label();
            this.inputAmountTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton1 = new System.Windows.Forms.Button();
            this.outputLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // foodAmountLabel
            // 
            this.foodAmountLabel.AutoSize = true;
            this.foodAmountLabel.Location = new System.Drawing.Point(21, 69);
            this.foodAmountLabel.Name = "foodAmountLabel";
            this.foodAmountLabel.Size = new System.Drawing.Size(147, 40);
            this.foodAmountLabel.TabIndex = 0;
            this.foodAmountLabel.Text = "Enter Amount Total\r\n:";
            // 
            // inputAmountTextBox
            // 
            this.inputAmountTextBox.Location = new System.Drawing.Point(174, 69);
            this.inputAmountTextBox.Name = "inputAmountTextBox";
            this.inputAmountTextBox.Size = new System.Drawing.Size(222, 26);
            this.inputAmountTextBox.TabIndex = 1;
            // 
            // calculateButton1
            // 
            this.calculateButton1.Location = new System.Drawing.Point(202, 118);
            this.calculateButton1.Name = "calculateButton1";
            this.calculateButton1.Size = new System.Drawing.Size(161, 31);
            this.calculateButton1.TabIndex = 2;
            this.calculateButton1.Text = "Calculate Total";
            this.calculateButton1.UseVisualStyleBackColor = true;
            this.calculateButton1.Click += new System.EventHandler(this.calculateButton1_Click);
            // 
            // outputLable
            // 
            this.outputLable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLable.Location = new System.Drawing.Point(155, 183);
            this.outputLable.Name = "outputLable";
            this.outputLable.Size = new System.Drawing.Size(269, 188);
            this.outputLable.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 452);
            this.Controls.Add(this.outputLable);
            this.Controls.Add(this.calculateButton1);
            this.Controls.Add(this.inputAmountTextBox);
            this.Controls.Add(this.foodAmountLabel);
            this.Name = "Form1";
            this.Text = "Tip- Tax- Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodAmountLabel;
        private System.Windows.Forms.TextBox inputAmountTextBox;
        private System.Windows.Forms.Button calculateButton1;
        private System.Windows.Forms.Label outputLable;
    }
}