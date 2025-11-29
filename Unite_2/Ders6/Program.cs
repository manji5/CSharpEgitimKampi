using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.Sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"1.Sayı: {sayi1}, 2.Sayı: {sayi2}\n\n\n");

            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;
            int carpım = sayi1 * sayi2;

            Console.WriteLine($"Toplam = {toplam}");
            Console.WriteLine($"Fark = {fark}");
            Console.WriteLine($"Çarpım = {carpım}\n\n\n");

            int bolum1 = sayi1 / sayi2;
            Console.WriteLine($"Bölüm (int) = {bolum1}");

            double bolum2 = (double)sayi1 / sayi2;
            Console.WriteLine($"Bölüm (double) = {bolum2}\n\n\n");

            int mod = sayi1 % sayi2;
            Console.WriteLine($"Kalan (mod) = {mod}\n\n\n");

            sayi1++;
            sayi1--;
            Console.WriteLine(sayi1);
        }
    }
}