using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothie
{
    class Mlijeko : Sastojak
    {
      public Mlijeko(double Kolicina, string Opis)
        {
            Porcija = 100;
            Volumen = Kolicina * Porcija;
            this.Opis = Opis;

        }

        public override string Prikazi()
        {
            return String.Format("{0}ml {1}", Volumen / Porcija, Opis);
        }
    }
}
