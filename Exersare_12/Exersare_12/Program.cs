using Microsoft.Data.Sqlite;

namespace Exersare_12
{
    internal static class Program
    {
        public static Reprezentanta reprezentanta { get; } = new Reprezentanta("rares srl","splaiul independentei 3","070000000");
        [STAThread]
        static void Main()
        {
            string connection = "Data Source=baza.db;";
            using(SqliteConnection conexiune=new SqliteConnection(connection))
            {
                conexiune.Open();
                string cmd = "CREATE TABLE IF NOT EXISTS vehicule (serie TEXT PRIMARY KEY, marca TEXT,model TEXT, anFabricatie INTEGER, pret REAL);";
                SqliteCommand comanda = new SqliteCommand(cmd, conexiune);
                comanda.ExecuteNonQuery();
                conexiune.Close();
            }


            reprezentanta.AdaugaVehicul(new Vehicul("WPZZ1211", "Porsche", "GTS", 2020, 98900));
            reprezentanta.AdaugaVehicul(new Vehicul("WAUZZZ21", "Audi", "A3", 2013, 12500));
            reprezentanta.AdaugaVehicul(new Vehicul("WAUZZZ27", "Audi", "Q3", 2020, 23500));
            reprezentanta.AdaugaVehicul(new Vehicul("WBAZZZ12", "BMW", "320", 2019, 30000));
            reprezentanta.AdaugaVehicul(new Vehicul("WVAZZZ33", "Volkswagen", "Golf", 2020, 17333));
            reprezentanta.AdaugaVehicul(new Vehicul("WVAZZZ99", "Volkswagen", "Touareg", 2015, 180000));
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}