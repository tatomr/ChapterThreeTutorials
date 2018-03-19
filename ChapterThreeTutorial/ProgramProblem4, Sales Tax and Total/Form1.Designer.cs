namespace ProgramProblem4__Sales_Tax_and_Total
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
            this.inputAmountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputStateTaxTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outputCountyTaxTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outputTotalTaxTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateTotalbutton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.outputTotalSalestTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputAmountTextBox
            // 
            this.inputAmountTextBox.Location = new System.Drawing.Point(280, 55);
            this.inputAmountTextBox.Name = "inputAmountTextBox";
            this.inputAmountTextBox.Size = new System.Drawing.Size(143, 26);
            this.inputAmountTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Purchase Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "State sales tax:";
            // 
            // outputStateTaxTextBox
            // 
            this.outputStateTaxTextBox.Location = new System.Drawing.Point(280, 150);
            this.outputStateTaxTextBox.Name = "outputStateTaxTextBox";
            this.outputStateTaxTextBox.Size = new System.Drawing.Size(143, 26);
            this.outputStateTaxTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "County sales tax:";
            // 
            // outputCountyTaxTextBox
            // 
            this.outputCountyTaxTextBox.Location = new System.Drawing.Point(280, 201);
            this.outputCountyTaxTextBox.Name = "outputCountyTaxTextBox";
            this.outputCountyTaxTextBox.Size = new System.Drawing.Size(143, 26);
            this.outputCountyTaxTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total sales tax:";
            // 
            // outputTotalTaxTextBox
            // 
            this.outputTotalTaxTextBox.Location = new System.Drawing.Point(280, 255);
            this.outputTotalTaxTextBox.Name = "outputTotalTaxTextBox";
            this.outputTotalTaxTextBox.Size = new System.Drawing.Size(143, 26);
            this.outputTotalTaxTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total sales:";
            // 
            // calculateTotalbutton
            // 
            this.calculateTotalbutton.Location = new System.Drawing.Point(280, 99);
            this.calculateTotalbutton.Name = "calculateTotalbutton";
            this.calculateTotalbutton.Size = new System.Drawing.Size(143, 28);
            this.calculateTotalbutton.TabIndex = 10;
            this.calculateTotalbutton.Text = "Calculate";
            this.calculateTotalbutton.UseVisualStyleBackColor = true;
            this.calculateTotalbutton.Click += new System.EventHandler(this.calculateTotalbutton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(280, 359);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(143, 28);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputTotalSalestTextBox
            // 
            this.outputTotalSalestTextBox.Location = new System.Drawing.Point(280, 310);
            this.outputTotalSalestTextBox.Name = "outputTotalSalestTextBox";
            this.outputTotalSalestTextBox.Size = new System.Drawing.Size(143, 26);
            this.outputTotalSalestTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 431);
            this.Controls.Add(this.outputTotalSalestTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateTotalbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputTotalTaxTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputCountyTaxTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputStateTaxTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputAmountTextBox);
            this.Name = "Form1";
            this.Text = "Sales, Tax and Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputAmountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputStateTaxTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputCountyTaxTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outputTotalTaxTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculateTotalbutton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox outputTotalSalestTextBox;
    }
}

