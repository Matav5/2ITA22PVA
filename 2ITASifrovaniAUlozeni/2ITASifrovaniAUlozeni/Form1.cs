namespace _2ITASifrovaniAUlozeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Zasifruj();
        }

        private void Zasifruj()
        {
            string textNaSifrovani = richTextBox1.Text;
            int klic = radioButton2.Checked ? (int)numericUpDown1.Value * -1 : (int)numericUpDown1.Value;
            string zasifrovanyText = "";
            // J = 74 + klic
            for (int i = 0; i < textNaSifrovani.Length; i++)
            {
                zasifrovanyText += ZasifrujPismenko(textNaSifrovani[i], klic);
            }
            richTextBox2.Text = zasifrovanyText;
        }
        private char ZasifrujPismenko(char pismenko, int klic)
        {
            return (char)((int)pismenko + klic);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Zasifruj();
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(saveFileDialog1.FileName, richTextBox2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                Zasifruj();
                radioButton2.Checked = true;
            }
        }
    }
}