namespace _2ITA_Malovani
{
    public partial class Form1 : Form
    {
        List<Tvar> tvary = new List<Tvar>();
        Tvar aktualniTvar;
        public Form1()
        {
            InitializeComponent();
            tvary.Add(
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
            foreach (Tvar tvar in tvary)
            {
                tvar.Vykresli(e.Graphics);
            }
            if(aktualniTvar != null)
                aktualniTvar.Vykresli(e.Graphics);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                aktualniTvar = new Obdelnik(e.X, e.Y, 0, 0, Color.Black, true);
            }
            else if(e.Button == MouseButtons.Right)
            {
                aktualniTvar = new Kolecko(e.X,e.Y,0,0, Color.Black, true);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (aktualniTvar != null)
            {
                //Zvìtši zmenši obdelník
                aktualniTvar.ZmenaVelikosti(e.X,e.Y);
            }
            Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            tvary.Add(aktualniTvar);
            aktualniTvar = null;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}