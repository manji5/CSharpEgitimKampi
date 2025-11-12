namespace SimpleLibraryFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Kütüphane Fonksiyonları Testi ---");

            //1.Kare alma
            int sayi1 = 7;
            Console.WriteLine($"{sayi1} sayısının karesi: {KareAl(sayi1)}");

            //2.Faktöriyel testi
            int sayi2 = 6;
            Console.WriteLine($"{sayi2} sayısının faktöriyeli: {FaktoriyelHesaplama(sayi2)}");

            //3.Asal sayı testi
            int sayi3 = 13;
            int sayi4 = 15;
            Console.WriteLine($"{sayi3} sayısı asal mı? : {AsalSayiMi(sayi3)}");
            Console.WriteLine($"{sayi4} sayısı asal mı? : {AsalSayiMi(sayi4)}");
        }

        //Kare alma
        static int KareAl(int x)
        {
            return x * x;
        }

        //Faktöriyel hesaplama
        static int FaktoriyelHesaplama(int x)
        {
            long sonuc = 1;

            if (x == 0 || x == 1)
            {
                return 1;
            }

            for (int i = 2; i <= x; i++)
            {
                sonuc = sonuc * i;
            }

            return (int)sonuc;
        }

        //Asal sayi
        static bool AsalSayiMi(int x)
        {
            if (x < 2)
            {
                return false;
            }

            if (x == 2)
            {
                return true;
            }

            if (x % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i <= Math.Sqrt(x); i += 2)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}