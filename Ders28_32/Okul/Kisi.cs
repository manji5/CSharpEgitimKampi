using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders28_32
{
    internal class Kisi
    {
        public string Ad {  get; set; }
        public string Soyad { get; set; }

        public Kisi(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public virtual void BilgiYazdır()
        {
            Console.WriteLine($"Kişi: {Ad} {Soyad}");
        }
    }
}
