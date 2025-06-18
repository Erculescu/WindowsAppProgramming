namespace Exersare_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Denumire Job");
            listView1.Columns.Add("ID Interview");
            listView1.Columns.Add("Nume Candidat");
            listView1.Columns.Add("Punctaj");
            listView1.Columns.Add("Data Interview");
            Afisare();
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem stergere = new ToolStripMenuItem("Stergere");
            contextMenuStrip.Items.Add(stergere);
            listView1.ContextMenuStrip = contextMenuStrip;
            stergere.Click += (s, e) =>
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        listView1.Items.Remove(item);
                        Program.job.interviuri.Remove((Interviu)item.Tag);
                    }
                }
            };
        }
        public void Afisare()
        {
            listView1.Items.Clear();
            foreach (var interviu in Program.job.interviuri)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    Program.job.Pozitie,
                    interviu.id.ToString(),
                    interviu.candidat,
                    interviu.punctaj.ToString(),
                    interviu.data.ToShortDateString()
                });
                item.Tag = interviu;
                listView1.Items.Add(item);
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Afisare();
        }
        private bool flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (flag)
            {

                Graphics g = e.Graphics;
                g.Clear(Color.White);
                var candSortati = Program.job.interviuri.OrderByDescending(i => i.punctaj).ToList();
                if (candSortati.Count == 0) return;
                int barh = 25;
                int spacing = 10;
                int maxW = panel1.Width - 300;
                Font font = new Font("Arial", 10);
                Brush textB = Brushes.Black;
                Brush barB = Brushes.SteelBlue;
                decimal maxPunctaj = candSortati.Max(i => i.punctaj);
                for(int i = 0; i < candSortati.Count; i++)
                {
                    int barw = (int)(maxW * (candSortati[i].punctaj / maxPunctaj));
                    int x = 245;
                    int y = i * (barh + spacing);
                    g.DrawString(candSortati[i].candidat, font, textB, 5, y + 5);
                    g.FillRectangle(barB, x, y, barw, barh);
                    g.DrawString(candSortati[i].punctaj.ToString(), font, textB, x + barw + 2, y + 5);
                }
            }
            else
            {
                e.Graphics.Clear(Color.White);
            }


        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            ScriereInFisier();
        }
        private void ScriereInFisier()
        {
            string text = "";
            text += Program.job.Pozitie;
            text += Environment.NewLine;
            foreach(Interviu interviu in Program.job.interviuri)
            {
                text += interviu.ToString();
                text += Environment.NewLine;
            }
            File.WriteAllText("interviuri.txt", text);
        }
    }
}
