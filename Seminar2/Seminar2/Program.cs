//seminar 2
using Seminar2;

namespace Semniar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ion = new Manager(1, "Ion", "manager");
            var rares = new Angajat(2, "Rares", "dezvoltator");
            var alina = new Manager(3, "Alina", "sef echipa");
            var a1 = new Angajat(4, "Mihai", "muncitor");
            var a2 = new Angajat(5, "Costi", "patron");
            ion.adaugasubordonat(alina);
            ion.adaugasubordonat(rares);
            alina.adaugasubordonat(a1);
            alina.adaugasubordonat(a2);
            //Console.WriteLine(ion);
            //Console.WriteLine(rares);
            //Console.WriteLine(alina);
            var angajati = new List <Angajat> { ion, rares, alina,a1,a2 };

            foreach(var angajat in angajati)
            {
                Console.WriteLine(angajat);
            }

        }
    }
}