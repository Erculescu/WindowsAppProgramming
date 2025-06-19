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
    public partial class Form2 : Form
    {
        private List<Candidat> candidatiform = new List<Candidat>();
        public Form2(List<Candidat>  candidati)
        {
            InitializeComponent();
            this.candidatiform = candidati;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(textBox1.Text);
            string nume = textBox2.Text;
            float medie = float.Parse(textBox3.Text);
            string[] optiuniText = textBox4.Text.Split(",");
            List<int> vectorOptiuni = optiuniText.Select(int.Parse).ToList();
            candidatiform.Add(new Candidat(cod, nume, medie, vectorOptiuni));
            this.Close();
        }
    }
}
