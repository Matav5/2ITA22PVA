namespace _2ITAOpakOOP
{
    public partial class Form1 : Form
    {
        List<Brick> bricks = new List<Brick>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Random r = new Random();
                int width = r.Next(10, 51);
                Brick brick = new Brick(e.X, e.Y, width, r.Next(10, 51));
                bricks.Add(brick);
                Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Brick brick in bricks)
            {
                brick.Draw(e.Graphics);
            }
           // e.Graphics.FillRectangle(Brushes.OrangeRed, x, y, width, height);  
        }
    }
}