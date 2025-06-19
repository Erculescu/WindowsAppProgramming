using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_19
{
    internal class Angajat
    {
        public string Nume;
        public DateTime dataNasterii;
        int idCompanie;

        public Angajat()
        {
        }

        public Angajat(string nume, DateTime dataNasterii, int idCompanie)
        {
            Nume = nume;
            this.dataNasterii = dataNasterii;
            this.idCompanie = idCompanie;
        }

        public override string? ToString()
        {
            return Nume+" "+dataNasterii.ToLongDateString()+" "+idCompanie;
        }
    }
}
