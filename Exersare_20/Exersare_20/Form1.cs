namespace Exersare_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Afisare();
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem stergereProdus = new ToolStripMenuItem("Stergere produs");
            contextMenuStrip.Items.Add(stergereProdus);
            dataGridView1.ContextMenuStrip = contextMenuStrip;
            stergereProdus.Click += (s, e) =>
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow rand in dataGridView1.SelectedRows)
                    {
                        if (!rand.IsNewRow)
                        {
                            dataGridView1.Rows.Remove(rand);
                        }
                    }
                }
            };
        }
        private void Afisare()
        {
            dataGridView1.Rows.Clear();
            foreach (var produs in Program.cosCumparaturi.produse)
            {
                int rowindex = dataGridView1.Rows.Add(produs.denumire, produs.pret, produs.cantitate);
                dataGridView1.Rows[rowindex].Tag = produs;
            }
            int valoareTotala = (int)Program.cosCumparaturi.valoareTotala;
            progressBar1.Value = Math.Min(progressBar1.Maximum, Math.Max(0, valoareTotala));
            label1.Text = $"Valoare totala {valoareTotala} lei";
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Afisare();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow rand in dataGridView1.SelectedRows)
                {
                    if (!rand.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(rand);
                    }
                }
            }
        }
    }
}
