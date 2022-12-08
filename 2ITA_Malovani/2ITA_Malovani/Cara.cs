using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITA_Malovani
{
    internal class Cara : Tvar
    {
        Pen pero;
        public Cara(int x, int y, int sirka, int vyska, Color barva) : base(x, y, sirka, vyska, barva, false)
        {
            pero = new Pen(barva);
        }
        public override void Vykresli(Graphics g)
        {
            g.DrawLine(pero, x, y, x + sirka, y + vyska);
        }
        public override void ZmenaVelikosti(int x2, int y2)
        {
            sirka = x2 - x;
            vyska = y2 - y;
        }
    }
}
