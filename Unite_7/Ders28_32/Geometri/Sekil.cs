using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders28_32.Geometri
{
    abstract class Sekil
    {
        public string Renk {  get; set; }

        public void RenkSoyle()
        {
            Console.WriteLine($"Bu şeklin rengi: {Renk}");
        }

        //Abstract
        public abstract double AlanHesapla();
    }
}
