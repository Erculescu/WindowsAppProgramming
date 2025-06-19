using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_22
{
    internal class Companie
    {
        public Companie()
        {
            angajati = new List<Persoana>();
        }
        public int idCompanie { get; set; }
        public string denumire { get; set; }
        public List<Persoana> angajati { get; set; }

        public Companie(int idCompanie, string denumire, List<Persoana> angajati)
        {
            this.idCompanie = idCompanie;
            this.denumire = denumire;
            this.angajati = angajati;
        }

        public Companie(int idCompanie, string denumire)
        {
            this.idCompanie = idCompanie;
            this.denumire = denumire;
            this.angajati = new List<Persoana>();
        }
        public void adaugaAngajat(Persoana pers)
        {
            angajati.Add(pers);
        }
    }
}
