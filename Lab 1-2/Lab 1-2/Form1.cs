using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void instructionLabel_Click(object sender, EventArgs e)
        {

        }

        private void fallButton_Click(object sender, EventArgs e)
        {
            seasonsPictureBox.Image = Lab_1_2.Properties.Resources.Fall;
        }

        private void winterButton_Click(object sender, EventArgs e)
        {
            seasonsPictureBox.Image = Lab_1_2.Properties.Resources.Winter;
        }

        private void springButton_Click(object sender, EventArgs e)
        {
            seasonsPictureBox.Image = Lab_1_2.Properties.Resources.Spring;
        }

        private void summerButton_Click(object sender, EventArgs e)
        {
            seasonsPictureBox.Image = Lab_1_2.Properties.Resources.Summer;
        }

        private void seasonsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
