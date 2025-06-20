namespace Exersare_25
{
    internal static class Program
    {
        public static Materie materie = new Materie("PAW", 4);
        [STAThread]
        static void Main()
        {
            materie.adaugaStudent(new Student(1, "Rares", 7.3m));
            materie.adaugaStudent(new Student(2, "Mihai", 6.4m));
            materie.adaugaStudent(new Student(3, "Ionut", 7.63m));
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}