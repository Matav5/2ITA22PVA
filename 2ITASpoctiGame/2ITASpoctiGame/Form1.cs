namespace _2ITASpoctiGame
{
    public partial class Form1 : Form
    {
        Priklad priklad;
        public Form1()
        {
            InitializeComponent();
            /*  Priklad priklad = new Priklad(10, -5, Operator.Scitani);
             */
            VygenerujPriklad();
            label1.Text ="Výsledek: " + priklad.vysledek;
        }
        public void VygenerujPriklad()
        {
            Random rnd = new Random();
            priklad = new Priklad(
                rnd.Next(-100, 101),
                rnd.Next(-100, 101),
                (Operator)rnd.Next(0, 2),
                VygenerujPoziciVPoli(),
                VygenerujPoziciVPoli(),
                VygenerujPoziciVPoli()
                );

            //Operátory jsou fixní!
        }
        public Point VygenerujPoziciVPoli()
        {
            Random r = new Random();
            return new Point(
                r.Next(pictureBox1.Width),
                r.Next(pictureBox1.Height)
                );
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            priklad.Vykresli(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}