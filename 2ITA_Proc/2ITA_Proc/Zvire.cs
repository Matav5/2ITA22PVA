using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITA_Proc
{
    internal class Zvire
    {
        private string jmeno;
        //Getter
        public string Jmeno => jmeno;
   
        public string druh;
        public string Druh
        {
            //Getter
            get
            {
                jmeno += " . ";
                return druh;
            }
        }

        //0 - 100 100 = nejvíc nakrmený
        private int hlad;
        public int Hlad
        {
            get => hlad;
            set
            {
                hlad = value;
                if (hlad > 100)
                {
                    //110
                    int vyblitihlad = (hlad - 100) / 2;
                    hlad = 100 - vyblitihlad;               
                }
                if (hlad <= 0)
                    Console.WriteLine(jmeno + " umřel/a :(");
            }
        }

        public Zvire(string jmeno, string druh, int hlad)
        {
            this.jmeno = jmeno;
            this.druh = druh;
            this.hlad = hlad;
        }

        public void Nakrmit(int sytost, string typJidla)
        {
            Hlad += sytost;
          
            Console.WriteLine(druh + " " + jmeno + " byl nakrmen a je nyní sytý na " + hlad + "%");
        }

        public override string ToString()
        {
            return druh + " " + jmeno + " je nasycena z " + hlad + "%. Je spokojen/á";
        }

    }
}
