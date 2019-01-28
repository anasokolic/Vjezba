using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothie
{
    class LimunovSok : Sastojak
    {
        public LimunovSok(string Opis)
        {
            this.Opis = Opis + "limunovog soka";
            Volumen = 1;
        }

        public override string Prikazi()
        {
            return Opis;
        }
    }
}
