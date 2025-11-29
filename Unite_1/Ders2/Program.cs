using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //veritipi degiskenAdi = deger;

            //int yas = 25;

            //int ogrenciSayisi = 30;

            //Console.WriteLine("Yaşınız: " + yas);
            //Console.WriteLine("öğrenci Sayısı: " + ogrenciSayisi);
            //Console.WriteLine($"Yaşınız: {yas}\nÖğrenci Sayısı: {ogrenciSayisi}");

            double boy = 1.83;
            float hiz = 90.5f;

            decimal urunFiyati = 199.99m;
            decimal bakiye = 1500.50m;
            Console.WriteLine($"Ürün fiyatı: {urunFiyati}\nBakiyeniz: {bakiye}");

            List<int> not = new List<int>();
        }
    }
}
