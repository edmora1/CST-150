using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            int[,] array = new int[3, 3];

            bool xWin = false;
            bool oWin = false;

            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = random.Next(0, 2); 
                }
            }

            if (array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2])
            {
                xWin = array[0, 0] == 1;
                oWin = array[0, 0] == 0;
            }
            if (array[1, 0] == array[1, 1] && array[1, 1] == array[1, 2])
            {
                xWin = array[1, 0] == 1;
                oWin = array[1, 0] == 0;
            }
            if (array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2])
            {
                xWin = array[2, 0] == 1;
                oWin = array[2, 0] == 0;
            }
            if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2])
            {
                xWin = array[0, 0] == 1;
                oWin = array[0, 0] == 0;
            }
            if (array[0, 0] == array[1, 0] && array[1, 0] == array[2, 0])
            {
                xWin = array[0, 0] == 1;
                oWin = array[0, 0] == 0;
            }
            if (array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1])
            {
                xWin = array[0, 1] == 1;
                oWin = array[0, 1] == 0;
            }
            if (array[0, 2] == array[1, 2] && array[1, 2] == array[2, 2])
            {
                xWin = array[0, 2] == 1;
                oWin = array[0, 2] == 0;
            }
            if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0])
            {
                xWin = array[0, 2] == 1;
                oWin = array[0, 2] == 0;
            }

            if (array[0, 0] == 1)
            {
                bottomLeftLabel.Text = "X";
            }
            else
            {
                bottomLeftLabel.Text = "O";
            }

            if (array[0, 1] == 1)
            {
                midLeftLabel.Text = "X";
            }
            else
            {
                midLeftLabel.Text = "O";
            }

            if (array[0, 2] == 1)
            {
                topLeftLabel.Text = "X";
            }
            else
            {
                topLeftLabel.Text = "O";
            }

            if (array[1, 0] == 1)
            {
                bottomMidLabel.Text = "X";
            }
            else
            {
                bottomMidLabel.Text = "O";
            }

            if (array[1, 1] == 1)
            {
                centerLabel.Text = "X";
            }
            else
            {
                centerLabel.Text = "O";
            }

            if (array[1, 2] == 1)
            {
                topMidLabel.Text = "X";
            }
            else
            {
                topMidLabel.Text = "O";
            }

            if (array[2, 0] == 1)
            {
                bottomRightLabel.Text = "X";
            }
            else
            {
                bottomRightLabel.Text = "O";
            }

            if (array[2, 1] == 1)
            {
                midRightLabel.Text = "X";
            }
            else
            {
                midRightLabel.Text = "O";
            }

            if (array[2, 2] == 1)
            {
                topRightLabel.Text = "X";
            }
            else
            {
                topRightLabel.Text = "O";
            }

            if (xWin)
            {
                textBox1.Text = "X Wins";
            }

            else if (oWin)
            {
                textBox1.Text = "O Wins"; 
            }

            else 
            {
                textBox1.Text = "Game Draw"; 
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
