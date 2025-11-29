using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.Hayvanlar
{
    internal class Kopek : Hayvan
    {
        public Kopek(string ad, int yas) : base(ad, yas) { }

        public override void SesCikar()
        {
            Console.WriteLine($"{Ad} (Köpek): Hav Hav! 🐶");
        }
    }
}
