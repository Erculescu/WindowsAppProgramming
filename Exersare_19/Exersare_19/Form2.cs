using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersare_19
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.DataSource = Program.companii.Keys.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox1.SelectedItem.ToString());
            string nume = textBox1.Text;
            DateTime dataNasterii = monthCalendar1.SelectionStart;
            Angajat angajat = new Angajat(nume, dataNasterii, id);
            Program.companii[id].AdaugaAngajat(angajat);
            this.Close();
        }
    }
}
