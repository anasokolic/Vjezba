using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothie
{
    class Program
    {
        static void Main(string[] args)
        {
            Smoothie VocniSmoothie = new Smoothie("Vocni smoothie");
            VocniSmoothie.Dodaj(new Avokado(0.25));
            VocniSmoothie.Dodaj(new Jagode(75));
            VocniSmoothie.Dodaj(new Jogurt(2, "malomasnog jogurta"));
            VocniSmoothie.Dodaj(new Mlijeko(100, "malomasnog mlijeka"));
            VocniSmoothie.Dodaj(new LimunovSok("malo "));
         
            Console.WriteLine(VocniSmoothie.Posluzi());
            Console.WriteLine("Uzivaj u socnom vocnom smoothiju. :)");

    
            Console.ReadLine();
        }
    }
}
