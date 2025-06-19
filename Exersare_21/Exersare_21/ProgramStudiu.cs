using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_21
{
    internal class ProgramStudiu
    {
        private int codProgram;
        private string denumireProgram;
        private int nrLocuriBuget;
        private int nrLocuriTaxa;
        public int getCodProgram { get { return codProgram; } }
        public string getDenumireProgram { get { return denumireProgram; } }
        public int getNrLocuriBuget { get { return nrLocuriBuget; } }
        public int getNrLocuriTaxa { get { return nrLocuriTaxa; } }

        public ProgramStudiu(int codProgram, string denumireProgram, int nrLocuriBuget, int nrLocuriTaxa)
        {
            this.codProgram = codProgram;
            this.denumireProgram = denumireProgram;
            this.nrLocuriBuget = nrLocuriBuget;
            this.nrLocuriTaxa = nrLocuriTaxa;
        }

        public ProgramStudiu()
        {
        }
    }
}
