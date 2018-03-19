using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Problems
{
    public partial class Form1 : Form
    {
        // Constant fields    
        const decimal TIP_PERCENT  =15;
        const decimal SALES_TAX_PERCENT = 7;
       


        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton1_Click(object sender, EventArgs e)
        {
            decimal foodCostAmount;
            decimal salesTaxAmount;
            decimal tipAmount;
            decimal totalAmount;

            if (inputAmountTextBox.Text != null 
                && inputAmountTextBox.Text != "")
            {
                // Assigns food cost from textbox control to variables
                foodCostAmount = decimal.Parse(inputAmountTextBox.Text);

                // Calculate the tip amount at 15 %
                tipAmount = TIP_PERCENT * (foodCostAmount / 100);

                // Calculate sales tax amount
                salesTaxAmount = SALES_TAX_PERCENT * (foodCostAmount / 100);

                // Calculate total amount
                totalAmount = (foodCostAmount + tipAmount + salesTaxAmount);

                //Display the tip ammount 
                outputLable.Text = "Cost of the meal:" + foodCostAmount.ToString("c");

;
            
                
                


            }
        }
    }
}
