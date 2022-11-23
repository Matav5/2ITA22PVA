namespace _2ITASpiral
{
    public partial class Form1 : Form
    {
        Spiral spiral;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(spiral != null)
                spiral.Draw(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateSpiral(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateSpiral(1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateSpiral(2);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateSpiral(3);

        }
        public void CreateSpiral(int dir)
        {
            spiral = new Spiral(pictureBox1.Width / 2, pictureBox1.Height / 2, (int)numericUpDown1.Value, dir);
            Refresh();
        }
        int smer = 0;
        public void Move()
        {
            smer++;
            smer %= 4;
            CreateSpiral(smer);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Move();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
    }
}