using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITAJSON
{
    internal class Zbran
    {
        private int kapacitaNaboju;
        public int KapacitaNaboju => kapacitaNaboju;

        private int aktualniNaboje;

        public int AktualniNaboje => aktualniNaboje;

        private int poskozeni;
        public int Poskozeni => poskozeni;
        private string jmenoZbrane;
        public string JmenoZbrane => jmenoZbrane;

        private TypZbrane typZbrane;
        public TypZbrane TypZbrane => typZbrane;
        private Label label;
        public Zbran()
        {


        }
        public Zbran(int kapacitaNaboju, int aktualniNaboje, int poskozeni, string jmenoZbrane, TypZbrane typZbrane, Label label)
        {
            this.kapacitaNaboju = kapacitaNaboju;
            this.aktualniNaboje = aktualniNaboje;
            this.poskozeni = poskozeni;
            this.jmenoZbrane = jmenoZbrane;
            this.typZbrane = typZbrane;
            this.label = label;
            this.label.AutoSize = true;
            UpdateLabel();
        }
        public void UpdateLabel()
        {
            label.Text = $"{jmenoZbrane} \n Kapacita: {aktualniNaboje}\\{kapacitaNaboju} \n Poškození: {poskozeni} \n Typ: {typZbrane}";
        }

        public void SetLabel(Label label)
        {
            this.label = label;
            this.label.AutoSize = true;
            UpdateLabel();
        }
    }
    public enum TypZbrane
    {
        Pistole,
        SMG,
        AR,
        Brokovnice,
        Sniper,
        LMG
    }
}
