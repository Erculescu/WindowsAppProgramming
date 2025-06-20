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
    public partial class Form3 : Form
    {
        private Student student;
        internal Form3(Student stud)
        {
            InitializeComponent();
            student = stud;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text;
            decimal punctaj = decimal.Parse(textBox2.Text);
            foreach(Student stud in Program.materie.studenti)
            {
                if (student.getNrMatricol()==stud.getNrMatricol())
                {
                    student.nume = nume;
                    student.punctaj = punctaj;
                    break;
                }
            }
            this.Close();
        }
    }
}
