using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders28_32.Interface
{
    internal class Ucak : IUcabilir
    {
        public void Uc()
        {
            Console.WriteLine("Uçak motor gücüyle uçuyor.");
        }

        public int Irtifa {  get; set; }
    }
}
