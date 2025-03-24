using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_6
{

    public enum Sex
    {
        Masculin,Feminin
    }

    public class persoana
    {
        public string Nume { get; set; }
        public Sex Sex { get; set; }

        public override string ToString()
        {
            return $"{Nume} ({Sex:g})";

        }
    }
}
