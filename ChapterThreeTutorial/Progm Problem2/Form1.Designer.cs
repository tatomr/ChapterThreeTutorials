namespace Progm_Problem2
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
            this.foodChargelabel = new System.Windows.Forms.Label();
            this.inputChargeAmountBox = new System.Windows.Forms.TextBox();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tipLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tipTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // foodChargelabel
            // 
            this.foodChargelabel.AutoSize = true;
            this.foodChargelabel.Location = new System.Drawing.Point(57, 66);
            this.foodChargelabel.Name = "foodChargelabel";
            this.foodChargelabel.Size = new System.Drawing.Size(149, 20);
            this.foodChargelabel.TabIndex = 0;
            this.foodChargelabel.Text = "Enter Food Charge:";
            this.foodChargelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputChargeAmountBox
            // 
            this.inputChargeAmountBox.Location = new System.Drawing.Point(223, 63);
            this.inputChargeAmountBox.Name = "inputChargeAmountBox";
            this.inputChargeAmountBox.Size = new System.Drawing.Size(194, 26);
            this.inputChargeAmountBox.TabIndex = 1;
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.Location = new System.Drawing.Point(115, 326);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(114, 33);
            this.calculateTotalButton.TabIndex = 2;
            this.calculateTotalButton.Text = "Calculate";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(382, 326);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 33);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(123, 124);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(76, 20);
            this.tipLabel.TabIndex = 4;
            this.tipLabel.Text = "Tip (15%)";
            this.tipLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(128, 178);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(71, 20);
            this.taxLabel.TabIndex = 5;
            this.taxLabel.Text = "Tax (7%)";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(155, 235);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 20);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total";
            // 
            // tipTextBox
            // 
            this.tipTextBox.Location = new System.Drawing.Point(223, 117);
            this.tipTextBox.Name = "tipTextBox";
            this.tipTextBox.Size = new System.Drawing.Size(194, 26);
            this.tipTextBox.TabIndex = 7;
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(223, 178);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(194, 26);
            this.taxTextBox.TabIndex = 8;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(223, 235);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(194, 26);
            this.totalTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 427);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.taxTextBox);
            this.Controls.Add(this.tipTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.inputChargeAmountBox);
            this.Controls.Add(this.foodChargelabel);
            this.Name = "Form1";
            this.Text = "Tip- Tax -Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodChargelabel;
        private System.Windows.Forms.TextBox inputChargeAmountBox;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox tipTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
    }
}

