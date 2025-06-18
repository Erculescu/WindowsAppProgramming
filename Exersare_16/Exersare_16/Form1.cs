namespace Exersare_16
{
    public partial class Form1 : Form
    {
        List<Poligon> poligoane = new List<Poligon>();
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Cod Poligon",200);
            listView1.Columns.Add("Culoare",200);
            listView1.Columns.Add("Grosime Linie", 200);
            listView1.Columns.Add("Puncte", 500);
            AfisListeView();
            generareSB();
        }
        private void AfisListeView()
        {
            listView1.Items.Clear();
            foreach(Poligon p in poligoane)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Codpoligon.ToString(), p.culoare.ToString(), p.grosimeLinie.ToString(), string.Join(",",p.puncte) });
                item.Tag = p;
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(textBox1.Text);
            Color culoare = Color.FromName(textBox2.Text);
            int grosime = int.Parse(textBox3.Text);
            string eticheta = textBox4.Text;
            string[] stringPct = textBox5.Text.Split(",");
            List<float> puncte = stringPct.Select(s => float.Parse(s)).ToList();
            poligoane.Add(new Poligon(cod, puncte, culoare, grosime, eticheta));
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            AfisListeView();
            generareSB();
        }
        private void generareSB()
        {
            float perimetruT = 0.0f;
            foreach(Poligon p in poligoane)
            {
                perimetruT += p.CalculeazaPerimetru();
            }
            if (poligoane.Count > 0)
            {
                progressBar1.Value =Math.Min( progressBar1.Maximum,Math.Max(progressBar1.Minimum,(int)(perimetruT / poligoane.Count)));
            }
            else
            {
                progressBar1.Value = progressBar1.Minimum;
            }
                label6.Text = $"Perimetrul total: {perimetruT}";
        }
    }
}
