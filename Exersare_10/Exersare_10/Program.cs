namespace Exersare_10
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static Stoc stoc { get; } = new Stoc();
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            stoc.adaugaCamera(new Camera { CodCamera=1,denumire = "Minolta Dynax 500si", pret = 400, cantitate = 2 });
        }
    }
}