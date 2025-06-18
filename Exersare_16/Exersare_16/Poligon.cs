using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_16
{
    internal class Poligon
    {
        public readonly int Codpoligon;
        public List<float> puncte;
        public Color culoare;
        public int grosimeLinie;
        public string eticheta;

        public Poligon(int codpoligon, Color culoare, int grosimeLinie, string eticheta)
        {
            Codpoligon = codpoligon;
            this.culoare = culoare;
            this.grosimeLinie = grosimeLinie;
            this.eticheta = eticheta;
            this.puncte = new List<float>();
        }
        public void adaugaPunct(float p)
        {
            puncte.Add(p);
        }
        public float this[int index]
        {
            get => puncte[index];
            set => puncte[index] = value;
        }
        public float CalculeazaPerimetru()
        {
            float p = 0.0f;
            foreach(float val in puncte)
            {
                p += val;
            }
            return p;
        }

        public Poligon(int codpoligon, List<float> puncte, Color culoare, int grosimeLinie, string eticheta)
        {
            Codpoligon = codpoligon;
            this.puncte = puncte;
            this.culoare = culoare;
            this.grosimeLinie = grosimeLinie;
            this.eticheta = eticheta;
        }
    }
}
