namespace Exersare_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Afisare();
            ContextMenuStrip context = new ContextMenuStrip();
            ToolStripMenuItem stergere = new ToolStripMenuItem("Stergere");
            context.Items.Add(stergere);
            dataGridView1.ContextMenuStrip = context;
            stergere.Click += (s, e) =>
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        var student = (Student)row.Tag;
                        Program.materie.studenti.Remove(student);
                    }
                }
                Afisare();

            };
        }
        private void Afisare()
        {
            dataGridView1.Rows.Clear();
            foreach (var student in Program.materie.studenti)
            {
                int rowindex = dataGridView1.Rows.Add(student.getNrMatricol(), student.nume, student.punctaj, Program.materie.denumire);
                dataGridView1.Rows[rowindex].Tag = student;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        var student = (Student)row.Tag;
                        Program.materie.studenti.Remove(student);
                    }
                }
                Afisare();
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Afisare();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Student student = (Student)row.Tag;
                    Form3 form3 = new Form3(student);
                    form3.ShowDialog();

                }
                Afisare();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var student in Program.materie.studenti)
                        {
                            writer.WriteLine(student.getNrMatricol() + "," + student.nume + "," + student.punctaj);
                        }
                    }
                }
                MessageBox.Show("Export realizat cu succes!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open=new OpenFileDialog())
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader=new StreamReader(open.FileName))
                    {
                        string linie;
                        while ((linie = reader.ReadLine()) != null)
                        {
                            string[] date = linie.Split(",");
                            int nrMatricol = int.Parse(date[0]);
                            string nume = date[1];
                            decimal punctaj = decimal.Parse(date[2]);
                            Program.materie.adaugaStudent(new Student(nrMatricol, nume, punctaj));
                        }
                    }
                    MessageBox.Show("Import realizat cu succes!", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Afisare();
        }
    }
}
