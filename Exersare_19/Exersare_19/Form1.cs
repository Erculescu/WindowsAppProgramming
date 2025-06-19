using System.Windows.Forms.VisualStyles;

namespace Exersare_19
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {

            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Id Companie", 200);
            listView1.Columns.Add("Denumire Companie", 200);
            listView1.Columns.Add("Nr Angajati", 200);
            Afisare();
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem stergere=new ToolStripMenuItem("Stergere");
            contextMenuStrip.Items.Add(stergere);
            listView1.ContextMenuStrip = contextMenuStrip;
            stergere.Click += (s, e) =>
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    foreach(ListViewItem item in listView1.SelectedItems)
                    {
                        listView1.Items.Remove(item);
                    }
                }
            };
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Afisare();

        }
        private void Afisare()
        {
            listView1.Items.Clear();
            foreach(var companie in Program.companii.Values)
            {
                ListViewItem item = new ListViewItem(new string[] { companie.id.ToString(), companie.denumire, companie.angajati.Count.ToString() });
                item.Tag = companie;
                listView1.Items.Add(item);
            }
        }
    }
}
