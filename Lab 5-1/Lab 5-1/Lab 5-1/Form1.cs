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

namespace Lab_5_1
{
    public partial class joeIceCreamForm : Form
    {
        public joeIceCreamForm()
        {
            InitializeComponent();
        }

        private void PopulateBoxes()
        {
            try
            {
                StreamReader inputFile;

                inputFile = File.OpenText("Flavors.txt");
                while (!inputFile.EndOfStream)
                {
                    iceCreamFlavorComboBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();

                inputFile = File.OpenText("Toppings.txt");
                while (!inputFile.EndOfStream)
                {
                    toppingsListBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void CloseProgram()
        {
            MessageBox.Show("Do you wish to close the program? " + MessageBoxButtons.YesNo);
            this.Close();
        }

        private void joeIceCreamForm_Load(object sender, EventArgs e)
        {
            PopulateBoxes();
            iceCreamFlavorComboBox.SelectedItem = "Vanilla";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;

                outputFile = File.AppendText("Orders.txt");
                outputFile.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));

                outputFile.WriteLine("The ice cream cone type you have choosen:  ");
                if (sugarConeRadioButton.Checked == true)
                {
                    outputFile.WriteLine("Sugar Cone" + Environment.NewLine);
                }
                if (waffleConeRadioButton.Checked == true)
                {
                    outputFile.WriteLine("Waffle Cone" + Environment.NewLine);
                }
                
                outputFile.WriteLine("The ice cream flavor you have choosen:  " + Environment.NewLine + iceCreamFlavorComboBox.SelectedItem.ToString() + Environment.NewLine);
                for (int count = 0; count < toppingsListBox.Items.Count; count ++)
                {
                    if (toppingsListBox.GetSelected(count))
                    {
                        outputFile.WriteLine("The toppings you have choosen:  " + Environment.NewLine + toppingsListBox.Items[count]);
                    }
                }

                outputFile.WriteLine();
                outputFile.Close();
                MessageBox.Show("Your order has been sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            CloseProgram();
        }
    }
}
