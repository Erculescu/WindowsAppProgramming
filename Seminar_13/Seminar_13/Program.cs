namespace Seminar_13
{
    internal static class Program
    {
        public static List<Factura> Facturi { get; } = new List<Factura>();
        [STAThread]
        static void Main()
        {
            Facturi.Add(new Factura() { Cod = 1, Client = "Client1", Data = new DateTime(2025, 1, 13), Valoare = 100.50m });
            Facturi.Add(new Factura() { Cod = 2, Client = "Client2", Data = new DateTime(2025, 1, 14), Valoare = 200.75m });
            Facturi.Add(new Factura() { Cod = 3, Client = "Client1", Data = new DateTime(2025, 1, 15), Valoare = 300.00m });
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}