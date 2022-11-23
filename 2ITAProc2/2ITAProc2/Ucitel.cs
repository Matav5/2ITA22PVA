using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITAProc2
{
    internal class Ucitel : Zak
    {
        public Ucitel(int experience, string jmeno, string prijmeni, double benchPR, float pulls, short penizeVPenezence) : base(experience, jmeno, prijmeni, benchPR, pulls, penizeVPenezence)
        {
            this.experience = int.MaxValue-10;
        }

        public override void GOGYM(int dobaVGYMu)
        {
            benchPR += Math.Pow(dobaVGYMu,2);
            pulls += (float) Math.Sqrt(dobaVGYMu);
        }
        public void UC(int dobaUceni, Zak zak)
        {
            zak.experience += dobaUceni;
            experience -= dobaUceni/2;
        }
    }
}
