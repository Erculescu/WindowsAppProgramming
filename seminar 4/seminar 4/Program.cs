namespace seminar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);

            var formular = new Form();
            formular.Text = "Numar";
            formular.ClientSize = new Size(230, 80);
            var btnMinus = new Button()
            {
                Text="-",
                Location=new Point(50,20),
                Size=new Size(40,40)
            };

            var btnPlus = new Button()
            {
                Text = "+",
                Location = new Point(50+40+50, 20),
                Size=new Size(40,40)
            };
            var label = new Label()
            {
                Text = "0",
                AutoSize = true,
                Location = new Point(50 + 40, 20),
                Font=new Font(formular.Font.FontFamily,20f,FontStyle.Bold)
            };
            formular.Controls.Add(btnMinus);
            formular.Controls.Add(btnPlus);
            formular.Controls.Add(label);
            btnMinus.Click += (sender, e) =>
            {
                label.Text = (int.Parse(label.Text) - 1).ToString();
            };
            btnPlus.Click += (sender, e) =>
            {
                label.Text = (int.Parse(label.Text) + 1).ToString();
            };
            Application.Run(formular);
        }
    }
}
