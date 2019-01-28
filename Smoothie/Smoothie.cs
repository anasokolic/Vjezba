using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothie
{
    class Smoothie
    {
        static List<Sastojak> Sastojci = new List<Sastojak>();
        private string Naziv;

        public Smoothie(string Naziv)
        {
            this.Naziv = Naziv;
        }

        public void Dodaj(Sastojak A)
        {
            Sastojci.Add(A);
        }

        public string Posluzi()
        {
            string Smoothie = "Posluzujem: " + Naziv + "\nSastojci: (" + Sastojci.Count() + ")\n";
            
            

            foreach(Sastojak A in Sastojci)
            {
                Smoothie += A.Prikazi() + "\n";
               

                
            }

            return String.Format(Smoothie ) ;
            
        }
    }
}
