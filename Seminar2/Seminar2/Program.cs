//seminar 2
using Seminar2;

namespace Semniar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ion = new Angajat(1, "Ion", "manager");
            var rares = new Angajat(2, "Rares", "dezvoltator");
            var alina = new Angajat(3, "Alina", "sef echipa");
            Console.WriteLine(ion);
            Console.WriteLine(rares);
            Console.WriteLine(alina);
        }
    }
}