namespace Seminar_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            var formular = new FormPersoana();

            if (formular.ShowDialog() == DialogResult.OK)
            {

                var persoana = formular.GetPersoana();
                persoane.Text += persoana + Environment.NewLine;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
