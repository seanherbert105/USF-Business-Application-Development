// Programmer: Sean Herbert
// Project: Lab 2-1
// Date: 07 October 2020
// Description: Form for taking a carpet order

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_1
{
    public partial class Form1 : Form
    {
        const double taxRate = 0.07;
        const double laborRate = 0.05;

        public Form1()
        {
            InitializeComponent();
        }

        private void carpetCalculator_Click(object sender, EventArgs e)
        {

        }

        private void carpetLengthLabel_Click(object sender, EventArgs e)
        {

        }

        private void carpetWidthLabel_Click(object sender, EventArgs e)
        {

        }

        private void carpetPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void carpetLengthText_TextChanged(object sender, EventArgs e)
        {

        }

        private void carpetWidthText_TextChanged(object sender, EventArgs e)
        {

        }

        private void carpetPriceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void carpetAreaLabel_Click(object sender, EventArgs e)
        {

        }

        private void carpetAreaBlank_Click(object sender, EventArgs e)
        {

        }

        private void carpetChargeLabel_Click(object sender, EventArgs e)
        {

        }

        private void carpetChargeBlank_Click(object sender, EventArgs e)
        {

        }

        private void salesTaxLabel_Click(object sender, EventArgs e)
        {

        }

        private void salesTaxBlank_Click(object sender, EventArgs e)
        {

        }

        private void laborChargeLabel_Click(object sender, EventArgs e)
        {

        }

        private void laborChargeBlank_Click(object sender, EventArgs e)
        {

        }

        private void orderTotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void orderTotalBlank_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double total;
                double squareFeet;
                double carpet;
                double salesTax;
                double labor; 
                double carpetLength = double.Parse(carpetLengthText.Text);
                double carpetWidth = double.Parse(carpetWidthText.Text);
                double carpetPrice = double.Parse(carpetPriceText.Text);

                // calculates carpet square feet
                squareFeet = carpetLength * carpetWidth;
                carpetAreaBlank.Text = squareFeet.ToString();

                // calculates the carpet charge (no tax, no labor)
                carpet = squareFeet * carpetPrice;
                carpetChargeBlank.Text = carpet.ToString();

                // calculate the sales tax
                salesTax = carpet * taxRate;
                salesTaxBlank.Text = salesTax.ToString();

                // calculate the labor charge
                labor = carpet * laborRate;
                laborChargeBlank.Text = labor.ToString();

                // calculates the overall total (carpet charge, sales tax, labor charge)
                total = carpet + salesTax + labor;
                orderTotalBlank.Text = total.ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Error! Numbers Only");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            orderTotalBlank.Text = " ";
            laborChargeBlank.Text = " ";
            salesTaxBlank.Text = " ";
            carpetAreaBlank.Text = " ";
            carpetChargeBlank.Text = " ";
            carpetPriceText.Text = " ";
            carpetWidthText.Text = " ";
            carpetLengthText.Text = " ";
            carpetLengthText.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void divider1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void divider2_Enter(object sender, EventArgs e)
        {

        }
    }
}
