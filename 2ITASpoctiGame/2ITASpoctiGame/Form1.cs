namespace _2ITASpoctiGame
{
    public partial class Form1 : Form
    {
        List<Priklad> priklady = new List<Priklad>();
        public int skore = 0;
        public Form1()
        {
            InitializeComponent();
            /*  Priklad priklad = new Priklad(10, -5, Operator.Scitani);
             */
            VygenerujPriklad(2);
        }
        public void VygenerujPriklad(int pocetPrikladu)
        {
            priklady.Clear();
            for (int i = 0; i < pocetPrikladu; i++)
            {
                VygenerujPriklad();
            }
        }
        public void VygenerujPriklad()
        {
            Random rnd = new Random();
            priklady.Add(new Priklad(
                rnd.Next(-100, 101),
                rnd.Next(-100, 101),
                (Operator)rnd.Next(0, 2),
                VygenerujPoziciVPoli(),
                VygenerujPoziciVPoli(),
                VygenerujPoziciVPoli(),
                Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))
                )
                );

            //Operátory jsou fixní!
        }
        public Point VygenerujPoziciVPoli()
        {
            Random r = new Random();
            return new Point(
                r.Next(pictureBox1.Width - 40),
                r.Next(pictureBox1.Height - 40)
                );
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Priklad priklad in priklady)
            {
                priklad.Vykresli(e.Graphics);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zkontroluj();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Zkontroluj();
            }
        }
        public void Zkontroluj()
        {
            string vstup = textBox1.Text;
            if(double.TryParse(vstup,out double vstupniCislo))
            {
                foreach (Priklad priklad in priklady)
                {
                    if (vstupniCislo == priklad.Vysledek)
                    {
                        //Odpovìdìl dobøe
                        skore+=priklady.Count;
                    }
                    else
                    {
                        //Odpovìdìl špatnì
                        skore--;
                    }
                }
            }
            else
            {
                skore--;
            }
            VygenerujPriklad(2);
            textBox1.Text = "";
            UpdateUI();
        }

        private void UpdateUI()
        {
            label1.Text = "Skóre: " + skore;
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}