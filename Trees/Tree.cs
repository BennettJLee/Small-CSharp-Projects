using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Trees
{
    class Tree
    {
        int _xPos;
        int _yPos;
        int _size;

        /// <summary>
        /// Gets xPosition, yPosition and Size
        /// </summary>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        /// <param name="size"></param>
        public Tree(int xPos, int yPos, int size)
        {
            YPos = xPos;
            XPos = yPos;
            Size = size;
        }
        /// <summary>
        /// gets and sets xPosition
        /// </summary>
        public int XPos
        {
            get { return _xPos; }
            set
            {
                _xPos = value;
            }
        }
        /// <summary>
        /// gets and sets yPosition
        /// </summary>
        public int YPos
        {
            get { return _yPos; }
            set
            {
                _yPos = value;
            }
        }
        /// <summary>
        /// Gets and sets Size
        /// </summary>
        public int Size
        {
            get { return _size; }
            set
            {
                _size = value;
            }
        }
        const int TRUNKWIDTH = 6;
        const int TRUNKHEIGHT = 80;
        /// <summary>
        /// This draws a tree
        /// </summary>
        /// <param name="paper"></param>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        /// <param name="size"></param>
        public void DrawTree(Graphics paper, int xPos, int yPos, int size)
        {
            SolidBrush trunkBrush = new SolidBrush(Color.Brown);
            SolidBrush foliageBrush = new SolidBrush(Color.Green);
            paper.FillRectangle(trunkBrush, xPos - TRUNKWIDTH / 2, yPos, TRUNKWIDTH, TRUNKHEIGHT);
            paper.FillEllipse(foliageBrush, xPos - size / 2, yPos - size / 2, size, size);
        }

        public string ToCsvString()
        {
            return "Tree, " + XPos.ToString() + "," + YPos.ToString() + "," + Size.ToString();
        }

        public void GrowTree(int x)
        {
            Size += x;
            if(Size > 50)
            {
                Size = 50;
            }
        }
        public override string ToString()
        {
            return "Tree at position " + XPos.ToString() + ", " + YPos.ToString();
        }
    }
}
