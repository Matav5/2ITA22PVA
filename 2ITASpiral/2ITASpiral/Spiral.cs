using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITASpiral
{
    internal class Spiral
    {
        public int x;
        public int y;
        private int spiralSize = 10;
        private int dir;
        public Spiral(int x, int y, int spiralSize, int dir)
        {
            this.x = x;
            this.y = y;
            this.spiralSize = spiralSize;
            this.dir = dir;
        }
        public void Draw(Graphics g)
        {
            Point lastPoint = new Point(x,y);
            Point nextPoint;
            int tempDir = dir;
            for (int i = 0; i < 100; i++)
            {
                switch (tempDir)
                {
                    case 0:
                        nextPoint = new Point(lastPoint.X, lastPoint.Y - spiralSize * i);
                        break;
                    case 1:
                        nextPoint = new Point(lastPoint.X + spiralSize * i, lastPoint.Y);
                        break;
                    case 2:
                        nextPoint = new Point(lastPoint.X, lastPoint.Y + spiralSize * i);
                        break;
                    default:
                        nextPoint = new Point(lastPoint.X - spiralSize * i, lastPoint.Y);
                        break;;
                }

                g.DrawLine(Pens.Black, lastPoint, nextPoint);
                lastPoint = nextPoint;
                tempDir++;
                tempDir %= 4;
            }
        }
    }
}
