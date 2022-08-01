using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class PoolBall : MovingBall
    {
        public PoolBall(int x, int y, int dx, int dy) : base(x, y, dx, dy)
        {

        }

        public override void Move()
        {
            if (xCoord < 0 + (size / 2))
            {
                XSpeed = -XSpeed;
                base.Move();
            }
            else if (yCoord < 0 + (size / 2))
            {
                YSpeed = -YSpeed;
                base.Move();
            }
            else if (xCoord > 233 - size)
            {
                XSpeed = -XSpeed;
                base.Move();
            }
            else if (yCoord > 117 - size)
            {
                YSpeed = -YSpeed;
                base.Move();
            }
            else
            {
                base.Move();
            }
        }
    }
}
