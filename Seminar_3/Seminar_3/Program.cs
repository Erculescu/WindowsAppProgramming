using Seminar_3;
using System.Collections;
using System.ComponentModel;
using System.IO.Pipes;

namespace Seminar_3
{
    class ComparatorVarsta : IComparer<persoana>
    {
        public int Compare(persoana a, persoana b)
        {
            return a.Varsta.CompareTo(b.Varsta);
        }
    }

    //interface ITransformator<T, U>{}  sau:
    delegate U Transformator<T, U>(T element);
    //echivalent cu Funct<T, U>

    internal class Program
    {


        //o fct care sa primeasca o colectie si sa intoarca o colectie noua cu obiectele transformate
        // ex: sa primeasca un lista de intregi si sa intoarca o lista cu intregii implementati

        //met 1: static TransformaColectie(List<object>) { }
        //met 2:
        static List<U> TransformaColectie<T, U>(List<T> lista, Transformator<T, U> transformator)
        {
            var rezultat = new List<U>();
            foreach (var element in lista)
            {
                rezultat.Add(transformator(element));
            }
            return rezultat;
        }

        //fct care sa primeasca o lista si returneaza doar elem care respecta criteriul
        //static List<T> Cautare<T>(List <T> lista, Func<T, bool> verifica)   sau:
        static List<T> Cautare<T>(List<T> lista, Predicate<T> verifica)
        {
            var rezultat = new List<T>();
            foreach (var element in lista)
            {
                if (verifica(element))
                {
                    rezultat.Add(element);
                }
            }
            return rezultat;
        }

        static void Main(string[] args)
        {
            var ion = new persoana { Nume = "Ion", Varsta = 20 };
            var maria = new persoana { Nume = "Maria", Varsta = 21 };
            var vasile = new persoana { Nume = "Vasile", Varsta = 25 };
            var mara = new persoana { Nume = "Mara", Varsta = 21 };


            //colectie de obiecte persoana care sa fie observabila (sa ne anunte de fiecare data cand se modif ceva
            var persoane1 = new BindingList<persoana> { ion, maria };
            persoane1.ListChanged += (sender, e) => {
                Console.WriteLine($"Lista a fost modificata: {e.ListChangedType}");
            };

            persoane1.Add(vasile);
            persoane1.Add(ion);
            persoane1.Add(mara);
            persoane1.Remove(vasile);
            vasile.Varsta = 80; //pt asta nu ne afiseza mdoificarea

            return;
            foreach (var nume1 in persoane1)
            {
                Console.WriteLine(nume1);
            }




            var persoane = new List<persoana> { ion, maria, vasile, mara };
            //afisam lista de persoane in ordine alfabetica
            //cu IComparer

            //afisam lista de persoane ordonate dupa varsta
            //met 1:  persoane.Sort(new ComparatorVarsta());
            //met 2:
            persoane.Sort((a, b) => a.Varsta.CompareTo(b.Varsta));

            foreach (var persoana in persoane)
            {
                Console.WriteLine(persoana);
            }

            var nume = TransformaColectie(persoane, p => p.Nume);
            foreach (var n in nume)
            {
                Console.WriteLine(n);
            }

            var rezultat = TransformaColectie(new List<int> { 1, 2, 3, 4 }, i => i + 1);
            Console.WriteLine(string.Join(",", rezultat));

            var persoaneSub25 = Cautare(persoane, p => p.Varsta < 25);
            foreach (var persoana in persoaneSub25)
            {
                Console.WriteLine(persoana);
            }

            var listaNumeM = Cautare(TransformaColectie(persoane, p => p.Nume), n => n.StartsWith("M"));
            Console.WriteLine(string.Join(",", listaNumeM));
        }



        static string ExtrageNume(persoana persoana)
        {
            return persoana.Nume;
        }
    }
}