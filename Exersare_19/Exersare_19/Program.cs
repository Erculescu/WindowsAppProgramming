namespace Exersare_19
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static Dictionary<int, Companie> companii = new Dictionary<int, Companie>();
        [STAThread]
        static void Main()
        {
            companii.Add(1, new Companie(1, "SC Exersare SA"));
            companii.Add(2, new Companie(2, "SC Testare SRL"));
            companii.Add(3, new Companie(3, "SC Exemplu IFN"));
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}