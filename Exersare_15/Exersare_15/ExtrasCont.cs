using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_15
{
    internal class ExtrasCont
    {
        private string numeClient { get; set; }
        private string adresa { get; set; }
        private List<Tranzactie> tranzactii { get; set; } = new List<Tranzactie>();
        public Tranzactie this[int index]
        {
            get => tranzactii[index];
            set => tranzactii[index] = value;
        }
        public void AdaugaTranzactie(Tranzactie tranzactie)
        {
            tranzactii.Add(tranzactie);
        }

        public ExtrasCont(string numeClient, string adresa)
        {
            this.numeClient = numeClient;
            this.adresa = adresa;
            this.tranzactii = new List<Tranzactie>();
        }
        public string getnume()
        {
            return numeClient;
        }
        public string getadresa()
        {
            return adresa;
        }
        public string getTranzactii()
        {
            return string.Join(";", tranzactii.Select(t => t.ToString()));
        }
        public override string? ToString()
        {
            return numeClient + "," + adresa + "," + string.Join(";", tranzactii.Select(t => t.ToString()));
        }
    }
}
