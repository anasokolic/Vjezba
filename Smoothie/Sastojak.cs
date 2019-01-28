using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothie
{
    class Sastojak
    {
        protected double Volumen;
        protected string Opis;
        protected double Porcija;
     

        public virtual string Prikazi()
        {
            return String.Format("Sastojak je trenutno nepoznat.");
        }
    }
}
