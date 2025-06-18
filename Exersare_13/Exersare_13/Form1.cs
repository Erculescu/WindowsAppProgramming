using System.Drawing.Printing;

namespace Exersare_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView2.View = View.Details;
            listView1.Columns.Add("Cod");
            listView1.Columns.Add("Statia");
            listView1.Columns.Add("Km");
            listView2.Columns.Add("Nume");
            listView2.Columns.Add("Cod Bicicleta");
            listView2.Columns.Add("Durata");
            Afisare();
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem vizualizare = new ToolStripMenuItem("Vizualizare grafic");
            contextMenuStrip.Items.Add(vizualizare);
            this.ContextMenuStrip = contextMenuStrip;
            vizualizare.Click += (s, e) =>
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            };
            printDocument.PrintPage += printDocumet;
        }
        public void Afisare()
        {
            listView1.Items.Clear();


            foreach (Bicicleta b in Program.biciclete)
            {
                ListViewItem item = new ListViewItem(new string[] { b.getcod().ToString(), b.denumireStatie, b.kmParcursi.ToString() });
                item.Tag = b;
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedBicicleta = listView1.SelectedItems[0].Tag as Bicicleta;
                if (selectedBicicleta != null)
                {
                    textBox1.Clear();
                    decimal valoare = 0;
                    int cod = selectedBicicleta.getcod();
                    foreach (var u in Program.utilizatori.Where(u => u.codBici == cod))
                    {
                        var item = new ListViewItem(new string[] { u.nume, u.codBici.ToString(), u.durata.ToString() });
                        item.Tag = u;
                        listView2.Items.Add(item);
                        if (u.durata > 30)
                        {
                            valoare += (decimal)((u.durata - 30) / 10) * 2;

                        }
                    }
                    textBox1.Text = valoare.ToString();
                }
            }


        }
        PrintDocument printDocument = new PrintDocument();
        string printTxt = "";
        private void printDocumet(object s,PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printTxt, new Font("Arial", 12), Brushes.Black, 100, 100);
        }
        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printTxt = "";
            foreach(Bicicleta b in Program.biciclete)
            {
                printTxt += b.getcod().ToString() + "," + b.denumireStatie + "," + b.kmParcursi.ToString();
                printTxt += Environment.NewLine;
                foreach(Utilizator u in Program.utilizatori.Where(u => u.codBici == b.getcod()))
                {
                    printTxt += u.nume + "," + u.durata.ToString();
                    printTxt += Environment.NewLine;
                }
            }
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }

        }
    }
}
