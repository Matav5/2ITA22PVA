using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITAProc3
{
    internal class Ucitel
    {
        public string name;
        public int hp;
        public int ActualHP;

        public int dmg;
        public int armor;
        public int criticalChance;
        public Role role;
        public bool JeNazivu => ActualHP > 0;
        public Ucitel(string name, int hp, int dmg, int armor, int criticalChance, Role role)
        {
            this.name = name;
            this.hp = hp;
            this.dmg = dmg;
            this.armor = armor;
            this.criticalChance = criticalChance;
            this.role = role;
        }
        public void PripravSe()
        {
            ActualHP = hp;
        }

        internal void Utok(Ucitel ucitel)
        {

            int atkDmg = this.dmg;
            Random r = new Random();
            if (r.Next(0, 101) < criticalChance)
            {
                atkDmg *= 2;
            }
            ucitel.BranSe(atkDmg);

            Console.WriteLine($"Učitel {name} zaútočil na učitele {ucitel.name} s útočnou sílou {atkDmg}. Bránící se učitel má nyní {ucitel.ActualHP} HP");
        }

        public void BranSe(int atkDmg)
        {
            //       ActualHP -= Math.Clamp(atkDmg - armor, 0, int.MaxValue);
            int endDmg = (atkDmg - armor) < 0 ? 0 : (atkDmg - armor);
            ActualHP -= endDmg;
        }
    }
    public enum Role
    {
        Tank,
        Mage,
        Assasin
    }
}
