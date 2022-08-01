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

namespace Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<LottoLine> listLottoLine = new List<LottoLine>();
        public int[] winNumsArray = { 29, 10, 12, 8, 32, 27, 18 };
        /// <summary>
        /// updates list box
        /// </summary>
        private void UpdateListBox()
        {
            listBoxData.Items.Clear();
            //listBoxData.Items.Add(listLottoLine);
            foreach(LottoLine l in listLottoLine)
            {
                listBoxData.Items.Add(l.ToString());
                listBoxData.Items.Add(l.CheckNumbers(winNumsArray) + " numbers are correct.");
            }
            
        }
        /// <summary>
        /// Open a file for lotto numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            string line = "";
            string[] csvArray;

            openFileDialog1.Filter = "CSV Files|*.csv|ALL FILES|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                reader = File.OpenText(openFileDialog1.FileName);
                while (!reader.EndOfStream)
                {
                    try
                    {
                        line = reader.ReadLine();
                        csvArray = line.Split(',');
                        if (csvArray.Length == 6)
                        {
                            listLottoLine.Add(new LottoLine(csvArray));
                        }
                        else if(csvArray.Length == 7)
                        {
                            listLottoLine.Add(new PowerBallLine(csvArray));
                        }
                        else
                        {
                            Console.WriteLine("Error: " + line);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error: " + line);
                    }
                }
                reader.Close();
                UpdateListBox();
            }
            else { }
        }
    }
}
