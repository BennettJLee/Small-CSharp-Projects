using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PracTest3
{
    public partial class Form1 : Form
    {//Name: Ben Lee
        //ID  : 1567783

        List<string> listDate = new List<string>();
        List<int> listTCal = new List<int>();
        List<int> listSteps = new List<int>();
        List<double> listDist = new List<double>();
        List<int> listSeden = new List<int>();
        List<int> listLight = new List<int>();
        List<int> listFair = new List<int>();
        List<int> listVery = new List<int>();
        List<int> listACal = new List<int>();
        List<double> listStepsPerMetre = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        //The width of a bar in the bar graph
        const int BAR_WIDTH = 25;

        //the gap between bars in the bar graph
        const int GAP = 5;

        //the factor to scale the the graph by to make it fit nicely in the the picturebox
        const double SCALE_FACTOR = 15;

        /// <summary>
        /// Draws a vertical bar that is part of a bar graph.
        /// i.e. It fills a rectangle at position (x,y) with the specified colour.
        /// Then draws a black outline for the rectangle.
        /// Uses the BAR_WIDTH constant for the size of the rectangle.
        /// </summary>
        /// <param name="paper">The Graphics object to draw on.</param>
        /// <param name="x">The x position of the top left corner of the rectangle.</param>
        /// <param name="y">The y position of the top left corner of the rectangle.</param>
        /// <param name="colour">The colour to fill the background of the rectangle with.</param>
        private void DrawABar(Graphics paper, double x, double y, double length, Color colour)
        {
            //create a brush of specified colour and fill background with this colour 
            SolidBrush brush = new SolidBrush(colour);
            paper.FillRectangle(brush, (float)x, (float)y, BAR_WIDTH, (float)length);

            //draw outline in black
            paper.DrawRectangle(Pens.Black, (float)x, (float)y, BAR_WIDTH, (float)length);
        }
        /// <summary>
        /// This calculates steps per metre
        /// </summary>
        /// <param name="steps"></param> accepts an integer for number of steps
        /// <param name="distanceWalked"></param> accepts a double for distance travelled
        /// <returns></returns>
        private double CalculateStepsPerMetre(int steps, double distanceWalked)
        {
            double stepsPerMetre;
            //total steps divided by distance walked in metres
            stepsPerMetre = steps / (distanceWalked * 1000);

            return stepsPerMetre;
        }
        /// <summary>
        /// This displays data to the listbox from variables in a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 



        private void openFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string line = "";
            string[] csvArray;
            int TcalArray, stepsArray, SedenArray, lightArray, fairArray, veryArray, ACalArray, steps = 0;
            double distArray = 0, stepsPerMetre = 0;
            string dateArray;
            Graphics paper = pictureBoxTop.CreateGraphics();
            double xPos = 0, yPos = 0, length = 0;
            const string FITLER = "CSV FILES|*.csv|All Files|*.*";
            StreamReader reader;

            //Set the filter for the dialog control
            openFileDialog1.Filter = FITLER;
            //Check to see if the user selected a file to open
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //open the selected file
                reader = File.OpenText(openFileDialog1.FileName);
                //repeat while it is not the end of file
                listBoxOutput.Items.Add("Date".PadRight(12) + "TCal".PadRight(7) + "Steps".PadRight(7) + "Dist".PadRight(7)
                                            + "Seden".PadRight(7) + "Light".PadRight(7) + "Fair".PadRight(7) + "Very".PadRight(7) + "ACal".PadRight(7) + "Steps/Metre");
                //while not end of file
                while (!reader.EndOfStream)
                {

                    try
                    {
                        //read a line from the file
                        line = reader.ReadLine();
                        //Split the values in the line using an array
                        csvArray = line.Split(',');
                        //IF the array has correct number of elements
                        if (csvArray.Length == 9)
                        {
                            //Extract the values from the array into
                            dateArray = csvArray[0];
                            TcalArray = int.Parse(csvArray[1]);
                            stepsArray = int.Parse(csvArray[2]);
                            distArray = double.Parse(csvArray[3]);
                            SedenArray = int.Parse(csvArray[4]);
                            lightArray = int.Parse(csvArray[5]);
                            fairArray = int.Parse(csvArray[6]);
                            veryArray = int.Parse(csvArray[7]);
                            ACalArray = int.Parse(csvArray[8]);


                            //calculates the steps per metre
                            stepsPerMetre = CalculateStepsPerMetre(stepsArray, distArray);

                            //extract array values and store information in lists
                            listDate.Add(dateArray);
                            listTCal.Add(TcalArray);
                            listSteps.Add(stepsArray);
                            listDist.Add(distArray);
                            listSeden.Add(SedenArray);
                            listLight.Add(lightArray);
                            listFair.Add(fairArray);
                            listVery.Add(veryArray);
                            listACal.Add(ACalArray);
                            listStepsPerMetre.Add(stepsPerMetre);

                            //Add the data to the listbox
                            listBoxOutput.Items.Add(dateArray.PadRight(12) + TcalArray.ToString().PadRight(7) + stepsArray.ToString().PadRight(7) + distArray.ToString().PadRight(7) + SedenArray.ToString().PadRight(7)
                                + lightArray.ToString().PadRight(7) + fairArray.ToString().PadRight(7) + veryArray.ToString().PadRight(7) + ACalArray.ToString().PadRight(7) + stepsPerMetre.ToString("N3"));
                            //counts and adds steps taken
                            steps += stepsArray;
                            //gets the length of the graph
                            length = distArray * SCALE_FACTOR;
                            //bars rise from bottom of picturebox
                            yPos = pictureBoxTop.Height - length;
                            //draws bar
                            DrawABar(paper, xPos, yPos, length, Color.Black);
                            //moves xPos over by Bar width and gap
                            xPos += BAR_WIDTH + GAP;
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
                MessageBox.Show("This month you took a total of " + steps + " steps.");
                reader.Close();
            }
        }

        /// <summary>
        /// This clears the listbox and pictureboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxOutput.ClearSelected();
            pictureBoxTop.Image = null;
            pictureBoxBottom.Image = null;
        }
        /// <summary>
        /// this closes the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// This graphs the distance walked into days of the week
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void graphDaysToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //declare vairables
            double xPos = 0, yPos = 0, length = 0;
            Color colour;
            Graphics paper = pictureBoxBottom.CreateGraphics();
            try
            {
                for (double i = 0; i < listDist.Count; i += 7)
                {
                    //sets length
                    length = listDist[Convert.ToInt32(i)] * SCALE_FACTOR;
                    //changes colour 
                    colour = Color.Red;
                    yPos = pictureBoxTop.Height - length;
                    //draws bar
                    DrawABar(paper, xPos, yPos, length, colour);
                    //moves xPos over by Bar width and gap
                    xPos += BAR_WIDTH + GAP;
                }
                for (double i = 1; i < listDist.Count; i += 7)
                {
                    //sets length
                    length = listDist[Convert.ToInt32(i)] * SCALE_FACTOR;
                    //changes colour 
                    colour = Color.Purple;
                    yPos = pictureBoxTop.Height - length;
                    //draws bar
                    DrawABar(paper, xPos, yPos, length, colour);
                    //moves xPos over by Bar width and gap
                    xPos += BAR_WIDTH + GAP;
                }
                for (double i = 2; i < listDist.Count; i += 7)
                {
                    //sets length
                    length = listDist[Convert.ToInt32(i)] * SCALE_FACTOR;
                    //changes colour 
                    colour = Color.Blue;
                    yPos = pictureBoxTop.Height - length;
                    //draws bar
                    DrawABar(paper, xPos, yPos, length, colour);
                    //moves xPos over by Bar width and gap
                    xPos += BAR_WIDTH + GAP;
                }
                for (double i = 3; i < listDist.Count; i += 7)
                {
                    //sets length
                    length = listDist[Convert.ToInt32(i)] * SCALE_FACTOR;
                    //changes colour 
                    colour = Color.Orange;
                    yPos = pictureBoxTop.Height - length;
                    //draws bar
                    DrawABar(paper, xPos, yPos, length, colour);
                    //moves xPos over by Bar width and gap
                    xPos += BAR_WIDTH + GAP;
                }
                for (double i = 4; i < listDist.Count; i += 7)
                {
                    //sets length
                    length = listDist[Convert.ToInt32(i)] * SCALE_FACTOR;
                    //changes colour 
                    colour = Color.Brown;
                    yPos = pictureBoxTop.Height - length;
                    //draws bar
                    DrawABar(paper, xPos, yPos, length, colour);
                    //moves xPos over by Bar width and gap
                    xPos += BAR_WIDTH + GAP;
                }
                for (double i = 5; i < listDist.Count; i += 7)
                {
                    //sets length
                    length = listDist[Convert.ToInt32(i)] * SCALE_FACTOR;
                    //changes colour 
                    colour = Color.Yellow;
                    yPos = pictureBoxTop.Height - length;
                    //draws bar
                    DrawABar(paper, xPos, yPos, length, colour);
                    //moves xPos over by Bar width and gap
                    xPos += BAR_WIDTH + GAP;
                }
                for (double i = 6; i < listDist.Count; i += 7)
                {
                    //sets length
                    length = listDist[Convert.ToInt32(i)] * SCALE_FACTOR;
                    //changes colour 
                    colour = Color.Green;
                    yPos = pictureBoxTop.Height - length;
                    //draws bar
                    DrawABar(paper, xPos, yPos, length, colour);
                    //moves xPos over by Bar width and gap
                    xPos += BAR_WIDTH + GAP;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
