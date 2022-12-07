using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITA_Malovani
{
    internal class Obdelnik : Tvar
    {
        public Brush stetec;
        public Pen pero;
        public Obdelnik(int x, int y, int sirka, int vyska, Color barva, bool maVypln) : base(x, y, sirka, vyska, barva, maVypln)
        {
            this.stetec = new SolidBrush(barva);
            this.pero = new Pen(stetec);
        }
        public override void Vykresli(Graphics g)
        {
            //Vykreslování negativní šířky a výšky
            if (maVypln)
            {
                g.FillRectangle(stetec, VykreslovaciX, VykreslovaciY, VykreslovaciSirka, VykreslovaciVyska);
            }
            else
            {
                g.DrawRectangle(pero, VykreslovaciX, VykreslovaciY, VykreslovaciSirka, VykreslovaciVyska);
            }
        }

        public override void ZmenaVelikosti(int x2, int y2)
        {
            sirka = x2 - x;
            vyska = y2 - y;
        }
    }
}
