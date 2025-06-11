namespace Seminar_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Afisare();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void Afisare()
        {
            dataGridView1.Rows.Clear();
            foreach (var factura in Program.Facturi)
            {
                int rowIndex = dataGridView1.Rows.Add(factura.Cod, factura.Client, $"{factura.Valoare:n2}", $"{factura.Data:yyyy-MM-dd}");
                dataGridView1.Rows[rowIndex].Tag = factura;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            var clienti = new Dictionary<string, decimal>();
            var total = 0m;
            foreach(var factura in Program.Facturi)
            {
                if (!clienti.ContainsKey(factura.Client))
                {
                    clienti[factura.Client] = 0;
                }
                clienti[factura.Client] += factura.Valoare;
                total += factura.Valoare;
            }
            var culori=new List<Brush> { Brushes.Red, Brushes.Green, Brushes.Blue, Brushes.Yellow, Brushes.Orange };
            var unghiStart = 0;
            var indexCuloare = 0;
            int dim= Math.Min(splitContainer1.Panel2.Width
             ,splitContainer1.Panel2.Height);
            foreach (var client in clienti.Keys)
            {
                var valoare = clienti[client];
                var unghiClient = (int)(valoare * 360 / total);
                e.Graphics.FillPie(culori[indexCuloare % culori.Count], 10,10,dim-20,dim-20, unghiStart, unghiClient);
                
                unghiStart += unghiClient;
                indexCuloare++;
            }

            e.Graphics.FillRectangle(Brushes.White, splitContainer1.Panel2.Bounds);
            //e.Graphics.FillPie(Brushes.Red, splitContainer1.Panel2.Width / 2, splitContainer1.Panel2.Height / 2,
               // 40, 40, 45, 360);
        }
    }
}
