namespace Exersare_8
{
    public partial class Form1 : Form
    {
        public List<double> vector = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            string input = texBoxVect.Text;
            string[] tokens = input.Split(new char[] { '\n', ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            vector.Clear();
            foreach(string token in tokens)
            {
                if (double.TryParse(token, out double value))
                {
                    vector.Add(value);
                }
                else { MessageBox.Show("Input invalid!"); return; }

            }
            double suma = 0;
            foreach(double valoare in vector)
            {
                suma += valoare;
            }
            MessageBox.Show($"Suma vectorului este:{suma}","Rezultat",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
