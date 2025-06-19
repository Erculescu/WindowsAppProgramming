namespace Exersare_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Numar Apartament", 300);
            listView1.Columns.Add("Proprietar", 300);
            listView1.Columns.Add("Suprafata m^2", 300);
            listView1.Columns.Add("Intretinere", 200);
            Afisare();
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem stergere = new ToolStripMenuItem("Sterge Apartament");
            contextMenu.Items.Add(stergere);
            listView1.ContextMenuStrip = contextMenu;
            stergere.Click += (s, e) =>
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        Apartament apt = (Apartament)item.Tag;
                        Program.bloc.apartamente.Remove(apt);
                    }
                }
                Afisare();
            };
        }
        private void Afisare()
        {
            listView1.Items.Clear();
            foreach (var apt in Program.bloc.apartamente.OrderByDescending(a => a.suprafata))
            {
                ListViewItem item = new ListViewItem(new string[] { apt.numarApt.ToString(), apt.proprietar, apt.suprafata.ToString(), apt.intretinere.ToString() });
                item.Tag = apt;
                listView1.Items.Add(item);
            }
            label1.Text = "Total Suprafata: " + Program.bloc.suprafataTotala.ToString() + " m^2";
            label2.Text = "Total Intretinere: " + Program.bloc.totalIntretinere.ToString() + " lei";
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    Apartament apt = (Apartament)item.Tag;
                    Program.bloc.apartamente.Remove(apt);
                }
            }
            Afisare();
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Afisare();
        }
    }
}
