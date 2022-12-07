using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITA_Malovani
{
    internal class Kolecko : Tvar
    {
        public Brush stetec;
        public Pen pero;
        public Kolecko(int x, int y, int sirka, int vyska, Color barva, bool maVypln) : base(x, y, sirka, vyska, barva, maVypln)
        {
            this.stetec = new SolidBrush(barva);
            this.pero = new Pen(stetec);
        }
        public override void Vykresli(Graphics g)
        {
            if (maVypln)
            {
                g.FillEllipse(stetec, VykreslovaciX, VykreslovaciY, VykreslovaciSirka, VykreslovaciVyska);
            }
            else
            {
                g.DrawEllipse(pero, VykreslovaciX, VykreslovaciY, VykreslovaciSirka, VykreslovaciVyska);
            }
        }
        public override void ZmenaVelikosti(int x2, int y2)
        {
            sirka = x2 - x;
            vyska = y2 - y;
        }
    }
}
