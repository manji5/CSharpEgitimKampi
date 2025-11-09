namespace Ders21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int
            //int sonuc = ToplamaYap(10, 5);

            //Console.WriteLine("Toplama sonucunuz: " + sonuc);
            //Console.WriteLine($"İşte sonucun 2 katı: {sonuc * 2}");
            #endregion

            #region string
            //string isim = AdSoyadBirlestir("Ali", "Yılmaz");
            //Console.WriteLine(isim);
            #endregion

            #region bool
            int ogrenciNotu = 45;

            if (GecmeDurumu(ogrenciNotu) == true)
            {
                Console.WriteLine("Öğrenci dersi geçti.");
            }
            else
            {
                Console.WriteLine("Öğrenci dersten kaldı.");
            }
            #endregion

        }

        static int ToplamaYap(int s1, int s2)
        {
            int sonuc = s1 + s2;

            return sonuc;
        }

        static string AdSoyadBirlestir(string ad, string soyad)
        {
            string tamAd = ad + " " + soyad;
            return tamAd;

            // return ad + " " + soyad;
        }

        static bool GecmeDurumu(int not)
        {
            if (not >= 50)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}