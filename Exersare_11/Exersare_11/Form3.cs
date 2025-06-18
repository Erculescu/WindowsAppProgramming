using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Exersare_11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();
            listBox1.DataSource = Program.studenti.Keys.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.studenti[int.Parse(listBox1.SelectedItem.ToString())].AdaugaNota(new Nota(int.Parse(listBox1.SelectedItem.ToString()), textBox1.Text, decimal.Parse(textBox2.Text)));
            this.Close();
        }
    }
}
