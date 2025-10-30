namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char devamMi;

            do
            {
                double sayi1, sayi2;
                double sonuc = 0;
                char islem;

                Console.WriteLine("----- Gelişmiş Hesap Makinesi -----");

                Console.Write("Birinci sayıyı giriniz: ");
                sayi1 = double.Parse(Console.ReadLine());

                Console.Write("İkinci sayıyı giriniz: ");
                sayi2 = double.Parse(Console.ReadLine());

                Console.Write("İşlem girin (+, -, *, /, %) ");
                islem = Convert.ToChar(Console.ReadLine());

                switch (islem)
                {
                    case '+':
                        sonuc = sayi1 + sayi2;
                        break;

                    case '-':
                        sonuc = sayi1 - sayi2;
                        break;

                    case '*':
                        sonuc = sayi1 * sayi2;
                        break;

                    case '/':
                        if (sayi2 != 0)
                        {
                            sonuc = sayi1 / sayi2;
                        }
                        else
                        {
                            Console.WriteLine("Hata: Bir sayı sıfıra bölünemez!");
                        }
                        break;

                    case '%':
                        sonuc = sayi1 % sayi2;
                        break;

                    default:
                        Console.WriteLine("Hata: Geçersiz bir işlem girdiniz!");
                        break;
                }

                if (islem == '+' || islem == '-' || islem == '*' || (islem == '/' && sayi2 != 0) || islem == '%')
                {
                    Console.WriteLine($"Sonuç: {sayi1} {islem} {sayi2} = {sonuc}");
                }

                Console.Write("\nYeni bir işlem yapmak ister misiniz? (E/H): ");
                devamMi = Convert.ToChar(Console.ReadLine());
            }while (devamMi == 'E' || devamMi == 'e');

            Console.WriteLine("Hesap makinesi kapatılıyor...");
        }
    }
}