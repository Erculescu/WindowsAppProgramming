namespace Exersare_13
{
    internal static class Program
    {
        public static List<Bicicleta> biciclete = new List<Bicicleta>();
        public static List<Utilizator> utilizatori = new List<Utilizator>();
        [STAThread]
        static void Main()
        {
            biciclete.Add(new Bicicleta("Statie 1",10));
            biciclete.Add(new Bicicleta("Statie 2", 101));
            biciclete.Add(new Bicicleta("Statie 1", 15));
            biciclete.Add(new Bicicleta("Statie 4", 20));
            biciclete.Add(new Bicicleta("Statie 3", 41));
            utilizatori.Add(new Utilizator("Rares", 1, 45));
            utilizatori.Add(new Utilizator("Ion", 2, 101));
            utilizatori.Add(new Utilizator("Andrei", 2, 25));
            utilizatori.Add(new Utilizator("Mihai", 3, 35));
            utilizatori.Add(new Utilizator("Rares", 4, 60));
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}