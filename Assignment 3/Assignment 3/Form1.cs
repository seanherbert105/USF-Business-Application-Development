using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_3
{
    public partial class bonnieBallonsForm : Form
    {
        private double subtotal2;
        private double salesTax2;
        private double overallTotal2;
        private double add;

        private double single = 9.95;
        private double halfDozen = 35.95;
        private double dozen = 65.95;
        private double delivery = 7.50;
        private double personalMessage = 2.50;
        private double extras = 9.50;
        private double taxRate = 0.07;

        public bonnieBallonsForm()
        {
            InitializeComponent();
            deliveryDateMasked.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void PopulateBoxes()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("occassion.txt");
                specialOccassionCombo.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    specialOccassionCombo.Items.Add(inputFile.ReadLine());
                }

                inputFile.Close();

                specialOccassionCombo.SelectedItem = "Birthday";

                inputFile = File.OpenText("extras.txt");
                specialExtrasList.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    specialExtrasList.Items.Add(inputFile.ReadLine());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void ResetForms()
        {
            deliveryDateMasked.Text = DateTime.Now.ToString("MM/dd/yyyy");

            titleCombo.Text = " ";
            firstNameTextBox.Text = " ";
            lastNameTextBox.Text = " ";
            addressTextBox.Text = " ";
            cityTextBox.Text = " ";
            stateTextBox.Text = " ";
            zipTextBox.Text = " ";
            phoneNumberMasked.Text = " ";
            deliveryDateMasked.Text = " ";
            deliveryPrice.Text = " ";
            ballonSizePrice.Text = " ";
            specialOccassionCombo.Text = " ";
            specialExtrasList.Text = " ";
            specialExtrasPrice.Text = " ";
            personalMessagePrice.Text = " ";
            personalMessageTextBox.Text = " ";
            subtotal.Text = " ";
            salesTax.Text = " ";
            orderTotal.Text = " ";

            storeRadioButton.Checked = true;
            deliveryRadioButton.Checked = false;
            singleRadioButton.Checked = true;
            halfDozenRadioButton.Checked = false;
            dozenRadioButton.Checked = false;
            personalMessageCheckBox.Checked = false;

            specialExtrasList.ClearSelected();
            
            titleCombo.Text = string.Empty;
            specialExtrasList.Text = string.Empty;
            specialOccassionCombo.Text = string.Empty;
        }

        private void UpdateTotals()
        {
            int extracount = 0;
            double add = 0;

            if (deliveryRadioButton.Checked == true)
            {
                delivery = 7.50;
                deliveryPrice.Text = "$" + delivery.ToString();
            }
            if (storeRadioButton.Checked == true)
            {
                delivery = 0;
                deliveryPrice.Text = null;
            }


            if (singleRadioButton.Checked == true)
            {
                single = 9.95;
                halfDozen = 0;
                dozen = 0;
                ballonSizePrice.Text = "$" + single.ToString();
            }
            if (singleRadioButton.Checked == false)
            {
                single = 0;
            }
            if (halfDozenRadioButton.Checked == true)
            {
                single = 0;
                halfDozen = 35.95;
                dozen = 0;
                ballonSizePrice.Text = "$" + halfDozen.ToString();
            }
            if (halfDozenRadioButton.Checked == false)
            {
                halfDozen = 0;
            }
            if (dozenRadioButton.Checked == true)
            {
                single = 0;
                halfDozen = 0;
                dozen = 65.95;
                ballonSizePrice.Text = "$" + dozen.ToString();
            }
            if (dozenRadioButton.Checked == false)
            {
                dozen = 0;
            }


            if (personalMessageCheckBox.Checked == true)
            {
                personalMessage = 2.50;
                personalMessagePrice.Text = "$" + personalMessage.ToString();
            }
            if (personalMessageCheckBox.Checked == false)
            {
                personalMessage = 0;
                personalMessagePrice.Text = null;
            }


            for (int count = 0; count < specialExtrasList.Items.Count; count ++)
            {
                if (specialExtrasList.GetSelected(count) == true)
                {
                    extracount++;
                }
            }

            if (specialExtrasList.Text == string.Empty)
            {
                extras = 0;
                specialExtrasPrice.Text = null;
            }
            else
            {
                extras = 9.50 * extracount;
                specialExtrasPrice.Text = "$" + extras.ToString();
            }

            add = extracount * extras;
            subtotal2 = single + halfDozen + dozen + personalMessage + delivery + extras;
            salesTax2 = subtotal2 * taxRate;
            overallTotal2 = subtotal2 + salesTax2;

            subtotal.Text = subtotal2.ToString("c");
            salesTax.Text = salesTax2.ToString("c");
            orderTotal.Text = overallTotal2.ToString("c");
        }

        private void bonnieBallonsForm_Load(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void deliveryPrice_Click_1(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void ballonSizePrice_Click(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void personalMessagePrice_Click(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void subtotal_Click(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void salesTax_Click(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void orderTotal_Click(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void specialExtrasPrice_Click(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            UpdateTotals();
            try
            {
                string storePickUp = Convert.ToString(storeRadioButton.Checked == true);
                storePickUp = "Store Pick-Up";
                if(storeRadioButton.Checked == false)
                {
                    storePickUp = null;
                }

                string homeDelivery = Convert.ToString(deliveryRadioButton.Checked == true);
                homeDelivery = "Home Delivery";
                if(deliveryRadioButton.Checked == false)
                {
                    homeDelivery = null;
                }


                string personalMessage = Convert.ToString(personalMessageCheckBox.Checked == true);
                personalMessage = personalMessageTextBox.Text + personalMessagePrice.Text;
                if(personalMessageCheckBox.Checked == false)
                {
                    personalMessage = null;
                }


                string single = Convert.ToString(singleRadioButton.Checked == true);
                single = "Single Ballon";
                if(singleRadioButton.Checked == false)
                {
                    single = null;
                }

                string halfDozen = Convert.ToString(halfDozenRadioButton.Checked == true);
                halfDozen = "Half-Dozen Ballons";
                if(halfDozenRadioButton.Checked == false)
                {
                    halfDozen = null;
                }

                string dozen = Convert.ToString(dozenRadioButton.Checked == true);
                dozen = "Dozen Ballons";
                if(dozenRadioButton.Checked == false)
                {
                    dozen = null;
                }

                MessageBox.Show
                (titleCombo.Text + "  " + firstNameTextBox.Text + "  " + lastNameTextBox.Text + Environment.NewLine +
                addressTextBox.Text + "  " + cityTextBox.Text + "  " + stateTextBox.Text + "  " + zipTextBox.Text + Environment.NewLine +
                phoneNumberMasked.Text + Environment.NewLine +
                "Delivery Date of:  " + deliveryDateMasked.Text + "  " + storePickUp + homeDelivery + Environment.NewLine +
                "Your additional charge for delivery is:  " + "$" + deliveryPrice.Text + Environment.NewLine +
                "$" + single + halfDozen + dozen + "  " + ballonSizePrice.Text + "  " + Environment.NewLine + 
                specialOccassionCombo.Text + Environment.NewLine +
                specialExtrasList.Text + Environment.NewLine +
                personalMessageTextBox.Text + Environment.NewLine +
                "Your additional charge for the personal message is:  " + personalMessagePrice.Text + Environment.NewLine +
                "Your subtotal is:  " + subtotal.Text + Environment.NewLine +
                "Your sales tax is:  " + salesTax.Text + Environment.NewLine +
                "Your total is:  " + orderTotal.Text
                );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetForms();
            titleCombo.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult selection;
            selection = MessageBox.Show("Are you sure that you want to close this application?", "Confirmation", MessageBoxButtons.YesNo);

            if (selection == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
