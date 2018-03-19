using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Price_Calculator
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;      // The Item's Original Price
            decimal discountPercentage; // The discount percentage
            decimal discountAmount;     // The ammount of discount
            decimal salesPrice;         // The item's sale price

            //Get the item's original price.
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            
            //Get the discount percentage.
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            //Move the percentage's decimal point left two spaces.
            discountPercentage = discountPercentage / 100;

            //Calcualte the amount of the discount.
            discountAmount = originalPrice * discountPercentage;

            //Calculate the sale price. 
            salesPrice = originalPrice - discountAmount;

            //Display the sale price.
            salePriceLabel.Text = salesPrice.ToString("c");


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form.
            this.Close();
        }
    }
}
