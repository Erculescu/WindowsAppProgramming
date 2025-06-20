using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersare_24
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imei = textBox1.Text;
            string denumire = textBox2.Text;
            decimal pret = decimal.Parse(textBox3.Text);
            foreach(var telefon in Program.magazin.telefoane)
            {
                if (telefon.imei == imei)
                {
                    MessageBox.Show("Telefonul cu acest IMEI exista deja!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Program.magazin.adaugaTelefon(new Telefon(imei, denumire, pret));

            this.Close();
        }
    }
}
