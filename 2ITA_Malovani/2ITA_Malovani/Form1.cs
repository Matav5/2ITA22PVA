namespace _2ITA_Malovani
{
    public partial class Form1 : Form
    {
        List<Tvar> tvary = new List<Tvar>();
        Tvar aktualniTvar;
        Color aktualniBarva = Color.Black;
        TypTvaru typTvaru = TypTvaru.Obdelnik;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Tvar tvar in tvary)
            {
                tvar.Vykresli(e.Graphics);
            }
            if (aktualniTvar != null)
                aktualniTvar.Vykresli(e.Graphics);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            VytvorTvar(e.X,e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (aktualniTvar != null)
            {
                //Zvìtši zmenši obdelník
                aktualniTvar.ZmenaVelikosti(e.X, e.Y);
            }
            Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (aktualniTvar != null)
            {
                tvary.Add(aktualniTvar);
                aktualniTvar = null;
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                aktualniBarva = colorDialog1.Color;
                pictureBox2.BackColor = aktualniBarva;
            }

        }
        public void VytvorTvar(int x, int y)
        {
            //Switch
            switch (typTvaru)
            {
                case TypTvaru.Obdelnik:
                    aktualniTvar = new Obdelnik(x, y, 0, 0, aktualniBarva, checkBox1.Checked);
                    break;
                case TypTvaru.Kolecko:
                    aktualniTvar = new Kolecko(x, y, 0, 0, aktualniBarva, checkBox1.Checked);
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            typTvaru = TypTvaru.Obdelnik;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            typTvaru = TypTvaru.Kolecko;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            typTvaru = TypTvaru.Cara;
        }
    }
    public enum TypTvaru
    {
        Obdelnik,
        Kolecko,
        Cara,
        Hvezdicka,
        Trojuhelnik
    }
}