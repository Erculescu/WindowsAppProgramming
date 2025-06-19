using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersare_23
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nrApt =(int) numericUpDown1.Value;
            string proprietar = textBox1.Text;
            int suprafata = int.Parse(textBox2.Text);
            decimal intretinere = decimal.Parse(textBox3.Text);
            Program.bloc.adaugaApartament(new Apartament(nrApt, proprietar, suprafata, intretinere));
            this.Close();
        }
    }
}
