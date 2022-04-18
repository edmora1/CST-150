using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string shapeType = lbShape.SelectedItem.ToString();
        }
        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            string shapeType = lbShape.SelectedItem.ToString();

            if (shapeType == "Circle")
            {
                if (rbFill.Checked)
                {
                    pbFinal.Visible = true;
                    pbFinal.Image = imageList.Images[0];
                    if (cbName.Checked)
                    {
                        labelName.Text = "Circle";
                        labelDate.Text = " "; 
                    }
                    if (cbDate.Checked)
                    {
                        labelDate.Text = DateTime.Now.ToString();
                        labelName.Text = " "; 
                    }
                    if (cbName.Checked && cbDate.Checked)
                    {
                        labelName.Text = "Circle";
                        labelDate.Text = DateTime.Now.ToString();
                    }
                }
                else if (rbOutline.Checked)
                {
                    pbFinal.Visible = true;
                    pbFinal.Image = imageList.Images[1];
                    if (cbName.Checked)
                    {
                        labelName.Text = "Circle";
                        labelDate.Text = " "; 
                    }
                    if (cbDate.Checked)
                    {
                        labelDate.Text = DateTime.Now.ToString();
                        labelName.Text = " "; 
                    }
                    if (cbName.Checked && cbDate.Checked)
                    {
                        labelName.Text = "Circle";
                        labelDate.Text = DateTime.Now.ToString();
                    }
                }
            }
            else if (shapeType == "Triangle")
            {

                if (rbFill.Checked)
                {
                    pbFinal.Visible = true;
                    pbFinal.Image = imageList.Images[2];
                    if (cbName.Checked)
                    {
                        labelName.Text = "Triangle";
                        labelDate.Text = " "; 
                    }
                    if (cbDate.Checked)
                    {
                        labelDate.Text = DateTime.Now.ToString();
                        labelName.Text = " "; 
                    }
                    if (cbName.Checked && cbDate.Checked)
                    {
                        labelName.Text = "Triangle";
                        labelDate.Text = DateTime.Now.ToString();
                    }
                }
                else if (rbOutline.Checked)
                {
                    pbFinal.Visible = true;
                    pbFinal.Image = imageList.Images[3];
                    if (cbName.Checked)
                    {
                        labelName.Text = "Triangle";
                        labelDate.Text = " "; 
                    }
                    if (cbDate.Checked)
                    {
                        labelDate.Text = DateTime.Now.ToString();
                        labelName.Text = " "; 
                    }
                    if (cbName.Checked && cbDate.Checked)
                    {
                        labelName.Text = "Triangle";
                        labelDate.Text = DateTime.Now.ToString();
                    }
                }
            }
            else if (shapeType == "Pentagon")
            {

                if (rbFill.Checked)
                {
                    pbFinal.Visible = true;
                    pbFinal.Image = imageList.Images[4];
                    if (cbName.Checked)
                    {
                        labelName.Text = "Pentagon";
                        labelDate.Text = " "; 
                    }
                    if (cbDate.Checked)
                    {
                        labelDate.Text = DateTime.Now.ToString();
                        labelName.Text = " "; 
                    }
                    if (cbName.Checked && cbDate.Checked)
                    {
                        labelName.Text = "Pentagon";
                        labelDate.Text = DateTime.Now.ToString();
                    }
                }
                else if (rbOutline.Checked)
                {
                    pbFinal.Visible = true;
                    pbFinal.Image = imageList.Images[5];
                    if (cbName.Checked)
                    {
                        labelName.Text = "Pentagon";
                        labelDate.Text = " "; 
                    }
                    if (cbDate.Checked)
                    {
                        labelDate.Text = DateTime.Now.ToString();
                        labelName.Text = " "; 
                    }
                    if (cbName.Checked && cbDate.Checked)
                    {
                        labelName.Text = "Pentagon";
                        labelDate.Text = DateTime.Now.ToString();
                    }
                }
            }
            else if(shapeType == "Hexagon")
            {

                if (rbFill.Checked)
                {
                    pbFinal.Visible = true;
                    pbFinal.Image = imageList.Images[6];
                    if (cbName.Checked)
                    {
                        labelName.Text = "Hexagon";
                        labelDate.Text = " "; 
                    }
                    if (cbDate.Checked)
                    {
                        labelDate.Text = DateTime.Now.ToString();
                        labelName.Text = " "; 
                    }
                    if (cbName.Checked && cbDate.Checked)
                    {
                        labelName.Text = "Hexagon";
                        labelDate.Text = DateTime.Now.ToString();
                    }
                }
                else if (rbOutline.Checked)
                {
                    pbFinal.Visible = true;
                    pbFinal.Image = imageList.Images[7];
                    if (cbName.Checked)
                    {
                        labelName.Text = "Hexagon";
                        labelDate.Text = " "; 
                    }
                    if (cbDate.Checked)
                    {
                        labelDate.Text = DateTime.Now.ToString();
                        labelName.Text = " "; 
                    }
                    if (cbName.Checked && cbDate.Checked)
                    {
                        labelName.Text = "Hexagon";
                        labelDate.Text = DateTime.Now.ToString(); 
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pbFinal.Image = null; 
            pbFinal.Visible = false;
            labelDate.Text = " "; labelName.Text = " "; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
