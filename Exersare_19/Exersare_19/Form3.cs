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
    public partial class Form3 : Form
    {
        public int id { get; set; }
        public Form3(int cod)
        {
            InitializeComponent();
            id = cod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.companii[id].denumire = textBox2.Text;
            Program.companii[id].id = int.Parse(textBox1.Text);
            this.Close();
        }
    }
}
