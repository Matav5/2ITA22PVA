using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITAMedusa
{
    internal class Medusa
    {
        public int x;
        public int y;
        public Brush color;
        public float hunger;
        public int originalSize = 50;
        public int Size => (int)(hunger * originalSize);

        public Medusa(int x, int y, float hunger)
        {
            this.x = x;
            this.y = y;
            this.hunger = hunger;
            Random r = new Random();
            color = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
        }
        public void Draw(Graphics g)
        {
           // g.DrawRectangle(Pens.Black, x - Size / 2, y - Size / 2, Size, Size);
            g.DrawLine(Pens.Black, new Point(x - Size / 3, y - Size /3 ), new Point(x - Size / 3, y + Size));
            g.DrawLine(Pens.Black, new Point(x - Size / 6, y - Size / 3), new Point(x - Size / 6, y + Size ));
            g.DrawLine(Pens.Black, new Point(x + Size / 6, y - Size / 3), new Point(x + Size / 6, y + Size ));
            g.DrawLine(Pens.Black, new Point(x + Size /3 , y - Size / 3), new Point(x + Size / 3, y + Size ));
            g.FillEllipse(color, x - Size / 2, y - Size / 2, Size, Size / 2);
        }
    }
}
