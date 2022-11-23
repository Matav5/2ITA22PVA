namespace _2ITAGameOfLife
{
    public partial class Form1 : Form
    {
        Cell[,] cells;
        int cellWidth;
        int cellHeight;
        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            cells = new Cell[100, 100];
            Random r = new Random();
            bool isAlive;
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    isAlive = r.Next(0, 101) < 75;
                    cells[i, j] = new Cell(j, i, isAlive);
                }
            }
            cellWidth = pictureBox1.Width / cells.GetLength(1);
            cellHeight = pictureBox1.Height/ cells.GetLength(0);
            timer1.Enabled = true;
            Refresh();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (cells != null)
            {
                foreach (Cell cell in cells)
                {
                    cell.Draw(e.Graphics, cellWidth, cellHeight);
                    //https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life
                    // TODO: Vykreslování  cell.Draw(e.Graphics, width, height);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameUpdate();
        }

        private void GameUpdate()
        {
            //Kolik má buňka sousedů
            //Přežit podle pravidel
            //.....
            //Překreslilo
            Cell[,] bufferCells = new Cell[100, 100];

            for (int i = 0; i < bufferCells.GetLength(0); i++)
            {
                for (int j = 0; j < bufferCells.GetLength(1); j++)
                {
                    bufferCells[i, j] = new Cell(j, i, ShouldBeAlive(cells[i,j]) );
                }
            }

            cells = bufferCells;

            Refresh();
        }
        private bool ShouldBeAlive(Cell cell)
        {
           int neighboursAlive = CountNeighbours(cell);
            if (cell.isAlive)
            {
                //Podlidnění
                if (neighboursAlive < 2)
                    return false;

                //Přežije
                if(neighboursAlive == 2 || neighboursAlive == 3)        
                    return true;

                //Přelidnění
                return false;
            }
            else
            {
                //Oživení
                if (neighboursAlive == 3)
                    return true;

                //Zůstaň mrtvej
                return false;
            }

        }
        private int CountNeighbours(Cell cell)
        {
            int neighbourCount = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    //Kontroluju jestli je v poli
                    if (cell.x + j >= 0 && cell.x + j < cells.GetLength(1)
                        &&
                        cell.y + i >= 0 && cell.y + i < cells.GetLength(0)
                        ) {
                        //Kontroluju jestli buňka není prostředek a pokud je naživu
                        if (!(i == 0 && j == 0) && cells[cell.y + i, cell.x + j].isAlive)
                        { 
                            neighbourCount++;
                        }
                    }
                }
            }
            return neighbourCount;
        }
    }
}