using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic1Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double inputTime;
                double outputTime;

                inputTime = int.Parse(userInputBox.Text);

                if (inputTime < 60)
                {
                    MessageBox.Show("Invalid entry, input time must be greater than 59 seconds.");
                }

                if (inputTime >= 60)
                {
                    outputTime = inputTime / 60;
                    outputTextBox.Text = (outputTime.ToString("n3") + " minute/s");
                }

                if (inputTime >= 3600)
                {
                    outputTime = inputTime / 3600;
                    outputTextBox.Text = (outputTime.ToString("n3") + " hour/s");
                }

                if (inputTime >= 86400)
                {
                    outputTime = inputTime / 86400;
                    outputTextBox.Text = (outputTime.ToString("n3") + " day/s");
                }
            }
            catch
            {
                //Display an error message. 
                MessageBox.Show("Invalid data input for program."); 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
