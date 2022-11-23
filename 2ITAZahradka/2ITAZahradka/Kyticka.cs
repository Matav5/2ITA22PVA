using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITAZahradka
{
    internal class Kyticka
    {
        int x;
        int y;
        int size;
        Color color;
        public Kyticka(int x, int y, int size)
        {
            Random r = new Random();
            this.x = x;
            this.y = y;
            this.size = size;
            this.color = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
        }
        public void Draw(Graphics g)
        {

            g.FillEllipse(new SolidBrush(color), x, y - size / 2, size, size);
            g.FillEllipse(new SolidBrush(color), x - size, y - size / 2, size, size);
            g.FillEllipse(new SolidBrush(color), x - size / 2, y, size, size);
            g.FillEllipse(new SolidBrush(color), x - size / 2, y - size, size, size);
            g.FillEllipse(Brushes.Yellow, x - size / 2, y - size / 2, size, size);
        }
    }
}
