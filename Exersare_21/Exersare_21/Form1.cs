namespace Exersare_21
{
    public partial class Form1 : Form
    {
        private List<Candidat> candidati = new List<Candidat>();
        private List<ProgramStudiu> programe = new List<ProgramStudiu>();
        public Form1()
        {
            InitializeComponent();
            candidati.Add(new Candidat(1, "Ion Ionescu", 9.5f));
            candidati.Add(new Candidat(2, "Maru Gagicaru", 6.66f));
            candidati.Add(new Candidat(3, "Ana Popescu", 8.74f));
            candidati.Add(new Candidat(4, "Maria Vasilescu", 7.5f));
            programe.Add(new ProgramStudiu(101, "Informatica", 10, 5));
            programe.Add(new ProgramStudiu(102, "Cibernetica", 9, 7));
            programe.Add(new ProgramStudiu(103, "Baze de date", 7, 3));
            listView1.View = View.Details;
            listView1.Columns.Add("Cod Candidat", 200);
            listView1.Columns.Add("Nume Candidat", 200);
            listView1.Columns.Add("Medie Concurs", 200);
            listView1.Columns.Add("Optiuni", 300);
            Afisare();
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem stergere = new ToolStripMenuItem("stergere candidat");
            ToolStripMenuItem modificare = new ToolStripMenuItem("modificare candidat");
            contextMenu.Items.Add(stergere);
            contextMenu.Items.Add(modificare);
            listView1.ContextMenuStrip = contextMenu;
            stergere.Click += (s, e) =>
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        listView1.Items.Remove(item);
                        candidati.Remove((Candidat)item.Tag);
                    }
                }
            };
            modificare.Click += (s, e) =>
            {

                if (listView1.SelectedItems.Count == 1)
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    Form3 form3 = new Form3((Candidat)item.Tag);
                    form3.ShowDialog();
                }

            };
        }
        private void Afisare()
        {
            listBox1.Items.Clear();
            foreach (ProgramStudiu program in programe)
            {
                listBox1.Items.Add(program.getCodProgram);
            }
            listView1.Items.Clear();
            foreach (Candidat c in candidati)
            {
                ListViewItem item = new ListViewItem(new string[] { c.getCodCandidat.ToString(), c.getNumeCandidat, c.getMedieConcurs.ToString(), string.Join(",", c.getVectorOptiuni) });
                item.Tag = c;
                listView1.Items.Add(item);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listBox1.SelectedItems.Count > 0)
                {
                    int codProgram = int.Parse(listBox1.SelectedItem.ToString());
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        Candidat c = (Candidat)item.Tag;
                        c.adaugaOptiune(codProgram);
                    }
                }
            }
            Afisare();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(candidati);
            form2.ShowDialog();
            Afisare();
        }
    }
}
