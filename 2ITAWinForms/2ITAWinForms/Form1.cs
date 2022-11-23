namespace _2ITAWinForms
{
    public partial class Form1 : Form
    {
        public Policko[,] herniPole;
        public Player player;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            //i = y (výška)
            //j = x (šířka)
            herniPole = new Policko[4, 6];
            for (int i = 0; i < herniPole.GetLength(0); i++)
            {
                for (int j = 0; j < herniPole.GetLength(1); j++)
                {
                    herniPole[i, j] = new Policko(j, i);
                }
            }
            herniPole[2, 4] = new Obstacle(4, 2);
            player = new Player(0, 2);
            Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            for (int i = 0; i < herniPole.GetLength(0); i++)
            {
                for (int j = 0; j < herniPole.GetLength(1); j++)
                {
                    herniPole[i, j].Draw(e.Graphics);
                }
            }
            player.Draw(e.Graphics);
        }

        public void MovePolicko(Policko policko, int smerX, int smerY)
        {

            if (policko.x + smerX < 0
               || policko.x + smerX > herniPole.GetLength(1) - 1
               || policko.y + smerY < 0
               || policko.y + smerY > herniPole.GetLength(0) - 1)
                return;
            //Out of bounds podmínky
            herniPole[policko.y, policko.x] = new Policko(policko.x, policko.y);
            policko.Move(smerX, smerY);
            herniPole[policko.y, policko.x] = policko;
            Refresh();
        }
        public void MovePlayer(int smerX, int smerY)
        {
            if (player.x + smerX < 0
              || player.x + smerX > herniPole.GetLength(1) - 1
              || player.y + smerY < 0
              || player.y + smerY > herniPole.GetLength(0) - 1)
                return;

            player.Move(smerX, smerY);

            //Checkuje kolizi, Updatne UI
            CheckForCollision();
            Refresh();
        }

        private void CheckForCollision()
        {
            herniPole[player.y, player.x].CollidesWith(player);
            CheckForChanges();
        }

        private void CheckForChanges()
        {
            if(player.lost)
            {
                if(MessageBox.Show("Jseš nula. Prohrál si se skórem ... Teď tvůj počítač zemře","Jseš nula", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    CheckForChanges();
                }
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                MovePlayer(0, -1);
            }
            else if (e.KeyCode == Keys.S)
            {
                MovePlayer(0, 1);
            }
            else if (e.KeyCode == Keys.A)
            {
                MovePlayer(-1, 0);
            }
            else if (e.KeyCode == Keys.D)
            {
                MovePlayer(1, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameUpdate();
        }

        private void GameUpdate()
        {
            //j = šířka
            //i = výška

            //Posunul celý herní pole o 1 šírku
            for (int j = 1; j < herniPole.GetLength(1); j++)
            {
                for (int i = 0; i < herniPole.GetLength(0); i++)
                {
                    herniPole[i, j - 1] = herniPole[i, j];
                    herniPole[i, j - 1].Move(-1, 0);
                }
            }

            Random rnd = new Random();
            //Poslední řada bude vyplněna políčkama
            for (int i = 0; i < herniPole.GetLength(0); i++)
            {
                if (rnd.Next(0, 100) < 20)
                {
                    herniPole[i, herniPole.GetLength(1) - 1]
                        = new Obstacle(herniPole.GetLength(1) - 1, i);
                }
                else
                {
                    herniPole[i, herniPole.GetLength(1) - 1]
                        = new Policko(herniPole.GetLength(1) - 1, i);
                }
            }
            CheckForCollision();
            Refresh();
        }
    }
}