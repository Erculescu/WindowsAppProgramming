namespace Exersare_7
{
    public partial class Form1 : Form
    {
        public List<Produs> produse = new List<Produs>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string linie = textBox1.Text;
            string[] date = linie.Split(",");
            if (date.Length == 5)
            {
                int id = int.Parse(date[0]);
                int cant = int.Parse(date[2]);
                double pret = double.Parse(date[3]);
                double greutate = double.Parse(date[4]);
                Produs prodTemp = new Produs(id, date[1], cant, pret, greutate);
                produse.Add(prodTemp);
                textBox1.Text = "";
            }
        }

        private void generareRaportStocuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Salve Report";
                saveFileDialog.Filter = "Text files (*.txxt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            foreach (Produs produs in produse)
                            {
                                writer.WriteLine($"ID: {produs.id}, Denumire: {produs.denumire}, Valoare Totala: {produs.cantitate * produs.pret}, Greutate totala: {produs.cantitate * produs.greutate}");

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Eroare la salvarea fisierului: {ex.Message}", "Error", MessageBoxButtons.OK);
                    }
                }
            }

        }

        private void generareRepartitieTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "Salvare Repartitie Transport";
                save.Filter = "Text files(*.txt)|*.txt|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string filename = save.FileName;
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filename))
                        {
                            double greutatePalet = 0;
                            var greutateMaxima = 250;
                            var numarPaleti = 1;
                            double greutateRamasa = 0;
                            int bucatiRamase = 0;
                            writer.WriteLine($"Palet {numarPaleti}");
                            foreach (Produs produs in produse)
                            {
                                if (greutatePalet + produs.greutate * produs.cantitate <= greutateMaxima)
                                {
                                    greutatePalet += (produs.greutate * produs.cantitate);
                                    writer.WriteLine($"ID: {produs.id}, Denumire: {produs.denumire}, Cantitate: {produs.cantitate}, Greutate: {produs.greutate * produs.cantitate}");
                                }
                                else
                                {
                                    greutateRamasa = greutateMaxima - greutatePalet;
                                    bucatiRamase = (int)(greutateRamasa / produs.greutate);
                                    if (bucatiRamase > 0)
                                    {
                                        greutatePalet =greutatePalet + bucatiRamase * produs.greutate;
                                        writer.WriteLine($"ID: {produs.id}, Denumire: {produs.denumire}, Cantitate: {bucatiRamase}, Greutate: {produs.greutate * bucatiRamase}");
                                        writer.WriteLine($"Greutate totala Palet: {greutatePalet}");
                                        numarPaleti++;
                                        writer.WriteLine($"Palet {numarPaleti}");
                                        greutatePalet = 0;
                                        if (produs.cantitate - bucatiRamase > 0)
                                        {
                                            int cantitateRamasa = produs.cantitate - bucatiRamase;
                                            writer.WriteLine($"ID: {produs.id}, Denumire: {produs.denumire}, Cantitate: {cantitateRamasa}, Greutate: {produs.greutate * cantitateRamasa}");
                                            greutatePalet += (produs.greutate * cantitateRamasa);
                                        }
                                    }
                                    else
                                    {
                                        writer.WriteLine($"Greutate totala Palet: {greutatePalet}");
                                        numarPaleti++;
                                        writer.WriteLine($"Palet {numarPaleti}");
                                        greutatePalet = 0;
                                        if (greutatePalet + produs.greutate * produs.cantitate <= greutateMaxima)
                                        {
                                            greutatePalet += (produs.greutate * produs.cantitate);
                                            writer.WriteLine($"ID: {produs.id}, Denumire: {produs.denumire}, Cantitate: {produs.cantitate}, Greutate: {produs.greutate * produs.cantitate}");
                                        }

                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Eroare la salvarea fisierului: {ex.Message}", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
