namespace _2ITAObrazky
{
    public partial class Form1 : Form
    {
        Image image;
        Dictionary<string, Image> slovnikObrazku = new Dictionary<string, Image>();
        public Form1()
        {
            InitializeComponent();

            Image obrazekShrek = Image.FromFile("Obrazky 2ITA\\shrek.jpg");
            slovnikObrazku.Add("shrek",obrazekShrek);
            slovnikObrazku.Add("zlobr",obrazekShrek);
            
            Image obrazekJohnWick = Image.FromFile("Obrazky 2ITA\\john_wick.jpg");
            slovnikObrazku.Add("john wick", obrazekJohnWick);
            slovnikObrazku.Add("baba yaga", obrazekJohnWick);

            Random r = new Random();
            image = slovnikObrazku.ElementAt(r.Next(0, slovnikObrazku.Count)).Value;
            CreateNewImage();
        }

        private void CreateNewImage()
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image,50,100,200,150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (image == slovnikObrazku[textBox1.Text])
                {
                    MessageBox.Show("Vyhrál jsi!", "Jsi supr!");
                    Application.Exit();
                }
                else
                {

                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Neumíš psát! Žádný takový jméno neexistuje", "Jsi k ničemu");
            }
        }
    }
}