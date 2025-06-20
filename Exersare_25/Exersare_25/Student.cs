using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_25
{
    internal class Student
    {
        private int nrMatricol;
        public int getNrMatricol()
        {
            return nrMatricol;
        }
        public void setNrMatricol(int nrMatricol)
        {
            this.nrMatricol = nrMatricol;
        }
        public string nume { get; set; }
        public decimal punctaj { get; set; }

        public Student(int nrMatricol, string nume, decimal punctaj)
        {
            this.nrMatricol = nrMatricol;
            this.nume = nume;
            this.punctaj = punctaj;
        }

        public override string? ToString()
        {
            return this.nrMatricol+","+nume+","+punctaj;
        }
    }
}
