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

namespace Word_Value
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This opens a TXT file and out values the price of words in the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wordWorth = 0;
            string line = "";
            string[] wordArray;
            char[] charArray;
            const string FILTER = "TXT FILE|*.txt|ALL FILES|*.*";
            StreamReader reader;
            //Set the filter
            openFileDialog1.Filter = FILTER;
            //if the file is open
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //open selected file
                reader = File.OpenText(openFileDialog1.FileName);

                //while not the end of file
                while (!reader.EndOfStream)
                {
                    try
                    {
                        line = reader.ReadLine();
                        wordArray = line.Split(' ');
                        //if the array has a word in it
                        if(wordArray != null)
                        {
                            //for each word
                            for (int i = 0; i < wordArray.Length; i++)
                            {
                                //for each character
                                charArray = wordArray[i].ToCharArray();
                                for (int k = 0; k < charArray.Length; k++)
                                {
                                    //If the letter matches then add its value
                                    if (charArray[k].ToString() == "A")
                                    {
                                        wordWorth += 1;
                                    }
                                    else if (charArray[k].ToString() == "B")
                                    {
                                        wordWorth += 2;
                                    }
                                    else if (charArray[k].ToString() == "C")
                                    {
                                        wordWorth += 3;
                                    }
                                    else if (charArray[k].ToString() == "D")
                                    {
                                        wordWorth += 4;
                                    }
                                    else if (charArray[k].ToString() == "E")
                                    {
                                        wordWorth += 5;
                                    }
                                    else if (charArray[k].ToString() == "F")
                                    {
                                        wordWorth += 6;
                                    }
                                    else if (charArray[k].ToString() == "G")
                                    {
                                        wordWorth += 7;
                                    }
                                    else if (charArray[k].ToString() == "H")
                                    {
                                        wordWorth += 8;
                                    }
                                    else if (charArray[k].ToString() == "I")
                                    {
                                        wordWorth += 9;
                                    }
                                    else if (charArray[k].ToString() == "J")
                                    {
                                        wordWorth += 10;
                                    }
                                    else if (charArray[k].ToString() == "K")
                                    {
                                        wordWorth += 11;
                                    }
                                    else if (charArray[k].ToString() == "L")
                                    {
                                        wordWorth += 12;
                                    }
                                    else if (charArray[k].ToString() == "M")
                                    {
                                        wordWorth += 13;
                                    }
                                    else if (charArray[k].ToString() == "N")
                                    {
                                        wordWorth += 14;
                                    }
                                    else if (charArray[k].ToString() == "O")
                                    {
                                        wordWorth += 15;
                                    }
                                    else if (charArray[k].ToString() == "P")
                                    {
                                        wordWorth += 16;
                                    }
                                    else if (charArray[k].ToString() == "Q")
                                    {
                                        wordWorth += 17;
                                    }
                                    else if (charArray[k].ToString() == "R")
                                    {
                                        wordWorth += 18;
                                    }
                                    else if (charArray[k].ToString() == "S")
                                    {
                                        wordWorth += 19;
                                    }
                                    else if (charArray[k].ToString() == "T")
                                    {
                                        wordWorth += 20;
                                    }
                                    else if (charArray[k].ToString() == "U")
                                    {
                                        wordWorth += 21;
                                    }
                                    else if (charArray[k].ToString() == "V")
                                    {
                                        wordWorth += 22;
                                    }
                                    else if (charArray[k].ToString() == "W")
                                    {
                                        wordWorth += 23;
                                    }
                                    else if (charArray[k].ToString() == "X")
                                    {
                                        wordWorth += 24;
                                    }
                                    else if (charArray[k].ToString() == "Y")
                                    {
                                        wordWorth += 25;
                                    }
                                    else if (charArray[k].ToString() == "Z")
                                    {
                                        wordWorth += 26;
                                    }

                                }  
                                //if the word is between 90 and 110
                                if(wordWorth < 110 && wordWorth > 90)
                                {
                                    //display the words worth
                                    listBoxOutput.Items.Add(wordArray[i] +  " $" + wordWorth);
                                }
                                //reset word value
                                wordWorth = 0;
                            }                     
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("An error has occurred: " + line);
                    }
                }
                reader.Close();
            }
            //to deal with cancel of file selection
            else { }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxOutput.ClearSelected();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
