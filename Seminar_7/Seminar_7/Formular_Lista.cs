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
    public partial class Formular_Lista: Form
    {
        public Formular_Lista()
        {
            InitializeComponent();
            Afisare();

            Program.Model.Adaugare += Model_Adaugare;
            Program.Model.Incarcare += Model_Incarcare;
        }

        private void Model_Incarcare(object? sender, EventArgs e)
        {
            Afisare();
        }
        private void Model_Adaugare(object? sender,Persoana e)
        {
            textBox1.Text += Environment.NewLine + e.ToString();
        }
        void Afisare()
        {
            var builder = new StringBuilder();
            foreach (var persoana in Program.Model.Persoane)
            {
                builder.AppendLine(persoana.ToString());
            }
            textBox1.Text = builder.ToString();
        }
    }
}
