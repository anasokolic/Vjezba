using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothie
{
    class Jagode : Sastojak
    {
        public Jagode(double Kolicina)
            {
            Porcija = 75;
            Opis = "Jagoda";
            Volumen = Porcija * Kolicina;
            }

            public override string Prikazi()
            {
            return String.Format("{0}g {1}", Volumen / Porcija, Opis);
            }
        }
}
