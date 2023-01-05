using System.Text.Json;
using System.Text.Json.Serialization;

namespace _2ITAJSON
{
    public partial class Form1 : Form
    {
        List<Zbran> zbrane = new List<Zbran>();
        public Form1()
        {
            InitializeComponent();
            List<ZbranJSON> zbraneJson = NactiZeSouboru();
            if (zbraneJson.Count == 0)
            {
                VytvorZbran(30, 30, 35, "AK-47", TypZbrane.AR);
                VytvorZbran(100, 100, 15, "Negev", TypZbrane.LMG);
            }
            else
            {
                VytvorZbrane(zbraneJson);
            }
        }

        private void VytvorZbrane(List<ZbranJSON> zbraneJson)
        {
            for (int i = 0; i < zbraneJson.Count; i++)
            {
                VytvorZbran(zbraneJson[i]);
            }
        }

        private void VytvorZbran(ZbranJSON zbranJSON)
        {
            Label label = new Label();
            Zbran zbran = new Zbran(zbranJSON, label);
            tableLayoutPanel1.Controls.Add(label);
            zbrane.Add(zbran);
        }

        public void VytvorGrafiky()
        {
            for (int i = 0; i < zbrane.Count; i++)
            {
                Label label = new Label();
                zbrane[i].SetLabel(label);
                tableLayoutPanel1.Controls.Add(label);
            }
        }
        public void VytvorZbran(int kapacitaNaboju, int aktualniNaboje, int poskozeni, string jmenoZbrane, TypZbrane typZbrane)
        {
            Label label = new Label();
            Zbran zbran = new Zbran(kapacitaNaboju,aktualniNaboje,poskozeni,jmenoZbrane,typZbrane, label);
            tableLayoutPanel1.Controls.Add(label);
            zbrane.Add(zbran);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string json = JsonSerializer.Serialize(zbrane );
            MessageBox.Show(json);
            File.WriteAllText("zbrane.json", json);
        }
        private List<ZbranJSON> NactiZeSouboru()
        {
            if (!File.Exists("zbrane.json"))
                return new List<ZbranJSON>();
            string savedJson = File.ReadAllText("zbrane.json");
            List<ZbranJSON> zbraneJSON = JsonSerializer.Deserialize<List<ZbranJSON>>(savedJson);
            return zbraneJSON;
        }
    }
}