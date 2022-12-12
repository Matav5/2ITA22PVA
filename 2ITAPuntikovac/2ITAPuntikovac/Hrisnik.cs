using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITAPuntikovac
{
    public class Hrisnik
    {
        public string jmeno;
        public int pocetPuntiku;
        public Color barvicka;
        public Label label;

        public Hrisnik(string radek, Label label)
        {
            string[] sloupce = radek.Split(',');
            jmeno = sloupce[0];
            pocetPuntiku = int.Parse(sloupce[1]);
            this.label = label;
            UpdateLabel();
        }

        public Hrisnik(string jmeno, int pocetPuntiku, Color barvicka, Label label)
        {
            this.jmeno = jmeno;
            this.pocetPuntiku = pocetPuntiku;
            this.barvicka = barvicka;
            this.label = label;
            UpdateLabel();
        }
        public void UpdateLabel()
        {
            label.Text = $"{jmeno} s počtem puntiku: {pocetPuntiku}x ●";
        }
    }
}
