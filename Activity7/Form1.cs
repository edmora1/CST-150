using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int inputVal = int.Parse(inputTextBox.Text);
            double pi = 4;
            double number = 4;
            double divider = 3; 

            for (int i = 0; i <= inputVal; i++)
            {
                if (i % 2 == 0)
                {
                    pi -= number / divider; 
                }
                else
                {
                    pi += number / divider;
                }
                divider += 2; 
            }
            reflectTextBox.Text = "Approximate value of pi after " + inputVal + " terms";
            resultTextBox.Text = "= " + pi; 
        }
    }
}
