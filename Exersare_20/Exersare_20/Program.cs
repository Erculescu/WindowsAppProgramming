namespace Exersare_20
{
    internal static class Program
    {
        public static CosCumparaturi cosCumparaturi = new CosCumparaturi();
        [STAThread]
        static void Main()
        {
            cosCumparaturi.AdaugaProdus(new Produs("produs", 203.5m, 2));
            cosCumparaturi.AdaugaProdus(new Produs("produs2", 100m, 1));
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}