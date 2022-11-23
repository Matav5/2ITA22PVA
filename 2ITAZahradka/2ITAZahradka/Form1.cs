namespace _2ITAZahradka
{
    public partial class Form1 : Form
    {
        List<Kyticka> kytickas = new List<Kyticka>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                Random r = new Random();
                kytickas.Add(new Kyticka(e.X, e.Y, r.Next(10, 20)));
                Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var kyticka in kytickas)
            {
                kyticka.Draw(e.Graphics);
            }
        }
    }
}