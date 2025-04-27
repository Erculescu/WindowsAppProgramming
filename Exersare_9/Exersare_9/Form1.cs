namespace Exersare_9
{
    public partial class Form1 : Form
    {
        public List<Pizza> pizze = new List<Pizza>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            double cost = 0;
            switch (listBox1.Text)
            {
                case "Diavola":
                    cost = 35;
                    break;
                case "Quattro Stagioni":
                    cost = 40;
                    break;
                case "Carnivora":
                    cost = 38;
                    break;
                case "Hawaian":
                    cost = 42;
                    break;
            }
            if (txtAdresa.Text != "" && txtAdresa.Text != null)
            {
                cost += 12;
            }
            if (sosAlb.Checked || sosRosiiP.Checked)
            {
                cost += 6;
            }
            if (sosRosiiD.Checked)
            {
                cost += 4;
            }
            MessageBox.Show("Costul total este: " + cost.ToString() + " lei", "Cost total", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Tip tip = new Tip();
            switch (listBox1.Text)
            {
                case "Diavola":
                    tip = Tip.Diavola;
                    break;
                case "Quattro Stagioni":
                    tip = Tip.Quattro_Stagioni;
                    break;
                case "Carnivora":
                    tip = Tip.Carnivora;
                    break;
                case "Hawaian":
                    tip = Tip.Hawaian;
                    break;
            }
            string adresa = txtAdresa.Text;
            if (adresa == "" || adresa == null)
            {
                adresa = "Comanda cu ridicare";
            }
            Pizza pizzaTemp = new Pizza(adresa, tip, (sosAlb.Checked || sosRosiiP.Checked || sosRosiiD.Checked));
            pizze.Add(pizzaTemp);
        }

        private void generareRaportClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog save=new SaveFileDialog())
            {
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string locatie = save.FileName;
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(locatie))
                        {
                            Dictionary<string, int> clienti = new Dictionary<string, int>();
                            foreach(Pizza pizza in pizze)
                            {
                                if (clienti.ContainsKey(pizza.Adresa))
                                {
                                    clienti[pizza.Adresa]++;
                                }
                                else
                                {
                                    clienti.Add(pizza.Adresa, 1);
                                }

                            }
                            foreach(KeyValuePair<string,int> client in clienti)
                            {
                                sw.WriteLine("Client: " + client.Key + " - " + client.Value + " comenzi efectuate");
                            }
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Eroare la salvarea fisierului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
