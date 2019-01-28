using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothie
{
    class Jogurt : Sastojak
    {
        public Jogurt(double Kolicina, string Opis)
        {
            Porcija = 2;
            Volumen = Kolicina * Porcija;
            this.Opis = Opis;

        }

        public override string Prikazi()
        {
            return String.Format("{0} zlice {1}", Volumen / Porcija, Opis);
        }
    }
}
