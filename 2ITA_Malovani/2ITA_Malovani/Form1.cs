namespace _2ITA_Malovani
{
    public partial class Form1 : Form
    {
        List<Obdelnik> obdelniky = new List<Obdelnik>();
        Obdelnik aktualniObdelnik;
        public Form1()
        {
            InitializeComponent();
            obdelniky.Add(
                new Obdelnik(50,
                80,
                120,
                180,
                Color.Pink,
                false
            ));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Obdelnik obdelnik in obdelniky)
            {
                obdelnik.Vykresli(e.Graphics);
            }
            if(aktualniObdelnik != null)
                aktualniObdelnik.Vykresli(e.Graphics);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            aktualniObdelnik = new Obdelnik(e.X, e.Y, 0, 0, Color.Black, true);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (aktualniObdelnik != null)
            {
                //Zvìtši zmenši obdelník
                aktualniObdelnik.ZmenaVelikosti(e.X,e.Y);
            }
            Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            obdelniky.Add(aktualniObdelnik);
            aktualniObdelnik = null;
        }
    }
}