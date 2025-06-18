namespace Exersare_15
{
    public partial class Form1 : Form
    {
        private static Dictionary<int,Tranzactie> tranzactii = new Dictionary<int, Tranzactie>();
        private static Dictionary<string,ExtrasCont> extrase = new Dictionary<string,ExtrasCont>();
        public Form1()
        {
            InitializeComponent();
            Afisare();
            comboBox1.Items.AddRange(tranzactii.Keys.Select(k => k.ToString()).ToArray());
            listView1.View = View.Details;
            listView1.Columns.Add("Nume Client",300);
            listView1.Columns.Add("Adresa",200);
            listView1.Columns.Add("Tranzactii", 200);
            AfisListView();
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem stergere = new ToolStripMenuItem("Sterge");
            ToolStripMenuItem modificare = new ToolStripMenuItem("Modifica");
            contextMenu.Items.AddRange(new ToolStripItem[] { stergere, modificare });
            listView1.ContextMenuStrip = contextMenu;
            stergere.Click += (s, e) =>
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        listView1.Items.Remove(item);
                        
                    }
                }

            };
            modificare.Click += (s, e) =>
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    listView1.SelectedItems[0].Text = form2.varModif;
                    
                }
            };
        }

        private void Afisare()
        {
            using (StreamReader reader = new StreamReader("date.txt"))
            {
                string linie;
                while ((linie = reader.ReadLine()) != null)
                {
                    string[] date = linie.Split(",");
                    int id = int.Parse(date[0]);
                    string iban = date[1];
                    string descriere = date[2];
                    double suma = double.Parse(date[3]);
                    DateTime data = DateTime.Parse(date[4]);
                    tranzactii[id]=new Tranzactie(id, iban, descriere, suma, data);
                }
            }

        }
        private void AfisListView()
        {
            listView1.Items.Clear();
            foreach(var extra in extrase)
            {
                ListViewItem item = new ListViewItem( new string[] {extra.Value.getnume(),extra.Value.getadresa(),extra.Value.getTranzactii()});
                item.Tag = extra.Value;
                listView1.Items.Add(item);
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string numeClient = textBox1.Text;
            string adresa = textBox2.Text;
            int index = comboBox1.SelectedIndex+1;
            if (extrase.ContainsKey(numeClient))
            {
                extrase[numeClient].AdaugaTranzactie(tranzactii[index]);
            }
            else
            {
                extrase[numeClient] = new ExtrasCont(numeClient, adresa);
                extrase[numeClient].AdaugaTranzactie(tranzactii[index]);
            }
            AfisListView();
        }
    }
}
