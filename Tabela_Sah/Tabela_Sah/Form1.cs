namespace Tabela_Sah
{
    public partial class Form1 : Form
    {
        int n;
        public Form1(int n)
        {
            InitializeComponent();
            this.n = n;
            var w = ClientSize.Width / n;
            var h = ClientSize.Height / n;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    var panel = new Panel();
                    var culoare = Color.White;
                    if ((i + j) % 2 == 0){
                culoare = Color.Black;
            }
                    panel.BackColor = culoare;
                    panel.Size = new Size(w, h);
                    panel.Location = new Point(i * w, j * h);
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    Controls.Add(panel);
                }
            }
        }
    }
}
