namespace Exersare_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("IMEI", 200);
            listView1.Columns.Add("Denumire", 300);
            listView1.Columns.Add("Pret", 200);
            Afisare();
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem sterge = new ToolStripMenuItem("Sterge");
            ToolStripMenuItem modifica = new ToolStripMenuItem("Modifica");
            contextMenu.Items.Add(sterge);
            contextMenu.Items.Add(modifica);
            listView1.ContextMenuStrip = contextMenu;
            sterge.Click += (s, e) =>
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        Telefon telefon = (Telefon)item.Tag;
                        Program.magazin.telefoane.Remove(telefon);
                    }
                    Afisare();
                }
            };
            modifica.Click += (s, e) =>
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        Telefon telefon = (Telefon)item.Tag;
                        Form3 form3 = new Form3(Program.magazin, telefon);
                        form3.ShowDialog();
                        Afisare();
                    }
                }
            };
        }
        private void Afisare()
        {
            listView1.Items.Clear();
            foreach (var telefon in Program.magazin.telefoane)
            {
                ListViewItem item = new ListViewItem(new string[] { telefon.imei, telefon.denumire, telefon.pret.ToString() });
                item.Tag = telefon;
                listView1.Items.Add(item);
            }
            label1.Text = "Valoare stoc: " + Program.magazin.stoc.ToString();

        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Afisare();
        }

        private void exportaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(save.FileName))
                    {
                        writer.WriteLine("Stocul magazinului:" + Program.magazin.denumire);
                        foreach (var telefon in Program.magazin.telefoane)
                        {
                            writer.WriteLine(telefon.ToString());
                        }
                    }
                }
                MessageBox.Show("Export complet!", "Info", MessageBoxButtons.OK);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in listView1.SelectedItems)
                {
                    Telefon telefon = (Telefon)item.Tag;
                    Form3 form3 = new Form3(Program.magazin, telefon);
                    form3.ShowDialog();
                    Afisare();
                }
            }
        }
    }
}
