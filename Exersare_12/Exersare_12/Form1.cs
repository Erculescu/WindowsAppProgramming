using Microsoft.Data.Sqlite;
using System.Drawing.Printing;

namespace Exersare_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Afisare();
        }
        public void Afisare()
        {
            dataGridView1.Rows.Clear();
            foreach (Vehicul v in Program.reprezentanta.vehicule)
            {
                int rowIndex = dataGridView1.Rows.Add(v.serie, v.marca, v.model, v.pret);
                dataGridView1.Rows[rowIndex].Tag = v;
            }
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem stergere = new ToolStripMenuItem("Stergere rand");
            contextMenuStrip.Items.Add(stergere);
            dataGridView1.ContextMenuStrip = contextMenuStrip;
            stergere.Click += (s, e) =>
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            };
            printDocument.PrintPage += printarePagina;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Dictionary<string, decimal> preturiBrand = new Dictionary<string, decimal>();
            var total = 0m;
            foreach (Vehicul v in Program.reprezentanta.vehicule)
            {
                if (!preturiBrand.ContainsKey(v.marca))
                {
                    preturiBrand[v.marca] = 0;
                    preturiBrand[v.marca] += v.pret;
                }
                else { preturiBrand[v.marca] += v.pret; }
                total += v.pret;
            }
            var culori = new List<Brush> { Brushes.SteelBlue, Brushes.LightGreen, Brushes.Orange, Brushes.Brown, Brushes.Purple, Brushes.Cyan };
            var unghistart = 0f;
            var indexCuloare = 0;
            int dim = Math.Min(splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);
            foreach (var veh in preturiBrand.Keys)
            {
                var valoare = preturiBrand[veh];
                var unghi = (float)(valoare * 360 / total);
                e.Graphics.FillPie(culori[indexCuloare % culori.Count], 10, 10, dim - 20, dim - 20, unghistart, unghi);
                unghistart += unghi;
                indexCuloare++;

            }
            e.Graphics.FillRectangle(Brushes.White, splitContainer1.Panel2.Bounds);
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Afisare();
            splitContainer1.Panel2.Invalidate();
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SaveProduseToDB();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadProduseFromDB();
        }
        private void LoadProduseFromDB()
        {
            string conexiune = "Data Source=baza.db;";
            Program.reprezentanta.vehicule.Clear();
            using (SqliteConnection connection = new SqliteConnection(conexiune))
            {
                connection.Open();
                string cmd = "SELECT * FROM vehicule;";
                using (var comanda = new SqliteCommand(cmd, connection))
                using (var reader = comanda.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string serie = reader.GetString(0);
                        string marca = reader.GetString(1);
                        string model = reader.GetString(2);
                        int anFabricatie = reader.GetInt32(3);
                        decimal pret = reader.GetDecimal(4);
                        Program.reprezentanta.AdaugaVehicul(new Vehicul(serie, marca, model, anFabricatie, pret));

                    }
                }
            }
            Afisare();
        }
        private void SaveProduseToDB()
        {
            string conexiune = "Data Source=baza.db;";
            using (SqliteConnection connection = new SqliteConnection(conexiune))
            {
                connection.Open();
                string cmd = "DELETE FROM vehicule;";
                using (var cmdstergere = new SqliteCommand(cmd, connection))
                {
                    cmdstergere.ExecuteNonQuery();
                }
                foreach (Vehicul v in Program.reprezentanta.vehicule)
                {
                    cmd = "INSERT INTO vehicule (serie,marca,model,anFabricatie,pret) VALUES (@serie,@marca,@model,@anFabricatie,@pret);";
                    using (var comanda = new SqliteCommand(cmd, connection))
                    {
                        comanda.Parameters.AddWithValue("@serie", v.serie);
                        comanda.Parameters.AddWithValue("@marca", v.marca);
                        comanda.Parameters.AddWithValue("@model", v.model);
                        comanda.Parameters.AddWithValue("@anFabricatie", v.anFabricatie);
                        comanda.Parameters.AddWithValue("@pret", v.pret);
                        comanda.ExecuteNonQuery();
                    }
                }
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string linie = "";
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                linie += cell.Value.ToString() + "\t";
                            }
                            writer.WriteLine(linie.Trim());
                        }
                    }
                }
                MessageBox.Show("Datele au fost salvate cu succes!", "Salvare", MessageBoxButtons.OK);
            }

        }

        private void inserareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows.Clear();
                    Program.reprezentanta.vehicule.Clear();
                    using (StreamReader reader = new StreamReader(openFile.FileName))
                    {
                        string linie;
                        while ((linie = reader.ReadLine()) != null)
                        {
                            string[] tokens = linie.Split("\t");
                            Program.reprezentanta.AdaugaVehicul(new Vehicul(tokens[0], tokens[1], tokens[2], decimal.Parse(tokens[3])));
                        }
                    }
                }

                MessageBox.Show("Datele au fost inserate cu succes!", "Inserare", MessageBoxButtons.OK);

            }
            Afisare();
            splitContainer1.Panel2.Invalidate();

        }
        PrintDocument printDocument = new PrintDocument();
        string printtxt = "";
        private void printarePagina(object s, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printtxt, new Font("Arial", 12), Brushes.Black, 100, 100);
        }

        private void printareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printtxt = "";
            foreach(DataGridViewColumn column in dataGridView1.Columns)
            {
                printtxt += column.HeaderText + "\t";

            }
            printtxt += Environment.NewLine;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        printtxt += cell.Value.ToString() + "\t";

                    }
                    printtxt += Environment.NewLine;
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
