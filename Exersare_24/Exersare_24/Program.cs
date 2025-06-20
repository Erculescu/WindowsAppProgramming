namespace Exersare_24
{
    internal static class Program
    {
        public static Magazin magazin = new Magazin("Telefoane pentru toti");
        [STAThread]
        static void Main()
        {
            magazin.adaugaTelefon(new Telefon("2134124sw", "Iphone 15 Pro", 4500));
            magazin.adaugaTelefon(new Telefon("128742201", "Samsung Galaxy S24", 5100));
            magazin.adaugaTelefon(new Telefon("734678586", "Google Pixel 10", 5100));
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}