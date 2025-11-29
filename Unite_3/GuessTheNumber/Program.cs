namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            char cevap;

            do
            {
                int gizliSayi = random.Next(1, 25);
                int tahmin = 0;
                int tahminSayisi = 0;

                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("\n1 ile 25 arasında sayı tuttum. Bakalım bulabilecek misin? ");

                while (tahmin != gizliSayi)
                {
                    Console.Write("Tahmininiz: ");
                    tahmin = Convert.ToInt32(Console.ReadLine());

                    tahminSayisi++;

                    if (tahmin < gizliSayi)
                    {
                        Console.WriteLine("Daha YÜKSEK bir sayı dene!");
                    }
                    else if (tahmin > gizliSayi)
                    {
                        Console.WriteLine("Daha DÜŞÜK bir sayı dene!");
                    }
                    else
                    {
                        Console.WriteLine($"TEBRİKLER! {gizliSayi} sayısını {tahminSayisi} denemede buldunuz.");
                    }
                }

                Console.Write("\nTekrar oynamak ister misiniz? (E/H): ");
                cevap = Convert.ToChar(Console.ReadLine().ToUpper());
            } while (cevap == 'E');
        }
    }
}