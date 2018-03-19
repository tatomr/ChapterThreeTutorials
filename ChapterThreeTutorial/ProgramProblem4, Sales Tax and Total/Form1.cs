using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramProblem4__Sales_Tax_and_Total
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears all input and output lables
            inputAmountTextBox.Text = "";
            outputStateTaxTextBox.Text = "";
            outputCountyTaxTextBox.Text = "";
            outputTotalTaxTextBox.Text = "";
            outputTotalSalestTextBox.Text = "";
        }

        private void calculateTotalbutton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal purchaseAmount;
                decimal stateTax;
                decimal countyTax;
                decimal totalTax;
                decimal totalSales;
               

                // Get purchase amount from Textbox 
                purchaseAmount = decimal.Parse(inputAmountTextBox.Text);

                // Calculate state & local sales tax at 4 and 2% repectivly, and total sales tax and grandtotal sales
                stateTax = purchaseAmount * 0.04m;
                countyTax = purchaseAmount * 0.02m;
                totalTax = stateTax + countyTax;
                totalSales = purchaseAmount + stateTax + countyTax;
                    
                //Display the state, local tax amount and total tax and gradtotal ammount 
                outputStateTaxTextBox.Text = stateTax.ToString("c");
                outputCountyTaxTextBox.Text = countyTax.ToString("c");
                outputTotalTaxTextBox.Text = totalTax.ToString("c");
                outputTotalSalestTextBox.Text = totalSales.ToString("c");
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
