using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_21
{
    public class Candidat
    {
        private int codCandidat;
        private string numeCandidat;
        private float medieConcurs;
        private List<int> vectorOptiuni;
        public int getCodCandidat { get { return codCandidat; } }
        public string getNumeCandidat { get { return numeCandidat; } }
        public float getMedieConcurs { get { return medieConcurs; } }
        public List<int> getVectorOptiuni { get { return vectorOptiuni; } }
        public void adaugaOptiune(int optiune)
        {
            vectorOptiuni.Add(optiune);
        }
        public void setOptiuni(List<int> optiuni)
        {
            vectorOptiuni = optiuni;
        }

        public Candidat(int codCandidat, string numeCandidat, float medieConcurs, List<int> vectorOptiuni)
        {
            this.codCandidat = codCandidat;
            this.numeCandidat = numeCandidat;
            this.medieConcurs = medieConcurs;
            this.vectorOptiuni = vectorOptiuni;
        }

        public Candidat(int codCandidat, string numeCandidat, float medieConcurs)
        {
            this.codCandidat = codCandidat;
            this.numeCandidat = numeCandidat;
            this.medieConcurs = medieConcurs;
            this.vectorOptiuni = new List<int>();
        }
    }
}
