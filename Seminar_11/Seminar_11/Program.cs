using Microsoft.Data.Sqlite;
using System.Data.Common;
using Dapper;

namespace Seminar_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbProviderFactories.RegisterFactory(
                "System.Data.Sqlite", SqliteFactory.Instance);
            var program = new Program();
           // var tranzactii = program.Generare();
           // tranzactii.ForEach(t => Console.WriteLine(t));
            string SirConectare = "Data Source=Tranzactii.db";
            var factory = DbProviderFactories.GetFactory("System.Data.Sqlite");
            {
                var tranzactii = program.Generare();

                using var conexiune = factory.CreateConnection();
                conexiune.ConnectionString = SirConectare;
                conexiune.Open();
               // using var comanda = conexiune.CreateCommand();
                //comanda.CommandText = "CREATE TABLE IF NOT EXISTS Tranzactii (" + "CodProdus INTEGER, " + "Denumire TEXT, " + "Pret REAL, " + "Cantitate INTEGER)";
                //sau
                conexiune.Execute("CREATE TABLE IF NOT EXISTS Tranzactii (" + "CodProdus INTEGER, " + "Denumire TEXT, " + "Pret REAL, " + "Cantitate INTEGER)");


                var nr = conexiune.Execute("DELETE FROM Tranzactii");
                Console.WriteLine($"S-au sters {nr} tranzactii");
                //comanda.CommandText="INSERT INTO Tranzactii "+"(CodProdus, Denumire, Pret, Cantitate) "+ "Values (@CodProdus, @Denumire, @Pret, @Cantitate)";

                //var pCodProdus = comanda.CreateParameter();
                //pCodProdus.ParameterName = "@CodProdus";
                //pCodProdus.DbType = System.Data.DbType.Int32;
                //comanda.Parameters.Add(pCodProdus);

                //var pDenumire = comanda.CreateParameter();
                //pDenumire.ParameterName = "@Denumire";
                //pDenumire.DbType = System.Data.DbType.String;
                //comanda.Parameters.Add(pDenumire);

                //var pPret = comanda.CreateParameter();
                //pPret.ParameterName = "@Pret";
                //pPret.DbType = System.Data.DbType.Decimal;
                //comanda.Parameters.Add(pPret);

                //var pCantitate = comanda.CreateParameter();
                //pCantitate.ParameterName = "@Cantitate";
                //pCantitate.DbType = System.Data.DbType.Int32;
                //comanda.Parameters.Add(pCantitate);
                foreach(var tranzactie in tranzactii)
                {
                    conexiune.Execute("INSERT INTO Tranzactii " + "(CodProdus, Denumire, Pret, Cantitate) " + "Values (@CodProdus, @Denumire, @Pret, @Cantitate)",
                        param: tranzactie);
                    //sau
                    //comanda.Parameters["@CodProdus"].Value = tranzactie.CodProdus;
                    //comanda.Parameters["@Denumire"].Value = tranzactie.Denumire;
                    //comanda.Parameters["@Pret"].Value = tranzactie.Pret;
                    //comanda.Parameters["@Cantitate"].Value = tranzactie.Cantitate;
                    //comanda.ExecuteNonQuery();
                }
            }
            {
                //var tranzactii = new List<Tranzactie>();
                using var conexiune = factory.CreateConnection();
                conexiune.ConnectionString = SirConectare;
                conexiune.Open();

                //using var comanda = conexiune.CreateCommand();
                //comanda.CommandText = "SELECT * FROM Tranzactii";

                //using var cursor = comanda.ExecuteReader();
                //while (cursor.Read())
                //{
                //    var tranzactie = new Tranzactie
                //    {
                //        CodProdus = cursor.GetInt32(0),
                //        Denumire = cursor.GetString(1),
                //        Pret = cursor.GetDecimal(2),
                //        Cantitate = cursor.GetInt32(3)
                //    };
                //    tranzactii.Add(tranzactie);
                //}
                //sau asa
                var tranzactii = conexiune.Query<Tranzactie>("SELECT * FROM Tranzactii");
                var coduri = tranzactii.Select(x => x.CodProdus).Distinct();
                foreach(var codProdus in coduri)
                {
                    var tran = tranzactii.Where(x => x.CodProdus == codProdus);
                    var denumirea = tran.First().Denumire;
                    var stoc = tran.Sum(x => x.Cantitate);
                    Console.WriteLine($"{codProdus} {denumirea} -> {stoc} buc");
                }

                //tranzactii.ForEach(Console.WriteLine);
            }
        }

        public List<Tranzactie> Generare()
        {
            string[] denumiri = ["Mere", "Pere", "Afine"];
            Random random = new Random();
            List<Tranzactie> tranzactii = new List<Tranzactie>();
            for (int i = 0; i < 20; i++)
            {
                var index = random.Next(denumiri.Length);
                var tranzactie = new Tranzactie
                {
                    CodProdus = index + 1,
                    Denumire = denumiri[index],
                    Pret = (decimal)random.NextDouble(),
                    Cantitate = random.Next(1, 10)
                };
                tranzactii.Add(tranzactie);
            }
            return tranzactii;
        }
    }
}
     
