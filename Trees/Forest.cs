using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Trees
{
    class Forest
    {
        public List<Tree> listForest;
        public Forest()
        {
            listForest = new List<Tree>();
        }

        public void AddTree(int XPos, int YPos, int size)
        {
            //add values to list
            listForest.Add(new Tree(XPos, YPos, size));
        }
        public void AddShrub(int xPos, int yPos, int size)
        {
            listForest.Add(new Shrub(xPos, yPos, size));
        }

        public void DrawForest(Graphics treePaper)
        {
            for (int i = 0; i < listForest.Count; i++)
            {
                if (listForest[i] is Shrub)
                {
                    Shrub s = (Shrub)listForest[i];
                     s.DrawTree(treePaper, s.XPos, s.YPos, s.Size);

                }
                else if (listForest[i] is Tree)
                {
                    Tree t = (Tree)listForest[i];
                     t.DrawTree(treePaper, t.XPos, t.YPos, t.Size);
                }
            }
        }

        public void SaveForest(string filename)
        {
            StreamWriter writer;
                writer = File.CreateText(filename);
                foreach(Tree t in listForest)
                {
                    writer.WriteLine(t.ToCsvString());
                }
                writer.Close();
        }
        public void LoadForest(string filename)
        {
            StreamReader reader;
            string line = "";
            string[] csvArray;
            int XPos = 0, YPos = 0, Size = 0;
            string type = "";
                reader = File.OpenText(filename);
                while (!reader.EndOfStream)
                {
                    try
                    {
                        line = reader.ReadLine();
                        csvArray = line.Split(',');
                        if (csvArray.Length == 4)
                        {
                            type = (csvArray[0]);
                            XPos = int.Parse(csvArray[1]);
                            YPos = int.Parse(csvArray[2]);
                            Size = int.Parse(csvArray[3]);
                            if(type == "Tree")
                            {
                                listForest.Add(new Tree(XPos, YPos, Size));
                            }
                            else if(type == "Shrub")
                            {
                            listForest.Add(new Shrub(XPos, YPos, Size));
                            }
                            
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
        }
        public void GenerateReport(string filename)
        {
            StreamWriter writer;
            writer = File.CreateText(filename);
            //foreach (Tree t in listForest)
            //{
            //    writer.WriteLine(t.ToString());
            //}
            //foreach(Shrub s in listForest)
            //{
            //    writer.WriteLine(s.ToString());
            //}
            for (int i = 0; i < listForest.Count; i++)
            {
                if (listForest[i] is Shrub)
                {
                    Shrub s = (Shrub)listForest[i];
                    writer.WriteLine(s.ToString());

                }
                else if (listForest[i] is Tree)
                {
                    Tree t = (Tree)listForest[i];
                    writer.WriteLine(t.ToString());
                }
            }
            writer.Close();
        }
        public void GrowForest(int x)
        {
            Random rand = new Random();
            int index = 0;
            if (listForest.Count != 0)
            {
                index = rand.Next(listForest.Count);
                listForest[index].GrowTree(x); 
            }
        }
    }
}
