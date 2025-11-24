using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders28_32.Geometri
{
    internal class Daire : Sekil
    {
        public int YariCap {  get; set; }

        public override double AlanHesapla()
        {
            return Math.PI * YariCap * YariCap;
        }
    }
}
