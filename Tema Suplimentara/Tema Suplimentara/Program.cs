using System.Data.SQLite;

namespace Tema_Suplimentara
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static Cos cos { get; } = new Cos(); 
        [STAThread]
        static void Main()
        {
            string connectionString = "Data Source=myDatabase.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Conexiune la baza de date deschisa.");
                string creareTabela= "CREATE TABLE IF NOT EXISTS produse (cod INTEGER PRIMARY KEY, denumire TEXT, pret REAL, cantitate INTEGER)";
                SQLiteCommand comanda = new SQLiteCommand(creareTabela, connection);
                comanda.ExecuteNonQuery();
                connection.Close();
            }

                cos.adaugaProdus(new Produs("Laptop", 5000, 1));
        cos.adaugaProdus(new Produs( "Telefon", 2000, 2));
            cos.adaugaProdus(new Produs( "Tableta", 1500, 1));
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }
    }
}