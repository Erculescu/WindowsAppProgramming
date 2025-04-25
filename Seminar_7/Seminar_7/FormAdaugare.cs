using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_7
{
    public partial class FormAdaugare : Form
    {
        public FormAdaugare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Model.Adauga(new Persoana()
            {
                Nume = textBox1.Text,
                Varsta = (int)numericUpDown1.Value
            });
        }
    }
}
