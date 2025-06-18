using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersare_12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            List<string> marci = new List<string> { "Audi", "BWM", "Volkswagen", "Porsche", "Bentley", "Mercedes", "Toyota" };
            listBox1.DataSource = marci;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var flag = 0;
            string serie = textBoxVin.Text;
            string marca = listBox1.SelectedItem.ToString();
            string model = textBoxModel.Text;
            int an = int.Parse(textBoxAn.Text);
            decimal pret = decimal.Parse(textBoxPret.Text);
            Program.reprezentanta.AdaugaVehicul(new Vehicul(serie, marca, model, an, pret));
            this.Close();

        }
    }
}
