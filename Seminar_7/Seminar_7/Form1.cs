namespace Seminar_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formular = new Formular_Lista();
            formular.MdiParent = this;
            formular.Show();
        }

        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var formular = new OpenFileDialog();
            formular.Filter = "Text files(*.txt)|*.txt";
            if (formular.ShowDialog(this) == DialogResult.OK)
            {
                //MessageBox.Show(File.ReadAllText(formular.FileName));
                var lista = new List<Persoana>();
                foreach (var linie in File.ReadAllLines(formular.FileName))
                {
                    var elemente = linie.Split(',');
                    lista.Add(new Persoana()
                    {
                        Nume = elemente[0],
                        Varsta = int.Parse(elemente[1])
                    });
                }
                Program.Model.Incarca(lista);
            }
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formular = new FormAdaugare();
            formular.MdiParent = this;
            formular.Show();
        }

        private void anuleazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var formular = new SaveFileDialog();
            formular.Filter = "Text files (*.txt)|*.txt";
            if (formular.ShowDialog(this) == DialogResult.OK)
            {
                var lista = new List<string>();
                foreach(var persoana in Program.Model.Persoane)
                {
                    lista.Add($"{persoana.Nume},{persoana.Varsta}");

                }
                File.WriteAllLines(formular.FileName, lista);
            }
        }
    }
}
