using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders28_32.Geometri
{
    internal class Kare : Sekil
    {
        public int Kenar {  get; set; }

        public override double AlanHesapla()
        {
            return Kenar * Kenar;
        }
    }
}
