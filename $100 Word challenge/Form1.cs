using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100_Word_challenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /// <summary>
        /// This calculates a words worth
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWorth_Click(object sender, EventArgs e)
        {
            string word = textBoxWord.Text.ToUpper().Trim();
            char[] charArray = word.ToCharArray();
            int wordWorth = 0;

            //for each letter in a word 
            for (int i = 0; i < charArray.Length; i++)
            {
                //If the letter matches then add its value // try use ASCII and decimal allows for symbols
                if (charArray[i].ToString() == "A")
                {
                    wordWorth += 1;
                }
                else if (charArray[i].ToString() == "B")
                {
                    wordWorth += 2;
                }
                else if (charArray[i].ToString() == "C")
                {
                    wordWorth += 3;
                }
                else if (charArray[i].ToString() == "D")
                {
                    wordWorth += 4;
                }
                else if (charArray[i].ToString() == "E")
                {
                    wordWorth += 5;
                }
                else if (charArray[i].ToString() == "F")
                {
                    wordWorth += 6;
                }
                else if (charArray[i].ToString() == "G")
                {
                    wordWorth += 7;
                }
                else if (charArray[i].ToString() == "H")
                {
                    wordWorth += 8;
                }
                else if (charArray[i].ToString() == "I")
                {
                    wordWorth += 9;
                }
                else if (charArray[i].ToString() == "J")
                {
                    wordWorth += 10;
                }
                else if (charArray[i].ToString() == "K")
                {
                    wordWorth += 11;
                }
                else if (charArray[i].ToString() == "L")
                {
                    wordWorth += 12;
                }
                else if (charArray[i].ToString() == "M")
                {
                    wordWorth += 13;
                }
                else if (charArray[i].ToString() == "N")
                {
                    wordWorth += 14;
                }
                else if (charArray[i].ToString() == "O")
                {
                    wordWorth += 15;
                }
                else if (charArray[i].ToString() == "P")
                {
                    wordWorth += 16;
                }
                else if (charArray[i].ToString() == "Q")
                {
                    wordWorth += 17;
                }
                else if (charArray[i].ToString() == "R")
                {
                    wordWorth += 18;
                }
                else if (charArray[i].ToString() == "S")
                {
                    wordWorth += 19;
                }
                else if (charArray[i].ToString() == "T")
                {
                    wordWorth += 20;
                }
                else if (charArray[i].ToString() == "U")
                {
                    wordWorth += 21;
                }
                else if (charArray[i].ToString() == "V")
                {
                    wordWorth += 22;
                }
                else if (charArray[i].ToString() == "W")
                {
                    wordWorth += 23;
                }
                else if (charArray[i].ToString() == "X")
                {
                    wordWorth += 24;
                }
                else if (charArray[i].ToString() == "Y")
                {
                    wordWorth += 25;
                }
                else if (charArray[i].ToString() == "Z")
                {
                    wordWorth += 26;
                }
            }
            //display the words worth
            MessageBox.Show("This word is worth $" + wordWorth);
        }
    }
}
