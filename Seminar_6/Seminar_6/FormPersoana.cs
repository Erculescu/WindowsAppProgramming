using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_6
{
    public partial class FormPersoana : Form
    {
        public FormPersoana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public persoana GetPersoana()
        {
            var persoana = new persoana();
            persoana.Nume = txtNume.Text;
            if (radioFeminin.Checked)
            {
                persoana.Sex = Sex.Feminin;
            }
            else
            {
                persoana.Sex = Sex.Masculin;
            }
            return persoana;
        }
    }
}
