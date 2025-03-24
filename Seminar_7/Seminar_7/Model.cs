using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_7
{
    class Model
    {
        List<Persoana> persoane = new List<Persoana>();

        
        public List<Persoana> Persoane {
            get { return persoane; }
            private set { persoane = value; }
        }
        public void Adauga(Persoana persoana)
        {
            persoane.Add(persoana);
            Adaugare?.Invoke(this, persoana);
        }

        public void Incarca(List<Persoana> persoane)
        {
            this.persoane.Clear();
            this.persoane.AddRange(persoane);
            Incarcare?.Invoke(this, EventArgs.Empty);
        }


        public event EventHandler<Persoana> Adaugare;
        public event EventHandler Incarcare;
    }
}
