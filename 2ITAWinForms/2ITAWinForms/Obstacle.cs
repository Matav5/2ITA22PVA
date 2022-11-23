using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITAWinForms
{
    public class Obstacle : Policko
    {
        public Obstacle(int x, int y) : base(x, y)
        {
        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Red, x * 100, y * 100, 100, 100);
        }
        public override void CollidesWith(Player player)
        {
            //Player dies

            player.lost = true;

        }
    }
}
