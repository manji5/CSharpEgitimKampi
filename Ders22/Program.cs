namespace Ders22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Değer Tipi

            //int sayi = 10;
            //Console.WriteLine("Metottan önce: " + sayi);

            //DegerArttir(ref sayi);

            //Console.WriteLine("Metottan sonra: " + sayi);

            #endregion

            #region Referans Tipi

            //int[] sayilar = { 1, 2, 3 };
            //Console.WriteLine("Metot öncesi List[0]: " + sayilar[0]);

            //ListeyiDegistir(sayilar);

            //Console.WriteLine("Metot sonrası List[0]: " + sayilar[0]);

            #endregion

            #region out

            Console.Write("Bir sayı girin: ");
            string girdi = Console.ReadLine();

            int sonucSayi;

            if (int.TryParse(girdi, out sonucSayi))
            {
                Console.WriteLine($"Giriş Başarılı! Sayının 2 katı: {sonucSayi * 2}");
            }
            else
            {
                Console.WriteLine("Hata: Bu bir sayı değildi!");
            }

            #endregion
        }

        static void DegerArttir (ref int kopyaSayi)
        {
            kopyaSayi = 99;
            Console.WriteLine("Metot: " + kopyaSayi);
        }

        static void ListeyiDegistir(int[] adres)
        {
            adres[0] = 999;
            Console.WriteLine("Metot List[0]: " +  adres[0]);
        }
    }
}