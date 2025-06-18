using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_11
{
    internal class Nota
    {
        public int idStudent { get; set; }
        public string Materie { get; set; }
        public decimal nota { get; set; }

        public Nota(int idStudent, string materie, decimal nota)
        {
            this.idStudent = idStudent;
            Materie = materie;
            this.nota = nota;
        }

    }
}
