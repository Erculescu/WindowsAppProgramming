using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_11
{
    internal class Student
    {
        public int idStudent { get; set; }
        public string Nume { get; set; }
        public List<Nota> note;
        public Student(int idStudent,string nume)
        {
            this.idStudent = idStudent;
            this.Nume = nume;
            note = new List<Nota>();

        }
        public void AdaugaNota(Nota nota)
        {
            note.Add(nota);
        }
        public decimal Medie()
        {
            if (note.Count == 0)
                return 0;
            return note.Average(n => n.nota);
        }
    }
}
