using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_25
{
    internal class Materie
    {
        public string denumire { get; set; }
        public int nrCredite { get; set; }
        public List<Student> studenti { get; set; }
        public int nrStudenti { get { return studenti.Count; } }
        public decimal punctajMediu
        {
            get { if (studenti.Count == 0) return 0;
                return studenti.Average(s => s.punctaj);
            }
        }

        public Materie(string denumire, int nrCredite)
        {
            this.denumire = denumire;
            this.nrCredite = nrCredite;
            this.studenti = new List<Student>();
        }

        public override string? ToString()
        {
            return denumire + "," + nrCredite + "," + punctajMediu + "," + string.Join(",",studenti) ;
        }
        public void adaugaStudent(Student student)
        {
            studenti.Add(student);
        }
    }
}
