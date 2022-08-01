using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Trees
{
    class Shrub : Tree
    {

        public Shrub(int xPos, int yPos, int size) : base(xPos, yPos, size)
        {
            YPos = xPos;
            XPos = yPos;
            Size = size;
        }

        public void DrawTree(Graphics paper, int xPos, int yPos, int size)
        {
            SolidBrush foliageBrush = new SolidBrush(Color.DarkGreen);
            paper.FillEllipse(foliageBrush, xPos - size / 2, yPos - size / 2, size, size);
        }
        public string ToCsvString()
        {
            return "Shrub, " + XPos.ToString() + "," + YPos.ToString() + "," + Size.ToString();
        }
        public override string ToString()
        {
            return "Shrub at position " + XPos.ToString() + ", " + YPos.ToString();
        }
    }
}
