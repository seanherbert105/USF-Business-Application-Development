// Programmer: Sean Herbert
// Project: Assignment 1
// Due Date: 28 September 2020
// Description: Individual Assignment 1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class motorwayMotel : Form
    {
        // These are our globally fixed variables that are found within other methods of the program

        const double dailyRate = 50.00;
        const double taxrate = 0.07;
        double total = 0;
                
        public motorwayMotel()
        {
            InitializeComponent();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void titlePicture_Click(object sender, EventArgs e)
        {

        }

        private void checkOutLabel_Click(object sender, EventArgs e)
        {

        }

        private void guestCheckOut_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void roomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void billingGroup_Enter(object sender, EventArgs e)
        {

        }
        private void nightsStayedLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void nightsStayedNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void additionalChargesLabel_Click(object sender, EventArgs e)
        {

        }

        private void miniBarLabel_Click(object sender, EventArgs e)
        {

        }

        private void miniBarCosts_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void telephoneCosts_TextChanged(object sender, EventArgs e)
        {

        }

        private void miscellaneousLabel_Click(object sender, EventArgs e)
        {

        }

        private void miscellaneousCosts_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalsGroup_Enter(object sender, EventArgs e)
        {

        }

        private void roomCharges_Click(object sender, EventArgs e)
        {

        }

        private void roomPrice_Click(object sender, EventArgs e)
        {

        }

        private void additionalCharges_Click(object sender, EventArgs e)
        {

        }

        private void additionalPrice_Click(object sender, EventArgs e)
        {

        }

        private void subtotalCharges_Click(object sender, EventArgs e)
        {

        }

        private void subtotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void taxAmount_Click(object sender, EventArgs e)
        {

        }

        private void taxCharge_Click(object sender, EventArgs e)
        {

        }
        private void totalPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalPrice_Click(object sender, EventArgs e)
        {

        }


        // These are the instructions to give the operator of the web form app in case they get lost

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "1. Enter in customer check out date" + Environment.NewLine + "2. Type in your first and last name" + Environment.NewLine + 
                "3. Select customers room number" + Environment.NewLine + "4. Move the arrow up or down on the nights stayed to determine customer rate" + Environment.NewLine + 
                "5. Enter in the minibar, telephone, and miscellaneous costs the customer accued." + Environment.NewLine + 
                "6. Your Total Button to reveal Room Total, Additonal Total (minibar, telephone, and miscellaneous), Subtotal, Tax Total, and Overall Total" + Environment.NewLine +
                "7. Hit the Clear Button to remove any previous information" + Environment.NewLine + "8. Hit Exit to leave the program");
        }

        // This calculates the total in a message box 

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                int nightsStayed;
                double minibar;
                double telephone;
                double miscellaneous;
                double totalTax;
                double overall;
                
                // Room Total Label

                nightsStayed = (int)nightsStayedNumber.Value;
                total = (dailyRate * nightsStayed) * taxrate;
                totalTax = (dailyRate * nightsStayed) + total;
                overall = totalTax + (nightsStayed * dailyRate);
                roomPrice.Text = overall.ToString();
                
                // Additional Total Label

                minibar = double.Parse(miniBarCosts.Text);
                total = minibar * taxrate;
                totalTax = minibar + total;
                overall = totalTax + minibar;
                additionalPrice.Text = overall.ToString();
                
                // Additional Total Label

                telephone = double.Parse(telephoneCosts.Text);
                total = telephone * taxrate;
                totalTax = telephone + total;
                overall = totalTax + telephone;
                additionalPrice.Text = overall.ToString();

                // Additional Total Label

                miscellaneous = double.Parse(miscellaneousCosts.Text);
                total = miscellaneous * taxrate;
                totalTax = miscellaneous + total;
                overall = totalTax + miscellaneous;
                additionalPrice.Text = overall.ToString();

                // Subtotal Label

                total = (nightsStayed * dailyRate) + minibar + telephone + miscellaneous;
                subtotalPrice.Text = total.ToString();

                // Tax Total Label

                total = (minibar + telephone + miscellaneous) + (nightsStayed * dailyRate) * taxrate;
                taxCharge.Text = total.ToString();

                // Total Label

                total = (dailyRate * nightsStayed) + (minibar + telephone + miscellaneous) * taxrate;
                totalTax = (nightsStayed * dailyRate) + (minibar + telephone + miscellaneous) + total;
                overall = totalTax + (minibar + miscellaneous) + (nightsStayed * dailyRate);
                totalPrice.Text = overall.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Error! Numbers Only");
            }
            clearButton.Focus();
        }

        // This clear all information out of the web form app

        private void clearButton_Click(object sender, EventArgs e)
        {
            totalPrice.Text = " ";
            miniBarCosts.Text = " ";
            telephoneCosts.Text = " ";
            miscellaneousCosts.Text = " ";
            roomPrice.Text = " ";
            additionalPrice.Text = " ";
            subtotalPrice.Text = " ";
            taxCharge.Text = " ";
            guestCheckOut.Text = " ";
            nightsStayedNumber.Value = 0;
            total = 0;
            firstName.Focus();
        }            

// This closes the web form app

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
