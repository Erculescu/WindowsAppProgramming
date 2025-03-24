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
                MessageBox.Show(File.ReadAllText(formular.FileName));
            }
        }
    }
}
