using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_19
{
    internal class Companie
    {
        public int id;
        public string denumire;
        public List<Angajat> angajati;

        public Companie()
        {
            angajati = new List<Angajat>();
        }

        public Companie(int id, string denumire)
        {
            this.id = id;
            this.denumire = denumire;
            this.angajati = new List<Angajat>();
        }
        public void AdaugaAngajat(Angajat angajat)
        {
            if ((DateTime.Now - angajat.dataNasterii > TimeSpan.FromDays(365 * 20))&&angajat.Nume.Length>2)
            {
                angajati.Add(angajat);
            }
        }

        public override string? ToString()
        {
            return id+" "+denumire+" "+string.Join(",",angajati.ToList());
        }
    }
}
