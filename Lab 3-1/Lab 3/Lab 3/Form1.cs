// Programmer: Sean Herbert
// Project: Lab 3-1
// Date: 26 October 2020
// Description: Form for taking a pet care order.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class petBoutique : Form
    {

        double fleaRemoval = 5.00;
        double shampoo = 4.00;
        double nailClipping = 4.50;
        double furTrimming = 9.00;

        public petBoutique()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            double total;

            if (fleaRemovalCheckBox.Checked == true)
            {
                fleaRemoval = 5.00;
                totalResultLabel.Text = "$" + fleaRemoval.ToString();
            }
            if (fleaRemovalCheckBox.Checked == false)
            {
                fleaRemoval = 0.00;
                fleaRemovalLabel.Text = " ";
            }

            if (shampooCheckBox.Checked == true)
            {
                shampoo = 4.00;
                totalResultLabel.Text = "$" + shampoo.ToString();
            }
            if (shampooCheckBox.Checked == false)
            {
                shampoo = 0.00;
                shampooLabel.Text = " ";
            }

            if (nailClippingCheckBox.Checked == true)
            {
                nailClipping = 4.50;
                totalResultLabel.Text = "$" + nailClipping.ToString();
            }
            if (nailClippingCheckBox.Checked == false)
            {
                nailClipping = 0.00;
                nailClippingLabel.Text = " ";
            }

            if (furTrimmingCheckBox.Checked == true)
            {
                furTrimming = 9.00;
                totalResultLabel.Text = "$" + furTrimming.ToString();
            }
            if (furTrimmingCheckBox.Checked == false)
            {
                furTrimming = 0.00;
                furTrimmingLabel.Text = " ";
            }

            total = fleaRemoval + shampoo + nailClipping + furTrimming;
            totalResultLabel.Text = "$" + total.ToString();

            clearButton.Focus();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            double fleaRemoval = 5.00;
            double shampoo = 4.00;
            double nailClipping = 4.50;
            double furTrimming = 9.00;

            ownerNameTextBox.Text = " ";
            orderPhoneTextBox.Text = " ";
            petNameTextBox.Text = " ";
            petDOBTextBox.Text = " ";
            typeTextBox.Text = " ";
            fleaRemovalLabel.Text = "$" + fleaRemoval.ToString();
            shampooLabel.Text = "$" + shampoo.ToString();
            nailClippingLabel.Text = "$" + nailClipping.ToString();
            furTrimmingLabel.Text = "$" + furTrimming.ToString();
            totalResultLabel.Text = " ";
            dogRadioButton.Checked = false;
            otherRadioButton.Checked = false;
            fleaRemovalCheckBox.Checked = false;
            shampooCheckBox.Checked = false;
            nailClippingCheckBox.Checked = false;
            furTrimmingCheckBox.Checked = false;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ownerNameTextBox.Focus();
        }

        private void otherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (otherRadioButton.Checked == true)
            {
                typeLabel.Enabled = true;
                typeTextBox.Enabled = true;
                typeTextBox.Focus();
            }
            if (otherRadioButton.Checked == false)
            {
                typeLabel.Enabled = false;
                typeTextBox.Enabled = false;
                typeTextBox.Text = " ";
            }
        }

        private void fleaRemovalLabel_Click(object sender, EventArgs e)
        {

        }

        private void shampooLabel_Click(object sender, EventArgs e)
        {

        }

        private void nailClippingLabel_Click(object sender, EventArgs e)
        {

        }

        private void furTrimmingLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalResultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
