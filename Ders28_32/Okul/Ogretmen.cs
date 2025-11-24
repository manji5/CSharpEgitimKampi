using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders28_32
{
    internal class Ogretmen : Kisi
    {

        public decimal Maas { get; set; }

        public Ogretmen(string ad, string soyad, decimal maas) : base(ad, soyad)
        {
            Maas = maas;
        }

        public override void BilgiYazdır()
        {
            Console.WriteLine($"Öğretmen: {Ad} {Soyad} - Maaş: {Maas}");
        }
    }
}
