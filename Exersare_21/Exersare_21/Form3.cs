using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersare_21
{
    public partial class Form3 : Form
    {
        public Candidat candidat;
        public Form3(Candidat c)
        {
            InitializeComponent();
             candidat = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] optiuniText = textBox1.Text.Split(",");
            List<int> vectorOp = optiuniText.Select(int.Parse).ToList();
            candidat.setOptiuni(vectorOp);
            this.Close();
        }
    }
}
