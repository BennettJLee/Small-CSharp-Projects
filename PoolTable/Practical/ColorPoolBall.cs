using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Practical
{
    class ColorPoolBall : PoolBall
    {
        public Color[] colors = { Color.Yellow, Color.Red, Color.Blue, Color.Violet, Color.Orange, Color.Green, Color.Maroon };
        public List<Color> listBallColor;
        public Random rand = new Random();
        private Color color;

        public ColorPoolBall(int x, int y, int dx, int dy, Color ballColor) : base(x, y, dx, dy)
        {
            color = ballColor;
        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
