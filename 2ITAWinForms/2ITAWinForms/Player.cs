using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITAWinForms
{
    public class Player : Policko
    {
        public bool lost = false;
        public Player(int x, int y) : base(x,y)
        {
  
        }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Cyan, x * 100, y * 100, 100, 100);
        }
    }
}
