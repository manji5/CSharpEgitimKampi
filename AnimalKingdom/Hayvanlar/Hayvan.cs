using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.Hayvanlar
{
    internal class Hayvan
    {
        public string Ad {  get; set; }
        public int Yas { get; set; }

        public Hayvan(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
        }

        public virtual void SesCikar()
        {
            Console.WriteLine($"{Ad} bir ses çıkarıyor: (Tanımsız Ses)");
        }

        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"[{this.GetType().Name}] Adı: {Ad} - Yaşı: {Yas}");
        }
    }
}
