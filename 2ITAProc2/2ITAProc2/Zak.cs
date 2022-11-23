using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITAProc2
{
    internal class Zak
    {
        public int experience;
        public string jmeno;
        public string prijmeni;
        public double benchPR;
        public float pulls;
        public short penizeVPenezence;

        public Zak(int experience, string jmeno, string prijmeni, double benchPR, float pulls, short penizeVPenezence)
        {
            this.experience = experience;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.benchPR = benchPR;
            this.pulls = pulls;
            this.penizeVPenezence = penizeVPenezence;
        }
        public virtual void GOGYM(int dobaVGYMu)
        {
            benchPR += 0.5 * dobaVGYMu;
            pulls += 0.1f * dobaVGYMu;
        }
        public void UCSE(int dobaUceni, int cenaLekce)
        {
            experience += dobaUceni;
            penizeVPenezence -= (short) cenaLekce;
        }
    }
}
