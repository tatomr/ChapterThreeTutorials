using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramProblem3
{
    public partial class Form1 : Form
    {
        decimal distance;
        decimal speed;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void fiveHourbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //get the car speed entered from the speedTextbox 
                speed = decimal.Parse(speedTextBox1.Text);

                //Calculate the distance traveled in 5 hours
                distance = speed * 5;

                //Display the distance in the distance traveled textbox
                distanceTraveledTextBox.Text = distance.ToString("n");
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show(ex.Message);
            }
        }

        private void fiveHourLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the speed and distance textbox
            speedTextBox1.Text = "";
            distanceTraveledTextBox.Text = "";
        }

        private void eightHourbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //get the car speed entered from the speedTextbox 
                speed = decimal.Parse(speedTextBox1.Text);

                //Calculate the distance traveled in 8 hours
                distance = speed * 8;

                //Display the distance in the distance traveled textbox
                distanceTraveledTextBox.Text = distance.ToString("n");
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show(ex.Message);
            }
        }

        private void twelveHourButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get the car speed entered from the speedTextbox 
                speed = decimal.Parse(speedTextBox1.Text);

                //Calculate the distance traveled in 12 hours
                distance = speed * 12;

                //Display the distance in the distance traveled textbox
                distanceTraveledTextBox.Text = distance.ToString("n");
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
