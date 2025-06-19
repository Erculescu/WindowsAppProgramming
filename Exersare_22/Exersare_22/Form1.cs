namespace Exersare_22
{
    public partial class Form1 : Form
    {
        List<Companie> companii = new List<Companie>();
        public Form1()
        {
            companii.Add(new Companie(1, "SC DCI SRL"));
            companii.Add(new Companie(2, "SC PMP SRL"));
            companii[0].adaugaAngajat(new Persoana(1, "Rares", 10000));
            companii[0].adaugaAngajat(new Persoana(2, "Ion", 17000));
            companii[1].adaugaAngajat(new Persoana(3, "Maria", 15000));
            InitializeComponent();
            Afiseaza();
            ContextMenuStrip context = new ContextMenuStrip();
            ToolStripMenuItem stergere = new ToolStripMenuItem("Stergere");
            context.Items.Add(stergere);
            dataGridView1.ContextMenuStrip = context;
            stergere.Click += (s, e) =>
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            };
        }
        private void Afiseaza()
        {
            dataGridView1.Rows.Clear();
            float valoare = 0;
            foreach (var companie in companii)
            {
                foreach (var angajat in companie.angajati)
                {
                    int rowindex = dataGridView1.Rows.Add(angajat.id, angajat.nume, angajat.salariu, companie.idCompanie);
                    dataGridView1.Rows[rowindex].Tag = companie;
                    valoare += (float)angajat.salariu;
                }
            }
            label1.Text = "Valoare totala salarii: " + valoare.ToString();
            progressBar1.Value = Math.Min(progressBar1.Maximum, Math.Max(progressBar1.Minimum, (int)valoare));
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete&&dataGridView1.SelectedRows.Count>0)
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
    }
}
