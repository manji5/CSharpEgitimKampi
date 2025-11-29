namespace Ders23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            
            Console.WriteLine(Topla(5, 3));
            Console.WriteLine(Topla(5, 3, 7));
            Console.WriteLine(Topla(5.8, 3.3, 7.4));
        }

        static int Topla(int a, int b) { return a + b; }
        static int Topla(int a, int b, int c) { return a + b + c; }
        static double Topla(double a, double b, double c) { return a + b + c; }

        static void BilgiVer(string isim, int yas)
        {
            Console.WriteLine($"{isim}, {yas} yaşında.");
        }

        static void BilgiVer(int yas, string isim)
        {
            Console.WriteLine($"{yas} yaşındaki {isim}!");
        }
    }
}