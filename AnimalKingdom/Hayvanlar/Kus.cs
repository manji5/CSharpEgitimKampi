using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.Hayvanlar
{
    internal class Kus : Hayvan
    {
        public Kus(string ad, int yas) : base(ad, yas) { }

        public override void SesCikar()
        {
            Console.WriteLine($"{Ad} (Kuş): Cik Cik! 🐦");
        }
    }
}
