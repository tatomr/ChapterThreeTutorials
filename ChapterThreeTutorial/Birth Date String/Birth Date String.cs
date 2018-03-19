using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bithday_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void dayOfMonthPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void DayOfMonthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            //Declare a string variable.
            string output;

            //Concatenate the input and build the output string.
            output = dayOfWeekTextBox.Text + ", " +
                     monthTextBox.Text + " " +
                     dayOfMonthTextBox.Text + ", " +
                     yearTextBox.Text;

            //Display the outpu string in the lable control.
            dateOuputLabel.Text = output;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            //Clear the TextBoxes.
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";

            // Clear the dateOutputLable control.
            dateOuputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
