using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders24_27
{
    internal class Ogrenci
    {
        public string Ad {  get; set; }
        public int Not {  get; set; }

        public static int ToplamOgrenciSayisi = 0;

        //1.Overload
        public Ogrenci()
        {
            this.Ad = "Belirsiz";
            this.Not = 0;
        }

        //2.Overload
        public Ogrenci(string gelenAd, int gelenNot)
        {
            this.Ad = gelenAd;
            this.Not = gelenNot;

            ToplamOgrenciSayisi++;
        }

        public void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {this.Ad}, Not: {this.Not}");
        }

        public bool GectiMi()
        {
            return this.Not >= 50;
        }
    }
}
