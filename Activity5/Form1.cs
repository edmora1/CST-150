using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String word;
        int maxVal = 0;
        int maxLetters = 0;
        int vowelCount;
        int vowelIndex; 
        

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                word = System.IO.File.ReadAllText(openFileDialog1.FileName);
                textLowerCase.Text = word.ToLower(); 
                string[] wordArray = word.Split(' ');
                Array.Sort(wordArray);
                firstWordText.Text = wordArray[0];
                lastWordText.Text = wordArray[wordArray.Length - 1];

                for (int i = 0; i < wordArray.Length-1; i++)
                {
                    if (maxVal < wordArray[i].Length)
                    {
                        maxVal = wordArray[i].Length;
                        maxLetters = i; 
                    }
                    if (vowelCount < getWordMostVowels(wordArray[i]))
                    {
                        vowelCount = getWordMostVowels(wordArray[i]);
                        vowelIndex = i; 
                    }
                }
                vowelText.Text = wordArray[vowelIndex]; 
                longWordText.Text = wordArray[maxLetters];
            }
        }
        public int getWordMostVowels(String input)
        {
            int vowels = 0; 
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i]== 'u')
                {
                    vowels++;
                }
            }
            return vowels;
        }
    }
}
