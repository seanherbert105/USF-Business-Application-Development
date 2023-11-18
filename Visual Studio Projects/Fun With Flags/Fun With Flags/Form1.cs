using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun_With_Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ResultsLabel.Text = "United States";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ResultsLabel.Text = "Mexico";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ResultsLabel.Text = "Canada";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultsLabel.Text = " ";
        }

        private void FlagLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResultsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
