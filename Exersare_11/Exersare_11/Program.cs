namespace Exersare_11
{
    internal static class Program
    {
        public static Dictionary<int, Student> studenti = new Dictionary<int, Student>();
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            studenti.Add(1, new Student(1, "Rares Erculescu"));
            studenti[1].AdaugaNota(new Nota(1, "Java", 10.0m));
            studenti[1].AdaugaNota(new Nota(1, "PAW", 8.0m));
            studenti[1].AdaugaNota(new Nota(1, "SDD", 7.5m));
            studenti.Add(2, new Student(2, "Ion Ionescu"));
            studenti[2].AdaugaNota(new Nota(2, "Java", 7.0m));
            studenti[2].AdaugaNota(new Nota(2, "PAW", 5.5m));
            studenti[2].AdaugaNota(new Nota(2, "SDD", 6.5m));
            studenti.Add(3, new Student(3, "George Georgescu"));
            studenti[3].AdaugaNota(new Nota(3, "BTI", 6.4m));
            studenti[3].AdaugaNota(new Nota(3, "BPC", 8.6m));
            studenti[3].AdaugaNota(new Nota(3, "BCO", 10.0m));


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}