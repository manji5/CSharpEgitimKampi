namespace Ders7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  ">" (Büyük mü?)
             *  "<" (Küçük mü?)
             *  ">=" (Büyük veya Eşit mi?)
             *  "<=" (Küçük veya Eşit mi?)
             */

            #region Tekli Karşılaştırma
            //int sayi1 = 10;
            //int sayi2 = 5;

            //bool sonuc = sayi1 > sayi2;
            //Console.WriteLine("10, 5'ten büyük mü? " + sonuc);

            //bool sonuc2 = sayi1 < sayi2;
            //Console.WriteLine("10, 5'ten küçük mü? " + sonuc2);

            //bool sonuc3 = sayi1 >= sayi2;
            //Console.WriteLine("10, 5'ten büyük veya eşit mi? " + sonuc3);

            //bool sonuc4 = sayi1 <= sayi2;
            //Console.WriteLine("10, 5'ten küçük veya eşit mi? " + sonuc4);

            //Console.WriteLine("\n\n\n\n\n");

            //bool sonuc5 = sayi1 == sayi2;
            //Console.WriteLine("10, 5'e eşit mi? " + sonuc5);

            //bool sonuc6 = sayi1 != sayi2;
            //Console.WriteLine("10, 5'e eşit değil mi? " + sonuc6);
            #endregion

            #region İkili Karşılaştırma
            //int yas = 20;
            //bool ehliyetVar = true;

            //bool arabaKullananilirMi = (yas < 18) && (ehliyetVar == true);
            //Console.WriteLine($"Araba kullanabilir mi? {arabaKullananilirMi}\n\n");

            //bool arabaKullananilirMi2 = (yas < 18) || (ehliyetVar == true);
            //Console.WriteLine($"Araba kullanabilir mi? {arabaKullananilirMi2}\n\n");
            #endregion

            #region Değil Operatörü

            bool girisYapildiMi = false;

            Console.WriteLine("Giriş yapıldı mı? " +  girisYapildiMi);
            Console.WriteLine("Giriş yapıldı mı? " +  !girisYapildiMi);

            #endregion
        }
    }
}