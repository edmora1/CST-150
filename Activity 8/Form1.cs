using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double fatCal, carbCal;
            int userFat, userCarb;

            userFat = int.Parse(fatInput.Text);
            userCarb = int.Parse(carbInput.Text);

            fatCal = FatCalories(userFat);
            carbCal = CarbCalories(userCarb);

            MessageBox.Show("Your calories from fat are: " + fatCal + "\n" + "Your calories from carbohydrates are: " + carbCal + "\n");
        }
            public double FatCalories(int gramsFat)
            {
                gramsFat = int.Parse(fatInput.Text);

                return gramsFat * 9;

            }
            public double CarbCalories(int gramsCarbs)
            {
                gramsCarbs = int.Parse(carbInput.Text);

                return gramsCarbs * 4;
            }

        
    }
}
