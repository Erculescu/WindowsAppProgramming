using Microsoft.Data.Sqlite;

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
            string conexiune = "Data Source=baza.db;";
            using (SqliteConnection connection=new SqliteConnection(conexiune))
            {
                connection.Open();
                string comanda = "CREATE TABLE IF NOT EXISTS camere (denumire TEXT,pret REAL, cantitate INTEGER)";
                SqliteCommand cmd = new SqliteCommand(comanda, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            stoc.adaugaCamera(new Camera("Minolta Dynax 500si", 400, 2));
            stoc.adaugaCamera(new Camera("Chaika 3", 200, 3));
            stoc.adaugaCamera(new Camera("Revue TL25", 110, 2));
            stoc.adaugaCamera(new Camera("Nikon F3", 600, 1));
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }
    }
}