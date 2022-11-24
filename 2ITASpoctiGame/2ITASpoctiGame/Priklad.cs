using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITASpoctiGame
{
    internal class Priklad
    {
        private double cisloA;
        private double cisloB;
        private Operator znamenko;
        private double vysledek;
        public double Vysledek => vysledek;

        private Point pointCisloA;
        private Point pointCisloB;
        private Point pointZnamenko;
        private Brush brush;
        public Priklad(double cisloA, double cisloB, Operator znamenko, Point pointCisloA, Point pointCisloB, Point pointZnamenko, Color color)
        {
            this.cisloA = cisloA;
            this.cisloB = cisloB;
            this.znamenko = znamenko;
            this.vysledek = VypocitejVysledek();
            this.pointCisloA = pointCisloA;
            this.pointCisloB = pointCisloB;
            this.pointZnamenko = pointZnamenko;
            this.brush = new SolidBrush(color);
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
            Font font = new Font("Segoe UI", 15);
            g.DrawString(cisloA.ToString(), font, brush, pointCisloA);
            g.DrawString(cisloB.ToString(), font, brush, pointCisloB);
            g.DrawString(VratZnak(), font, brush, pointZnamenko);
        }
    }
    public enum Operator
    {
        Scitani,
        Nasobeni
    }
}
