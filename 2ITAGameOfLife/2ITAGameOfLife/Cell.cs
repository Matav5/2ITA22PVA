using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITAGameOfLife
{
    internal class Cell
    {
        public int x;
        public int y;
        public bool isAlive;

        public Brush Brush => isAlive ? Brushes.Black : Brushes.White;
        public Cell(int x, int y, bool isAlive)
        {
            this.x = x;
            this.y = y;
            this.isAlive = isAlive;
        }

        internal void Draw(Graphics graphics, int cellWidth, int cellHeight)
        {
            graphics.FillRectangle(Brush,x*cellWidth,y*cellHeight,cellWidth,cellHeight);
        }
    }
}
