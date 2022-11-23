using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITASpoctiGame
{
    internal class Priklad
    {
        public double cisloA;
        public double cisloB;
        public Operator znamenko;
        public double vysledek;

        public Point pointCisloA;
        public Point pointCisloB;
        public Point pointZnamenko;
        public Priklad(double cisloA, double cisloB, Operator znamenko, Point pointCisloA, Point pointCisloB, Point pointZnamenko)
        {
            this.cisloA = cisloA;
            this.cisloB = cisloB;
            this.znamenko = znamenko;
            this.vysledek = VypocitejVysledek();
            this.pointCisloA = pointCisloA;
            this.pointCisloB = pointCisloB;
            this.pointZnamenko = pointZnamenko;
        }

        public double VypocitejVysledek()
        {
            switch (znamenko)
            {
                case Operator.Scitani:
                    return cisloA + cisloB;
                case Operator.Nasobeni:
                    return cisloA * cisloB;
                default:
                    return int.MaxValue;
            }
        }
        public string VratZnak()
        {
            switch (znamenko)
            {
                case Operator.Scitani:
                    return "+";
                case Operator.Nasobeni:
                    return "*";
                default:
                    return "Jak si to sakra udělal. Nechápu jak jsi to byl schopný rozbít";
            }
        }
        public void Vykresli(Graphics g)
        {
            Font font = new Font("Segoe UI", 10);
            g.DrawString(cisloA.ToString(), font, Brushes.Black, 50, 50);
        }
    }
    public enum Operator
    {
        Scitani,
        Nasobeni
    }
}
