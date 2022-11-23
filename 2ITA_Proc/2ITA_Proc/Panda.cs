using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITA_Proc
{
    internal class Panda : Zvire
    {
        public Panda(string jmeno, string druh, int hlad) : base(jmeno, druh, hlad)
        {
            druh = "panda";
        }
    }
}
