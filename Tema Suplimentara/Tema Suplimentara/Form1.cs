using System.Data.SQLite;
using System.Reflection;
using System.Drawing.Printing;

namespace Tema_Suplimentara
{
    public partial class Form1 : Form
    {
        Cos cos = new Cos();

        public Form1()
        {
            InitializeComponent();
            Afisare();
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem stergereItem = new ToolStripMenuItem("Stergere rand");
            contextMenu.Items.Add(stergereItem);
            dataGridView1.ContextMenuStrip = contextMenu;
            stergereItem.Click += (s, e) =>
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            };
            printDocument.PrintPage += PrintDocument_PrintPage;
        }
        void Afisare()
        {
            dataGridView1.Rows.Clear();
            foreach (var prod in Program.cos.produseCos)
            {
                int rowIndex = dataGridView1.Rows.Add(Program.cos.produseCos.IndexOf(prod), prod.DenumireProdus, prod.pretProdus, prod.cantitateProdus);
                dataGridView1.Rows[rowIndex].Tag = prod;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Afisare();
            splitContainer1.Panel2.Invalidate();
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            var produse = new Dictionary<string, decimal>();
            var total = 0m;
            foreach (var produs in Program.cos.produseCos)
            {
                if (!produse.ContainsKey(produs.DenumireProdus))
                {
                    produse[produs.DenumireProdus] = 0;
                }
                produse[produs.DenumireProdus] += produs.pretProdus * produs.cantitateProdus;
                total += produs.pretProdus * produs.cantitateProdus;
            }
            var culori = new List<Brush> { Brushes.Turquoise, Brushes.Red, Brushes.SaddleBrown, Brushes.SeaShell, Brushes.Silver };
            var unghiStart = 0;
            var indexCuloare = 0;
            int dim = Math.Min(splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);
            foreach (var prod in produse.Keys)
            {
                var valoare = produse[prod];
                var unghiProd = (int)(valoare * 360 / total);
                e.Graphics.FillPie(culori[indexCuloare % culori.Count], 10, 10, dim - 20, dim - 20, unghiStart, unghiProd);
                unghiStart += unghiProd;
                indexCuloare++;
            }
            e.Graphics.FillRectangle(Brushes.White, splitContainer1.Panel2.Bounds);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
        }



        private void dataGridView1_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Load products from database
            LoadProduseFromDatabase();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            base.OnFormClosing(e);
            SaveProduseToDatabase();
        }
        private void LoadProduseFromDatabase()
        {
            string connectionString = "Data Source=myDatabase.db;Version=3;";
            Program.cos.produseCos.Clear();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Conexiune la baza de date deschisa.");
                string query = "SELECT denumire, pret, cantitate FROM produse";
                using (var comanda = new SQLiteCommand(query, connection))
                using (var reader = comanda.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string denumire = reader.GetString(0);
                        decimal pret = reader.GetDecimal(1);
                        int cantitate = reader.GetInt32(2);
                        Program.cos.produseCos.Add(new Produs(denumire, pret, cantitate));
                    }
                }
            }
            Afisare();
        }
        private void SaveProduseToDatabase()
        {
            string connectionString = "Data Source=myDatabase.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Conexiune la baza de date deschisa.");
                string deleteQuery = "DELETE FROM produse";
                using (var comandastergere = new SQLiteCommand(deleteQuery, connection))
                {
                    comandastergere.ExecuteNonQuery();
                }
                foreach (var prod in Program.cos.produseCos)
                {
                    string insertQuery = "INSERT INTO produse(denumire,pret,cantitate) VALUES(@denumire,@pret,@cantitate)";
                    using (var comanda = new SQLiteCommand(insertQuery, connection))
                    {
                        comanda.Parameters.AddWithValue("@denumire", prod.DenumireProdus);
                        comanda.Parameters.AddWithValue("@pret", prod.pretProdus);
                        comanda.Parameters.AddWithValue("@cantitate", prod.cantitateProdus);
                        comanda.ExecuteNonQuery();
                    }
                }
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Salveaza Cosul";
                saveFileDialog.FileName = "cos.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (DataGridViewRow rand in dataGridView1.Rows)
                        {
                            if (!rand.IsNewRow)
                            {
                                string linie = "";
                                foreach (DataGridViewCell celula in rand.Cells)
                                {
                                    linie += celula.Value.ToString() + "\t";
                                }
                                writer.WriteLine(linie.Trim());
                            }
                        }
                    }
                    MessageBox.Show("Cosul a fost salvat cu succes!", "Salvare Cos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void inserareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Inserati cos";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows.Clear();
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            string linie = reader.ReadLine();
                            string[] valori = linie.Split('\t');
                            dataGridView1.Rows.Add(valori[0], valori[1], valori[2], valori[3]);
                        }
                    }
                }
                MessageBox.Show("Cosul a fost incarcat cu succes!", "Inserare Cos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        PrintDocument printDocument = new PrintDocument();
        string printText = "";
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printText, new Font("Arial", 10), Brushes.Black, 100, 100);
        }

        private void printareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printText = "";
            foreach(DataGridViewColumn col in dataGridView1.Columns)
            {
                printText += col.HeaderText + "\t";
            }
            printText += Environment.NewLine;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach(DataGridViewCell celula in row.Cells)
                    {
                        printText += (celula.Value?.ToString() ?? "") + "\t";
                    }
                    printText += Environment.NewLine;
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
