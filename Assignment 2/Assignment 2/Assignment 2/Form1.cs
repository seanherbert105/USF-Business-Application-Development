// Programmer: Sean Herbert
// Project: Assignment 2
// Due Date: 20 October 2020
// Description: Individual Assignment 2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class languageArtsInstitute : Form
    {

        const double inStateCharge = 49.00;
        const double outOfStateCharge = 99.00;

        public languageArtsInstitute()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string fall = Convert.ToString(fallRadioButton.Checked == true);
            fall = "Fall";
            if (fallRadioButton.Checked == false)
            {
                fall = null;
            }
            string summer = Convert.ToString(summerRadioButton.Checked == true);
            summer = "Summer";
            if (summerRadioButton.Checked == false)
            {
                summer = null;
            }
            string spring = Convert.ToString(springRadioButton.Checked == true);
            spring = "Spring";
            if (springRadioButton.Checked == false)
            {
                spring = null;
            }
            string inState = Convert.ToString(inStateRadioButton.Checked == true);
            inState = "$49.00";
            if (inStateRadioButton.Checked == false)
            {
                inState = null;
            }
            string outOfState = Convert.ToString(outOfStateRadioButton.Checked == true);
            outOfState = "$99.00";
            if (outOfStateRadioButton.Checked == false)
            {
                outOfState = null;
            }
            string masterCard = Convert.ToString(mastercardRadioButton.Checked == true);
            masterCard = "Master Card";
            if (mastercardRadioButton.Checked == false)
            {
                masterCard = null;
            }
            string visa = Convert.ToString(visaRadioButton.Checked == true);
            visa = "Visa";
            if (visaRadioButton.Checked == false)
            {
                visa = null;
            }

            MessageBox.Show(studentIDTextBox.Text + Environment.NewLine +
            firstNameTextBox.Text + " " + lastNameTextBox.Text + Environment.NewLine +
            emailTextBox.Text + Environment.NewLine +
            "You will be attending during: " + fall + summer + spring + " " + semesterYearComboBox.Text + Environment.NewLine +
            "Your Total is: $" + totalCharge.Text + " " + "Courses taken: " + totalCourse.Text + Environment.NewLine + 
            "At the rate of: $" + inState + outOfState + " " + "per course" + Environment.NewLine +
            "Your credit card used will be: " + masterCard + visa + " " + creditCardTextBox.Text + " " + expirationDateTextBox.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = " ";
            lastNameTextBox.Text = " ";
            studentIDTextBox.Text = " ";
            emailTextBox.Text = " ";
            semesterYearComboBox.Text = " ";
            creditCardTextBox.Text = " ";
            expirationDateTextBox.Text = " ";
            totalCharge.Text = "$";
            totalCourse.Text = " ";
            frenchCheckBox.Checked = false;
            germanCheckBox.Checked = false;
            italianCheckBox.Checked = false;
            russianCheckBox.Checked = false;
            spanishCheckBox.Checked = false;
            inStateRadioButton.Checked = false;
            outOfStateRadioButton.Checked = false;
            mastercardRadioButton.Checked = true;
            visaRadioButton.Checked = false;
            fallRadioButton.Checked = true;
            summerRadioButton.Checked = false;
            springRadioButton.Checked = false;


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            
            result = MessageBox.Show("Do you wish to quit? " + MessageBoxButtons.YesNo + MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void studentIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalCharge_Click(object sender, EventArgs e)
        {

        }

        private void totalChargeButton_Click(object sender, EventArgs e)
        {
            double inStateTotal;
            double outOfStateTotal;
            double french = 0;
            double german = 0;
            double italian = 0;
            double russian = 0;
            double spanish = 0;
            double frenchInState = Convert.ToDouble(frenchCheckBox.Checked);
            double frenchOutOfState = Convert.ToDouble(frenchCheckBox.Checked);
            double germanInState = Convert.ToDouble(germanCheckBox.Checked);
            double germanOutOfState = Convert.ToDouble(germanCheckBox.Checked);
            double italianInState = Convert.ToDouble(italianCheckBox.Checked);
            double italianOutOfState = Convert.ToDouble(italianCheckBox.Checked);
            double russianInState = Convert.ToDouble(russianCheckBox.Checked);
            double russianOutOfState = Convert.ToDouble(russianCheckBox.Checked);
            double spanishInState = Convert.ToDouble(spanishCheckBox.Checked);
            double spanishOutOfState = Convert.ToDouble(spanishCheckBox.Checked);

            if (frenchCheckBox.Checked)
            {
                french = 1;
            }
            if (germanCheckBox.Checked)
            {
                german = 1;
            }
            if (italianCheckBox.Checked)
            {
                italian = 1;
            }
            if (russianCheckBox.Checked)
            {
                russian = 1;
            }
            if (spanishCheckBox.Checked)
            {
                spanish = 1;
            }

            double maxValue = french + german + italian + russian + spanish;

            if (maxValue > 3)
            {
                MessageBox.Show("You have choosen to many courses to purchase");
                totalCharge.Text = "$";
                totalCourse.Text = " ";
            }

            if (inStateRadioButton.Checked == true || outOfStateRadioButton.Checked == false)
            {
                inStateTotal = (frenchInState + germanInState + italianInState + russianInState + spanishInState) * inStateCharge;
                totalCharge.Text = "$" + inStateTotal.ToString();
            }
            if (inStateRadioButton.Checked == false || outOfStateRadioButton.Checked == true)
            {
                outOfStateTotal = (frenchOutOfState + germanOutOfState + italianOutOfState + russianOutOfState + spanishOutOfState) * outOfStateCharge;
                totalCharge.Text = "$" + outOfStateTotal.ToString();
            }
            if (inStateRadioButton.Checked == false && outOfStateRadioButton.Checked == false)
            {
                MessageBox.Show("Choose an In-State or Out-of-State Option");
                totalCharge.Text = "$";
                totalCourse.Text = " ";
            }
        }

        private void totalCourse_Click(object sender, EventArgs e)
        {

        }

        private void totalCourseButton_Click(object sender, EventArgs e)
        {
            double total;
            double maxValue;
            double french;
            double german;
            double italian;
            double russian;
            double spanish;

            if (frenchCheckBox.Checked)
            {
                french = 1;

            }
            else
            {
                french = 0;
            }
            if (germanCheckBox.Checked)
            {
                german = 1;
            }
            else
            {
                german = 0;
            }
            if (italianCheckBox.Checked)
            {
                italian = 1;
            }
            else
            {
                italian = 0;
            }
            if (russianCheckBox.Checked)
            {
                russian = 1;
            }
            else
            {
                russian = 0;
            }
            if (spanishCheckBox.Checked)
            {
                spanish = 1;
            }
            else
            {
                spanish = 0;
            }

            maxValue = french + german + italian + russian + spanish;

            if (maxValue > 3)
            {
                MessageBox.Show("You have choosen to many courses to purchase");
                totalCharge.Text = "$";
                totalCourse.Text = " ";
            }

            if (maxValue == 0)
            {
                MessageBox.Show("You have to purchase at least one course");
                totalCharge.Text = "$";
                totalCourse.Text = " ";
            }

            if (inStateRadioButton.Checked == false && outOfStateRadioButton.Checked == false)
            {
                MessageBox.Show("Choose an In-State or Out-of-State Option");
                totalCharge.Text = "$";
                totalCourse.Text = " ";
            }

            total = french + german + italian + russian + spanish;
            totalCourse.Text = total.ToString();
        }

        private void inStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (inStateRadioButton.Checked)
            {
                totalCharge.Text = "The cost per course In-State is going to be $49.00";
            }
            else
            {
                totalCharge.Text = "$";
            }
        }

        private void outOfStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (outOfStateRadioButton.Checked)
            {
                totalCharge.Text = "The cost per course Out-of-State is going to be $99.00";
            }
            else
            {
                totalCharge.Text = "$";
            }
        }
    }
}
           