using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITAOpakOOP
{
    internal class Brick
    {
        int x = 50;
        int y = 50;
        int width = 15;
        int height = 5;
        public Brick(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        internal void Draw(Graphics g)
        {
            Random r = new Random();
           SolidBrush solidBrush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
           g.FillRectangle(solidBrush, x - width/2 , y - height/2, width, height);
        }
    }
}
