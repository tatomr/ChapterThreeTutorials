namespace Birth_Date_String
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
            this.dayOfWeekPromptLabel = new System.Windows.Forms.Label();
            this.monthPromptLabel = new System.Windows.Forms.Label();
            this.dayOfMonthPromptLabel = new System.Windows.Forms.Label();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.dayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.dateOuputLabel = new System.Windows.Forms.Label();
            this.showDateButton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayOfWeekPromptLabel
            // 
            this.dayOfWeekPromptLabel.AutoSize = true;
            this.dayOfWeekPromptLabel.Location = new System.Drawing.Point(87, 22);
            this.dayOfWeekPromptLabel.Name = "dayOfWeekPromptLabel";
            this.dayOfWeekPromptLabel.Size = new System.Drawing.Size(129, 13);
            this.dayOfWeekPromptLabel.TabIndex = 0;
            this.dayOfWeekPromptLabel.Text = "Enter the day of the week";
            this.dayOfWeekPromptLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // monthPromptLabel
            // 
            this.monthPromptLabel.AutoSize = true;
            this.monthPromptLabel.Location = new System.Drawing.Point(75, 45);
            this.monthPromptLabel.Name = "monthPromptLabel";
            this.monthPromptLabel.Size = new System.Drawing.Size(141, 13);
            this.monthPromptLabel.TabIndex = 1;
            this.monthPromptLabel.Text = "Enter the name of the month";
            this.monthPromptLabel.Click += new System.EventHandler(this.monthPromptLabel_Click);
            // 
            // dayOfMonthPromptLabel
            // 
            this.dayOfMonthPromptLabel.AutoSize = true;
            this.dayOfMonthPromptLabel.Location = new System.Drawing.Point(44, 71);
            this.dayOfMonthPromptLabel.Name = "dayOfMonthPromptLabel";
            this.dayOfMonthPromptLabel.Size = new System.Drawing.Size(172, 13);
            this.dayOfMonthPromptLabel.TabIndex = 2;
            this.dayOfMonthPromptLabel.Text = "Enter the numeric day of the month";
            this.dayOfMonthPromptLabel.Click += new System.EventHandler(this.dayOfMonthPromptLabel_Click);
            // 
            // yearPromptLabel
            // 
            this.yearPromptLabel.AutoSize = true;
            this.yearPromptLabel.Location = new System.Drawing.Point(143, 97);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(73, 13);
            this.yearPromptLabel.TabIndex = 3;
            this.yearPromptLabel.Text = "Enter the year";
            // 
            // dayOfWeekTextBox
            // 
            this.dayOfWeekTextBox.Location = new System.Drawing.Point(222, 19);
            this.dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            this.dayOfWeekTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayOfWeekTextBox.TabIndex = 4;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(222, 45);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 5;
            // 
            // dayOfMonthTextBox
            // 
            this.dayOfMonthTextBox.Location = new System.Drawing.Point(222, 71);
            this.dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            this.dayOfMonthTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayOfMonthTextBox.TabIndex = 6;
            this.dayOfMonthTextBox.TextChanged += new System.EventHandler(this.DayOfMonthTextBox_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(222, 97);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 7;
            // 
            // dateOuputLabel
            // 
            this.dateOuputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOuputLabel.Location = new System.Drawing.Point(15, 135);
            this.dateOuputLabel.Name = "dateOuputLabel";
            this.dateOuputLabel.Size = new System.Drawing.Size(307, 23);
            this.dateOuputLabel.TabIndex = 8;
            this.dateOuputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showDateButton
            // 
            this.showDateButton.Location = new System.Drawing.Point(15, 203);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(75, 23);
            this.showDateButton.TabIndex = 9;
            this.showDateButton.Text = "Show Date";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(141, 203);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 10;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(247, 203);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.dateOuputLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayOfMonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayOfWeekTextBox);
            this.Controls.Add(this.yearPromptLabel);
            this.Controls.Add(this.dayOfMonthPromptLabel);
            this.Controls.Add(this.monthPromptLabel);
            this.Controls.Add(this.dayOfWeekPromptLabel);
            this.Name = "Form1";
            this.Text = "Birth Date String ";
            this.Load += new System.EventHandler(this.Bithday_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOfWeekPromptLabel;
        private System.Windows.Forms.Label monthPromptLabel;
        private System.Windows.Forms.Label dayOfMonthPromptLabel;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.TextBox dayOfWeekTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayOfMonthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label dateOuputLabel;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button exitButton;
    }
}

