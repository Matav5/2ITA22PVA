namespace _2ITAPuntikovac
{
    public partial class Form1 : Form
    {
        List<Hrisnik> seznamHrisniku = new List<Hrisnik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VytvorHrisnika();
        }

        private void VytvorHrisnika()
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Label label = new Label();
                label.Text = "Ahoj já jsem Jarda";
                label.Size = new Size(flowLayoutPanel1.Width - 25, 30);
                Hrisnik hrisnik = new Hrisnik(textBox1.Text,
                    (int)numericUpDown1.Value,
                    Color.Transparent,
                    label);
                flowLayoutPanel1.Controls.Add(label);
                seznamHrisniku.Add(hrisnik);
            }
        }
        private void UlozeniHrisniku()
        {
            string nasSejf = "";

            foreach (Hrisnik hrisnik in seznamHrisniku)
            {
                nasSejf += hrisnik.jmeno + "," + hrisnik.pocetPuntiku + "\n";
            }

            File.WriteAllText("save.txt", nasSejf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UlozeniHrisniku();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NacitaniHrisniku();
        }

        private void NacitaniHrisniku()
        {
           string[] radky = File.ReadAllLines("save.txt");
            for (int i = 0; i < radky.Length; i++)
            {
                Label label = new Label();
                label.Size = new Size(flowLayoutPanel1.Width - 25, 30);
                Hrisnik hrisnik = new Hrisnik(radky[i],label);
                flowLayoutPanel1.Controls.Add(label);
                seznamHrisniku.Add(hrisnik);
            }
        }
    }
}