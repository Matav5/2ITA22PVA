using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITA_Malovani
{
    internal class Tvar
    {
        public int x;
        public int y;
        public int sirka;
        public int vyska;
        public Color barva;
        public bool maVypln;

        public Tvar(int x, int y, int sirka, int vyska, Color barva, bool maVypln)
        {
            this.x = x;
            this.y = y;
            this.sirka = sirka;
            this.vyska = vyska;
            this.barva = barva;
            this.maVypln = maVypln;
        }

        public virtual void Vykresli(Graphics g)
        {

        }
        public virtual void ZmenaVelikosti(int x2, int y2)
        {

        }
    }
}
