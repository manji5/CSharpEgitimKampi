using Ders28_32.Geometri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders28_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 28-30
            //Ogrenci o1 = new Ogrenci("Ali", "Yılmaz", 985, 49);
            //o1.BilgiYazdır();

            //Ogretmen o2 = new Ogretmen("Nurşen", "Yıldız", 35000);
            //o2.BilgiYazdır();

            //Kisi k1 = new Kisi("Ahmet", "Normal");
            //k1.BilgiYazdır();

            //List<Kisi> okulNufusu = new List<Kisi>();
            //okulNufusu.Add(o1);
            //okulNufusu.Add(o2);
            //okulNufusu.Add(k1);

            //Console.WriteLine("--- Okul Nüfusu ---");
            //foreach (Kisi k in okulNufusu)
            //{
            //    k.BilgiYazdır();
            //}
            #endregion

            #region 31
            // Sekil s = new Sekil();

            //Sekil s1 = new Kare { Renk = "Kırmızı", Kenar = 5 };
            //Sekil s2 = new Daire { Renk = "Mavi", YariCap = 3 };

            //Console.WriteLine($"Karenin Alanı: {s1.AlanHesapla()}");
            //s1.RenkSoyle();

            //Console.WriteLine($"Dairenin Alanı: {s2.AlanHesapla()}");
            #endregion

            #region 32
            List<Ogrenci> sinif = new List<Ogrenci>();
            sinif.Add(new Ogrenci("Yağız", "Akdeniz", 745, 47));
            sinif.Add(new Ogrenci("Yiğit", "Gökçe", 745, 84));
            sinif.Add(new Ogrenci("Kutay", "ASLDKJ", 745, 74));
            sinif.Add(new Ogrenci("Ali", "SAJHD", 745, 51));

            sinif.Sort();

            foreach (var o in sinif)
            {
                Console.WriteLine($"{o.Ad} - {o.Not}");
            }
            #endregion
        }
    }
}
