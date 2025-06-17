using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersare_10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            List<string> denumiri = new List<string>();
            denumiri.Add("Minolta Dynax 500si");
            denumiri.Add("Chaika 3");
            denumiri.Add("Revue TL25");
            denumiri.Add("Nikon F3");
            denumiri.Add("Leica M6");
            denumiri.Add("Canon AE-1");
            denumiri.Add("Minolta X-700");
            listBox1.DataSource = denumiri;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            var flag = 0;
            foreach(Camera camera in Program.stoc.camere){
                if (camera.denumire.Equals(listBox1.Text))
                {   
                    int cantNoua = camera.cantitate + int.Parse(textBoxCantitate.Text);
                    decimal pretNou = decimal.Parse(textBoxPret.Text);
                    Program.stoc.camere.Remove(camera);
                    Program.stoc.adaugaCamera(new Camera(listBox1.Text, pretNou, cantNoua));
                    flag = 1;
                }
               
            }
            if (flag == 0)
            {
                Program.stoc.adaugaCamera(new Camera(listBox1.Text, decimal.Parse(textBoxPret.Text), int.Parse(textBoxCantitate.Text)));

            }
            this.Close();
        }
    }
}
