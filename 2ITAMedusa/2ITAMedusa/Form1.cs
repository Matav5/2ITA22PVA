namespace _2ITAMedusa
{
    public partial class Form1 : Form
    {
        List<Medusa> medusas = new List<Medusa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var medusa in medusas)
            {
                medusa.Draw(e.Graphics);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            medusas.Add(new Medusa(r.Next(pictureBox1.Height), r.Next(pictureBox1.Height), 1));

        }
    }
}