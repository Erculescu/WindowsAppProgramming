namespace Exersare_23
{
    internal static class Program
    {
        public static Bloc bloc = new Bloc("Strada Exemplu 123");
        [STAThread]
        static void Main()
        {
            bloc.adaugaApartament(new Apartament(1, "Ion Exemplescu", 77, 225.2m));
            bloc.adaugaApartament(new Apartament(2, "Maria Marinescu", 33, 72.3m));
            bloc.adaugaApartament(new Apartament(3, "Stefan Gheorghidiu", 120, 300.6m));
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}