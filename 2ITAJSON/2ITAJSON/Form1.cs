namespace _2ITAJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VytvorZbran(30, 30, 35, "AK-47", TypZbrane.AR);

        }
        public void VytvorZbran(int kapacitaNaboju, int aktualniNaboje, int poskozeni, string jmenoZbrane, TypZbrane typZbrane)
        {
            Label label = new Label();
            Zbran zbran = new Zbran(kapacitaNaboju,aktualniNaboje,poskozeni,jmenoZbrane,typZbrane, label);
            tableLayoutPanel1.Controls.Add(label);
        }

    }
}