using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersare_25
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nrMat = int.Parse(textBox1.Text);
            string nume = textBox2.Text;
            decimal punctaj = numericUpDown1.Value/10;
            foreach(var student in Program.materie.studenti)
            {
                if (student.getNrMatricol() == nrMat)
                {
                    MessageBox.Show("Exista deja un student cu acest numar matricol!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Program.materie.adaugaStudent(new Student(nrMat, nume, punctaj));
            this.Close();
        }
    }
}
