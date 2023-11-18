using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Programmer: Sean Herbert
// Project Lab 1-1
// Date 22 September 2020
// Description: Displays a greeting to user

namespace Lab_1_1
{
    public partial class FirstProject : Form
    {
        public FirstProject()
        {
            InitializeComponent();
        }

        private void instructionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void greetingButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, " + firstNameTextBox.Text + "! Welcome to my program!");
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
