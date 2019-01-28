using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothie
{
    class Avokado : Sastojak
    {
         public Avokado(double Kolicina)
            {
                Porcija = 0.25;
                Opis = "Avokada";
                Volumen = Porcija * Kolicina;
            }

            public override string Prikazi()
        {
            return String.Format("{0}g {1}", Volumen / Porcija, Opis);
        }
    }
}
