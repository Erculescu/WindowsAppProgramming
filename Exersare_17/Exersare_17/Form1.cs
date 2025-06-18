namespace Exersare_17
{
    public partial class Form1 : Form
    {
        public Traseu traseu = new Traseu();

        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Denumire", 200);
            listView1.Columns.Add("Latitudine", 200);
            listView1.Columns.Add("Longitudine", 200);
            traseu.AdaugaLocatie(new Locatie(44.0m, 27.3m, "Voinesti"));
            traseu.AdaugaLocatie(new Locatie(43.7m, 26.3m, "Pantelimon"));
            traseu.AdaugaLocatie(new Locatie(44.3m, 27.6m, "Targoviste"));
            Afisare();
        }
        private void Afisare()
        {
            listView1.Items.Clear();
            foreach (var loc in traseu.locatii)
            {
                ListViewItem item = new ListViewItem(new string[] { loc.denumire, loc.Latitudine.ToString(), loc.Longitudine.ToString() });
                item.Tag = loc;
                listView1.Items.Add(item);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            Afisare();
        }
    }
}
