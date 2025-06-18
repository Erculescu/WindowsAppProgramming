using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersare_13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            Dictionary<int, int> kmPerBicicleta = new Dictionary<int, int>();
            var total = 0m;
            foreach(var b in Program.biciclete)
            {
                kmPerBicicleta[b.getcod()] = b.kmParcursi;
                total += b.kmParcursi;
            }
            var culori = new List<Brush> { Brushes.SteelBlue, Brushes.Orange, Brushes.Green, Brushes.Red, Brushes.Purple };
            var unghistart = 0f;
            var indexCuloare = 0;
            int dim = Math.Min(dataGridView1.Width, dataGridView1.Height);
            foreach(var bici in kmPerBicicleta.Keys)
            {
                var valoare = kmPerBicicleta[bici];
                var unghi = (float)(valoare * 360 / total);
                e.Graphics.FillPie(culori[indexCuloare], 10, 10, dim - 20, dim - 20, unghistart, unghi);
                unghistart += unghi;
                indexCuloare++;
            }
            
        }
    }
}
