namespace Exersare_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (operatie.Text)
            {
                case "+":
                    rez.Text = (Convert.ToDouble(nr1.Text) + Convert.ToDouble(nr2.Text)).ToString();
                    break;

                case "-":
                    rez.Text = (Convert.ToDouble(nr1.Text) - Convert.ToDouble(nr2.Text)).ToString();
                    break;

                case "*":
                    rez.Text = (Convert.ToDouble(nr1.Text) * Convert.ToDouble(nr2.Text)).ToString();
                    break;
                case "/":
                    rez.Text = (Convert.ToDouble(nr1.Text) / Convert.ToDouble(nr2.Text)).ToString();
                    break;
                case "^":
                    rez.Text = (Math.Pow(Convert.ToDouble(nr1.Text), Convert.ToDouble(nr2.Text))).ToString();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nr1.Text = rez.Text;
        }
    }
}
