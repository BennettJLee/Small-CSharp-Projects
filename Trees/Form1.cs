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

namespace Trees
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        Forest f = new Forest();
        //List<Tree> listTree = new List<Tree>();
        static Random rnd = new Random();

        /// <summary>
        /// This creates a tree from DrawTree method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateTree_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics treePaper = pictureBoxTree.CreateGraphics();
            try
            {
                int size = int.Parse(textBoxFoliageSize.Text.Trim());
                int maxValue = pictureBoxTree.Width;
                int xPos = rnd.Next(maxValue);
                int yPos = rnd.Next(maxValue);
                if (size <= 10)
                {
                    size = 10;
                }
                else if (size >= 30)
                {
                    size = 30;
                }
                if (e.Button == MouseButtons.Left)
                {
                    f.AddTree(xPos, yPos, size);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    f.AddShrub(xPos, yPos, size);
                }

                //DrawTree(treePaper, xPos, yPos, size);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Gives picture box a gray background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxTree_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.LightGray);
            Graphics treePaper = pictureBoxTree.CreateGraphics();
            f.DrawForest(treePaper);
        }
        /// <summary>
        /// creates a timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = 2;
            pictureBoxTree.Refresh();
            f.GrowForest(x);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FILTER = "CSV FILES|*.csv|ALL FILES|*.*";
            string filename;
            saveFileDialog1.Filter = FILTER;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                f.LoadForest(filename);
            }
            else { }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FILTER = "CSV FILES|*.csv|ALL FILES|*.*";
            string filename;
            saveFileDialog1.Filter = FILTER;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                f.SaveForest(filename);
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FILTER = "CSV FILES|*.csv|ALL FILES|*.*";
            string filename;
            saveFileDialog1.Filter = FILTER;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                f.GenerateReport(filename);
            }
        }
    }
}
