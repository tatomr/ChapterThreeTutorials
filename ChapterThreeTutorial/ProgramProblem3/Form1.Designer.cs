namespace ProgramProblem3
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
            this.speedLabel1 = new System.Windows.Forms.Label();
            this.distanceLabel2 = new System.Windows.Forms.Label();
            this.speedTextBox1 = new System.Windows.Forms.TextBox();
            this.fiveHourbutton = new System.Windows.Forms.Button();
            this.eightHourbutton = new System.Windows.Forms.Button();
            this.twelveHourButton = new System.Windows.Forms.Button();
            this.distanceTraveledTextBox = new System.Windows.Forms.TextBox();
            this.fiveHourLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speedLabel1
            // 
            this.speedLabel1.AutoSize = true;
            this.speedLabel1.Location = new System.Drawing.Point(65, 47);
            this.speedLabel1.Name = "speedLabel1";
            this.speedLabel1.Size = new System.Drawing.Size(103, 20);
            this.speedLabel1.TabIndex = 0;
            this.speedLabel1.Text = "Enter Speed:";
            // 
            // distanceLabel2
            // 
            this.distanceLabel2.AutoSize = true;
            this.distanceLabel2.Location = new System.Drawing.Point(396, 50);
            this.distanceLabel2.Name = "distanceLabel2";
            this.distanceLabel2.Size = new System.Drawing.Size(81, 20);
            this.distanceLabel2.TabIndex = 1;
            this.distanceLabel2.Text = "miles/hour";
            // 
            // speedTextBox1
            // 
            this.speedTextBox1.Location = new System.Drawing.Point(174, 44);
            this.speedTextBox1.Name = "speedTextBox1";
            this.speedTextBox1.Size = new System.Drawing.Size(216, 26);
            this.speedTextBox1.TabIndex = 2;
            // 
            // fiveHourbutton
            // 
            this.fiveHourbutton.Location = new System.Drawing.Point(69, 117);
            this.fiveHourbutton.Name = "fiveHourbutton";
            this.fiveHourbutton.Size = new System.Drawing.Size(116, 45);
            this.fiveHourbutton.TabIndex = 3;
            this.fiveHourbutton.Text = "5 Hours";
            this.fiveHourbutton.UseVisualStyleBackColor = true;
            this.fiveHourbutton.Click += new System.EventHandler(this.fiveHourbutton_Click);
            // 
            // eightHourbutton
            // 
            this.eightHourbutton.Location = new System.Drawing.Point(234, 117);
            this.eightHourbutton.Name = "eightHourbutton";
            this.eightHourbutton.Size = new System.Drawing.Size(103, 45);
            this.eightHourbutton.TabIndex = 4;
            this.eightHourbutton.Text = "8 Hours";
            this.eightHourbutton.UseVisualStyleBackColor = true;
            this.eightHourbutton.Click += new System.EventHandler(this.eightHourbutton_Click);
            // 
            // twelveHourButton
            // 
            this.twelveHourButton.Location = new System.Drawing.Point(371, 117);
            this.twelveHourButton.Name = "twelveHourButton";
            this.twelveHourButton.Size = new System.Drawing.Size(106, 46);
            this.twelveHourButton.TabIndex = 5;
            this.twelveHourButton.Text = "12 Hours";
            this.twelveHourButton.UseVisualStyleBackColor = true;
            this.twelveHourButton.Click += new System.EventHandler(this.twelveHourButton_Click);
            // 
            // distanceTraveledTextBox
            // 
            this.distanceTraveledTextBox.Location = new System.Drawing.Point(216, 197);
            this.distanceTraveledTextBox.Name = "distanceTraveledTextBox";
            this.distanceTraveledTextBox.Size = new System.Drawing.Size(174, 26);
            this.distanceTraveledTextBox.TabIndex = 6;
            // 
            // fiveHourLabel
            // 
            this.fiveHourLabel.AutoSize = true;
            this.fiveHourLabel.Location = new System.Drawing.Point(35, 203);
            this.fiveHourLabel.Name = "fiveHourLabel";
            this.fiveHourLabel.Size = new System.Drawing.Size(175, 20);
            this.fiveHourLabel.TabIndex = 9;
            this.fiveHourLabel.Text = " The Distance Traveled:";
            this.fiveHourLabel.Click += new System.EventHandler(this.fiveHourLabel_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(374, 269);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 50);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(69, 269);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 50);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 356);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fiveHourLabel);
            this.Controls.Add(this.distanceTraveledTextBox);
            this.Controls.Add(this.twelveHourButton);
            this.Controls.Add(this.eightHourbutton);
            this.Controls.Add(this.fiveHourbutton);
            this.Controls.Add(this.speedTextBox1);
            this.Controls.Add(this.distanceLabel2);
            this.Controls.Add(this.speedLabel1);
            this.Name = "Form1";
            this.Text = "Distance Traveled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedLabel1;
        private System.Windows.Forms.Label distanceLabel2;
        private System.Windows.Forms.TextBox speedTextBox1;
        private System.Windows.Forms.Button fiveHourbutton;
        private System.Windows.Forms.Button eightHourbutton;
        private System.Windows.Forms.Button twelveHourButton;
        private System.Windows.Forms.TextBox distanceTraveledTextBox;
        private System.Windows.Forms.Label fiveHourLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

