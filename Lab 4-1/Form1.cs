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

namespace Lab_4_1
{
    public partial class realEstateCalculator : Form
    {

        const double salesTax = 0.06;
        const double hillsborough = 0.01;
        const double pasco = 0.00;
        const double polk = 0.005;
        const double residental = 0.06;
        const double commercial = 0.05;

        public realEstateCalculator()
        {
            InitializeComponent();
        }

        private void OverallTotal()
        {
            double total;
            double propertyPrice = Convert.ToDouble(propertyPriceTextBox.Text);

            total = propertyPrice * salesTax;
            stateSalesTax.Text = "$" + total.ToString();

            if (hillsboroughRadioButton.Checked)
            {
                total = propertyPrice * hillsborough;
                countySalesTax.Text = "$" + total.ToString();
            }
            else if (pascoRadioButton.Checked)
            {
                total = propertyPrice * pasco;
                countySalesTax.Text = "$" + total.ToString();
            }
            else if (polkRadioButton.Checked)
            {
                total = propertyPrice * polk;
                countySalesTax.Text = "$" + total.ToString();
            }

            if (residentalRadioButton.Checked)
            {
                total = propertyPrice * residental;
                commission.Text = "$" + total.ToString();
            }
            else if (commercialRadioButton.Checked)
            {
                total = propertyPrice * commercial;
                commission.Text = "$" + total.ToString();
            }

            double overall;
            double totalStateTax = Convert.ToDouble(stateSalesTax.Text);
            double totalCountyTax = Convert.ToDouble(countySalesTax.Text);
            double totalCommission = Convert.ToDouble(commission.Text);

            overall = propertyPrice + totalStateTax + totalCountyTax + totalCommission;
            totalPrice.Text = "$" + overall.ToString();
            saveButton.Focus();
        }

        private void Save()
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText("Properties.txt");

                outputFile.WriteLine("Date:  " + dateTextBox.Text);
                outputFile.WriteLine("Property Price:  " + propertyPriceTextBox.Text);
                outputFile.WriteLine("State Sales Tax:  " + stateSalesTax.Text);
                outputFile.WriteLine("County Sales Tax:  " + countySalesTax.Text);
                outputFile.WriteLine("Commission:  " + commission.Text);
                outputFile.WriteLine("Total Price:  " + totalPrice.Text);
                outputFile.WriteLine();
                outputFile.Close();

                MessageBox.Show("File Successfully Created", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            dateTextBox.Text = " ";
            propertyPriceTextBox.Text = "0.00";
            stateSalesTax.Text = "$0.00";
            countySalesTax.Text = "$0.00";
            commission.Text = "$0.00";
            totalPrice.Text = "$0.00";
            residentalRadioButton.Checked = true;
            commercialRadioButton.Checked = false;
            hillsboroughRadioButton.Checked = true;
            pascoRadioButton.Checked = false;
            polkRadioButton.Checked = false;
        }

        private void realEstateCalculator_Load(object sender, EventArgs e)
        {
            dateTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            saveButton.Enabled = false;
        }
        private void dateTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void propertyPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            OverallTotal();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
