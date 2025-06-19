namespace Exersare_18
{
    public partial class Form1 : Form
    {
        private Cos cos = new Cos();
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Cod", 100);
            listView1.Columns.Add("Denumire", 300);
            listView1.Columns.Add("Pret", 100);
            Afiseaza();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(textBox1.Text);
            string denumire = textBox2.Text;
            decimal pret = decimal.Parse(textBox3.Text);
            cos.adaugaProdus(new Produse(cod, denumire, pret));
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            Afiseaza();
        }
        private void Afiseaza()
        {
            listView1.Items.Clear();
            foreach (var produs in cos.produse)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    produs.cod.ToString(),produs.denumire,produs.getPret().ToString()
                });
                item.Tag = produs;
                listView1.Items.Add(item);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count ==1 )
            {
                listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
                
            }
        }
    }
}
