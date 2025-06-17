using Microsoft.Data.Sqlite;
using System.Drawing.Printing;

namespace Exersare_10
{
    public partial class Form1 : Form
    {
        Stoc stoc = new Stoc();
        public Form1()
        {
            InitializeComponent();
            Afisare();
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem stergere = new ToolStripMenuItem("Sterge");
            contextMenu.Items.Add(stergere);
            dataGridView1.ContextMenuStrip = contextMenu;
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
            printDocument.PrintPage += PrintDocument_PrintPage;
        }
        void Afisare()
        {
            dataGridView1.Rows.Clear();
            foreach (var camera in Program.stoc.camere)
            {
                int rowindex = dataGridView1.Rows.Add(Program.stoc.camere.IndexOf(camera), camera.denumire, camera.pret, camera.cantitate);
                dataGridView1.Rows[rowindex].Tag = camera;

            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush barbrush = Brushes.SteelBlue;
            Font labelfont = new Font("Arial", 8);
            Brush labelbrush = Brushes.Black;
            Stoc stoc = Program.stoc;
            if (stoc.camere.Count == 0) return;
            decimal maxVal = stoc.camere.Max(c => c.pret * c.cantitate);
            int barw = 40;
            int spacing = 10;
            int x = 10;
            int panelHeight = splitContainer1.Panel2.Height;
            foreach (var camera in stoc.camere)
            {
                decimal valoare = camera.pret * camera.cantitate;
                int barh = (int)((valoare / maxVal) * (panelHeight - 50));
                g.FillRectangle(barbrush, x, panelHeight - barh - 30, barw, barh);
                string label = $"{camera.denumire}";
                g.DrawString(label, labelfont, labelbrush, x, panelHeight - barh - 60);
                x += barw + spacing;
            }
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
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadCamereFromDB();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SaveCameraToDB();
        }
        private void LoadCamereFromDB()
        {
            string connection = "Data Source=baza.db;";
            Program.stoc.camere.Clear();
            using (var conn = new SqliteConnection(connection))
            {
                conn.Open();
                Console.WriteLine("Conectat");
                using (var cmd = new SqliteCommand("SELECT denumire,pret,cantitate FROM camere", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string denumire = reader.GetString(0);
                        decimal pret = reader.GetDecimal(1);
                        int cantitate = reader.GetInt32(2);
                        Program.stoc.adaugaCamera(new Camera(denumire, pret, cantitate));
                    }

                }
            }
            Afisare();
        }
        private void SaveCameraToDB()
        {
            string connection = "Data Source=baza.db;";
            using (var conn = new SqliteConnection(connection))
            {
                conn.Open();
                Console.WriteLine("Conectat");
                string deletecmd = "DELETE FROM camere";
                using (var cmds = new SqliteCommand(deletecmd, conn))
                {
                    cmds.ExecuteNonQuery();
                }
                foreach (var camera in Program.stoc.camere)
                {
                    string insertcmd = "INSERT INTO camere (denumire, pret, cantitate) VALUES (@denumire,@pret,@cantitate)";
                    using (var comanda = new SqliteCommand(insertcmd, conn))
                    {
                        comanda.Parameters.AddWithValue("@denumire", camera.denumire);
                        comanda.Parameters.AddWithValue("@pret", camera.pret);
                        comanda.Parameters.AddWithValue("@cantitate", camera.cantitate);
                        comanda.ExecuteNonQuery();
                    }
                }
            }
        }

        private void exportaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                save.Title = "Exporta datele intr-un fisier text";
                save.FileName = "camere.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(save.FileName))
                    {
                        foreach (var camera in Program.stoc.camere)
                        {
                            writer.WriteLine(camera.denumire + "," + camera.pret + "," + camera.cantitate);
                        }
                    }
                    MessageBox.Show("Datele au fost exportate cu succes!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void importaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfile = new OpenFileDialog())
            {
                openfile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openfile.Title = "Importa datele dintr-un fisier text";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows.Clear();
                    Program.stoc.camere.Clear();
                    using (StreamReader reader = new StreamReader(openfile.FileName))
                    {
                        string linie;
                        while ((linie = reader.ReadLine()) != null)
                        {
                            string[] tokens = linie.Split(",");
                            Program.stoc.adaugaCamera(new Camera(tokens[0], decimal.Parse(tokens[1]), int.Parse(tokens[2])));
                        }
                    }
                }
            }
            Afisare();
            splitContainer1.Panel2.Invalidate();
            MessageBox.Show("Datele au fost importate cu succes!", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        PrintDocument printDocument = new PrintDocument();
        string printtext = "";
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printtext, new Font("Arial", 10), Brushes.Black, 100, 200);
        }

        private void printareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printtext = "";
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        printtext += cell.Value.ToString() + "\t";
                    }
                    printtext += Environment.NewLine;
                }
            }
            using (PrintDialog print = new PrintDialog())
            {
                print.Document = printDocument;
                if (print.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }
    }
}
