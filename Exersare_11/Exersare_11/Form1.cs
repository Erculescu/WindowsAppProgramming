using System.Drawing.Printing;

namespace Exersare_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Afiseaza();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }
        public void Afiseaza()
        {
            dataGridView1.Rows.Clear();
            foreach (Student s in Program.studenti.Values)
            {
                int rowindex = dataGridView1.Rows.Add(s.idStudent, s.Nume, s.Medie(), s.note.Count);
                dataGridView1.Rows[rowindex].Tag = s;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            var studsortati = Program.studenti.Values.OrderByDescending(s => s.Medie()).ToList();
            if (studsortati.Count == 0) return;
            int barh = 25;
            int spacing = 10;
            int maxw = splitContainer1.Panel2.Width - 300;
            Font font = new Font("Arial", 10);
            Brush textBrush = Brushes.Black;
            Brush barBrush = Brushes.SteelBlue;
            decimal maxMedie = studsortati.Max(s => s.Medie());
            for (int i = 0; i < studsortati.Count; i++)
            {
                Student studTemp = studsortati[i];
                decimal medie = studTemp.Medie();
                int barw = (int)(maxw * (medie / maxMedie));
                int x = 245;
                int y = i * (barh + spacing);
                g.DrawString(studTemp.Nume, font, textBrush, 5, y + 5);
                g.FillRectangle(barBrush, x, y, barw, barh);
                g.DrawString(medie.ToString("0.00"), font, textBrush, x + barw + 5, y + 5);
            }

        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Afiseaza();
            splitContainer1.Panel2.Invalidate();
        }



        private void adaugaNoteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            Afiseaza();
            splitContainer1.Panel2.Invalidate();
        }
        PrintDocument printDocument = new PrintDocument();
        string printtxt = "";
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printtxt, new Font("Arial", 10), Brushes.Black, 100, 200);
        }

        private void printareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printtxt = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        printtxt += cell.Value.ToString() + "\t";
                    }
                    printtxt += Environment.NewLine;
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

        private void exportaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FileName = "export.txt";
                saveFileDialog.Title = "Exporta datele";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (Student stud in Program.studenti.Values)
                        {
                            writer.WriteLine(stud.idStudent + "," + stud.Nume + "," + stud.Medie() + "," + stud.note.Count);
                            foreach (Nota nota in stud.note)
                            {
                                writer.WriteLine(nota.idStudent + "," + nota.Materie + "," + nota.nota);
                            }
                        }
                    }
                    MessageBox.Show("Datele au fost exportate cu Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void importaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                //openfiledialog.Filter = "Text files";
                openfiledialog.Title = "Importa datele";
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows.Clear();
                    Program.studenti.Clear();
                    using (StreamReader reader = new StreamReader(openfiledialog.FileName))
                    {
                        string linie;
                        while ((linie = reader.ReadLine()) != null)
                        {
                            string[] tokens = linie.Split(",");
                            int id = int.Parse(tokens[0]);
                            string nume = tokens[1];
                            decimal medie = decimal.Parse(tokens[2]);
                            int noteCount = int.Parse(tokens[3]);
                            Program.studenti.Add(id, new Student(id, nume));
                            for (int i = 0; i < noteCount; i++)
                            {
                                linie = reader.ReadLine();
                                if (linie != null)
                                {
                                    string[] notatok = linie.Split(",");
                                    int idStud = int.Parse(notatok[0]);
                                    string materie = notatok[1];
                                    decimal nota = decimal.Parse(notatok[2]);
                                    Program.studenti[id].AdaugaNota(new Nota(idStud, materie, nota));
                                }

                            }
                        }
                    }
                    Afiseaza();
                    splitContainer1.Panel2.Invalidate();
                    MessageBox.Show("Datele au fost importate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
