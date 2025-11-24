using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders28_32.Interface
{
    internal class Kus : Hayvan, IUcabilir
    {
        public void Uc()
        {
            Console.WriteLine("Kuş kanat çırparak uçuyor.");
        }

        public int Irtifa {  get; set; }
    }
}
