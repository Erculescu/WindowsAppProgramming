using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_Suplimentara
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();;
            List<string> denumiri = new List<string>();
            denumiri.Add("Laptop");
            denumiri.Add("Telefon");
            denumiri.Add("Tableta");
            denumiri.Add("Imprimanta");
            
            listBox1.DataSource = denumiri;

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            var flag = 0;
            foreach(Produs prod in Program.cos.produseCos)
            {
                if(listBox1.Text.Equals(prod.DenumireProdus))
                {
                    int cantNoua = int.Parse(textBoxCant.Text);
                    prod.cantitateProdus += cantNoua;
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Program.cos.produseCos.Add(new Produs(listBox1.Text, decimal.Parse(textBoxPret.Text), int.Parse(textBoxCant.Text)));
            }
            
            this.Close();
            
        }
    }
}
