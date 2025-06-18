using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersare_14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            List<int> lista = new List<int>();
            for(int i = 1; i <= 100; i++)
            {
                lista.Add(i);
            }
            comboBox1.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox2.Text);
            string nume = textBox1.Text;
            decimal calificativ = decimal.Parse(comboBox1.SelectedItem.ToString());
            DateTime data = monthCalendar1.SelectionStart;
            Program.job.adaugaInterviu(new Interviu(id, nume, calificativ, data));
            this.Close();
        }
    }
}
