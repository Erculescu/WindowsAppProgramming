namespace Exersare_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpwd.Text;
            if (user == "admin" && pass == "1234")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else { MessageBox.Show("Login failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
