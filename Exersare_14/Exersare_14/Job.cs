using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_14
{
    internal class Job
    {
        public string Pozitie;
        public List<Interviu> interviuri;

        public Job(string pozitie)
        {
            Pozitie = pozitie;
            this.interviuri = new List<Interviu>();
        }
        public void adaugaInterviu(Interviu interviu)
        {
            interviuri.Add(interviu);
        }
        public static Job operator +(Job a,Interviu interviu)
        {
            a.interviuri.Add(interviu);
            return a;
        }


        public Job()
        {
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
