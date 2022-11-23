using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITAWinForms
{
    public class Policko
    {
        
        public int x;
        public int y;

        public Policko(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void Draw(Graphics g)
        {

        }
        public virtual void Move(int smerX, int smerY)
        {
            x += smerX;
            y += smerY;
        }

        public virtual void CollidesWith(Player player)
        {

        }
    }
}
