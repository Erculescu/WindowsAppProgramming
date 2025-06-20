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
    public partial class Form3 : Form
    {
        internal Magazin magazin1;
        internal Telefon telefon1;
        internal Form3(Magazin magazin, Telefon telefon)
        {
            InitializeComponent();
            magazin1 = magazin;
            telefon1 = telefon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var telefon in magazin1.telefoane)
            {
                if (telefon.imei == telefon1.imei)
                {
                    telefon.denumire = textBox1.Text;
                    telefon.pret = decimal.Parse(textBox2.Text);
                    break;
                }
            }
            this.Close();
        }
    }
}
