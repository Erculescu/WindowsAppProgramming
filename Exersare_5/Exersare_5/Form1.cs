namespace Exersare_5
{
    public partial class Form1 : Form
    {
        public List<Persoana> listaPersoane = new List<Persoana>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string[] token = input.Split(",");
            if (token.Length == 5)
            {
                string sex;
                if (radioFem.Checked)
                {
                    sex = "Feminin";
                }
                else
                {
                    sex = "Masculin";
                }
                int varsta = int.Parse(token[1]);
                float greutate = float.Parse(token[3]);
                int inaltime = int.Parse(token[4]);
                Persoana persoana = new Persoana(token[0], varsta, token[2], sex, greutate, inaltime);
                listaPersoane.Add(persoana);
                MessageBox.Show("Persoana adaugata cu succes!");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Format invalid!");
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All Files(*.*)|*.*";
                saveFileDialog.Title = "Alege unde se va salva raportul";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            foreach(Persoana persoana in listaPersoane)
                            {
                                writer.WriteLine($"Nume: {persoana.Nume}; Varsta: {persoana.Varsta}; Adresa: {persoana.Adresa}; Sex: {persoana.Sex}; Greutate: {persoana.Greutate}; Inaltime: {persoana.Inaltime}");
                            }
                        }
                        MessageBox.Show("Raport salvat cu succes!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Eroare la salvarea raportului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
