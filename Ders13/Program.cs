namespace Ders13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region while Döngüsü

            /*
            while (koşul) // Koşul 'true' olduğu sürece...
            {
                // ...bu kod bloğu tekrar tekrar çalışır.
            }
            */
            /*
            string dogruParola = "12345";
            string girilenParola = "";

            Console.Write("Lütfen parola giriniz: ");
            girilenParola = Console.ReadLine();

            while (girilenParola != dogruParola)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Hatalı parola!");
                Console.Write("Lütfen tekrar deneyiniz: ");
                girilenParola = Console.ReadLine();
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("Giriş başarılı! Hoş geldiniz.");
            */
            #endregion

            #region do-while Döngüsü

            /*
            do
            {
                // Bu kod bloğu en az 1 kez çalışır.
            } while (koşul); // DİKKAT: 'while' sonda ve sonunda ; (noktalı virgül) var!
            */

            char cevap;

            do
            {
                Console.WriteLine("-----------------------");

                Console.WriteLine("İşlem tamamlandı.");

                Console.Write("Yeni bir işlem yapmak istiyor musunuz? (E / H) ");
                cevap = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("-----------------------");
            } while (cevap == 'E' || cevap == 'e');

            Console.WriteLine("Programdan çıkılıyor...");

            #endregion
        }
    }
}