﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersare_11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bttnadauga_Click(object sender, EventArgs e)
        {
            int cod =int.Parse( textBox1.Text);
            if (!Program.studenti.ContainsKey(cod))
            {
                Program.studenti.Add(cod, new Student(cod, textBox2.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Exista deja un student cu acest id!");
            }
        }
    }
}
