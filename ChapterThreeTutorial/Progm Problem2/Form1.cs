using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progm_Problem2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal foodCost;
                decimal salesTax;
                decimal tip;
                decimal total;

                // Get amount charged from Textbox 
                foodCost = decimal.Parse(inputChargeAmountBox.Text);

                // Calculate sales tax at 7%, the tip amount at 15%, and total cost
                tip = foodCost * 0.15m;
                salesTax = foodCost * 0.07m;
                total = foodCost + tip + salesTax;

                //Display the tip, tax and total ammount 
                tipTextBox.Text = tip.ToString("c");
                taxTextBox.Text = salesTax.ToString("c");
                totalTextBox.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
