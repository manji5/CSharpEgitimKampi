namespace Ders12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (başlatma; koşul; artırma)
            {
                // Koşul 'true' olduğu sürece bu blok tekrar tekrar çalışır.
            }
            */

            for (int i = 0; i <= 23; i++)
            {
                for (int j = 0; j <= 59; j++)
                {
                    Console.WriteLine($"Saat: {i}:{j}");
                }
            }
        }
    }
}