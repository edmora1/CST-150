using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumberApplication
{
    public partial class Form1 : Form
    {
        
        static int luckyNumber;
        public Form1()
        {
            InitializeComponent();
        }

        public int getLuckyNum()
        {
            return luckyNumber;
        }

        public void birthDay()
        {
            int monthDay = 0; 

            if (cbMonth.SelectedText == "January" || cbMonth.SelectedText == "March" || cbMonth.SelectedText == "May" || cbMonth.SelectedText == "July"||
                cbMonth.SelectedText == "August" || cbMonth.SelectedText == "October" || cbMonth.SelectedText == "December")

            {
                monthDay = 31;
                for (int i = 0; i < monthDay; i++)
                {
                    cbDay.Items.Add(i + 1);
                } 
            }
            else if (cbMonth.SelectedText == "February")
            {
                int year = Int32.Parse(cbYear.Text);

                if (year % 400 == 0)
                {
                    monthDay = 29;
                }
                if (year % 100 == 0)
                {
                    monthDay = 28;
                }
                if (year % 4 == 0)
                {
                    monthDay = 29;
                }
                else { 
                    monthDay = 28; }
                for (int i = 0; i < monthDay; i++)
                {
                    cbDay.Items.Add(i + 1);
                }
            }
            else
            {
                monthDay = 30;
                for (int i = 0; i < monthDay; i++)
                {
                    cbDay.Items.Add(i + 1);
                }
            }

            if (cbMonth.SelectedText != " ")
           {
                cbDay.Items.Clear();
                for (int i = 0; i < monthDay; i++)
                {
                    cbDay.Items.Add(i + 1);
                }
                cbDay.Text = cbDay.Items.ToString();  
            }
        }

        private void cbMonthSelectIndexChange(object sender, EventArgs e)
        {
            birthDay(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbYear.Text = "2004"; 
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (cbYear.SelectedIndex != -1 && cbMonth.SelectedIndex != -1 && 
                cbDay.SelectedIndex != -1 && cbColor.SelectedIndex != -1){

                luckyNumber = cbYear.SelectedIndex + cbDay.SelectedIndex + cbMonth.SelectedIndex + cbColor.SelectedIndex;

                Form2 form2 = new Form2();
                form2.Show(); 
            }
            else
            {
                MessageBox.Show("Please fill the above form to its entirety."); 
            }
        }
    }
}
