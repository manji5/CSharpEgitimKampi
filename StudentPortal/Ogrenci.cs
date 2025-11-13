using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal
{
    internal class Ogrenci
    {
        public string Ad {  get; set; }
        public string Soyad {  get; set; }
        public int Numara {  get; set; }
        public int Not {  get; set; }

        public Ogrenci(string ad, string soyad, int numara, int not)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Numara = numara;
            this.Not = not;
        }

        public void BilgiYadir()
        {
            Console.WriteLine($"Numara: {this.Numara}, Ad Soyad: {this.Ad} {this.Soyad}, Not: {this.Not}");
        }
    }
}
