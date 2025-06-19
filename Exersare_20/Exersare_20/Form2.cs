using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersare_20
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            List<Produs>produse=new List<Produs>();
            produse.Add(new Produs("produs1", 100.5m, 2));
            produse.Add(new Produs("produs2", 300.5m, 4));
            produse.Add(new Produs("produs3", 50.5m, 1));
            comboBox1.DataSource= produse;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string linie = comboBox1.SelectedItem.ToString();
            string[] tokens = linie.Split(",");
            Program.cosCumparaturi.AdaugaProdus(new Produs(tokens[0], decimal.Parse(tokens[1]), int.Parse(tokens[2])));
            this.Close();

        }
    }
}
