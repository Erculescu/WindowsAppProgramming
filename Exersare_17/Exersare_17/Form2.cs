﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersare_17
{
    public partial class Form2 : Form
    {
        private Form1 forminstance;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            forminstance = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal latitudine = decimal.Parse(textBox2.Text);
            decimal longitudine = decimal.Parse(textBox3.Text);
            Locatie locatie = new Locatie(latitudine, longitudine, textBox1.Text);
            forminstance.traseu.AdaugaLocatie(locatie);
            this.Close();
        }
    }
}
