namespace Seminar_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) - 1).ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
        }
    }
}
