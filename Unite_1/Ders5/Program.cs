using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Lütfen bir şey yazın ve Enter'a tıklayın: ");
            //string kullaniciGirisi = Console.ReadLine();
            //Console.WriteLine($"Kullanıcıdan gelen giriş: {kullaniciGirisi}");

            //Console.Write("Adınız nedir? ");
            //string isim = Console.ReadLine();
            //Console.WriteLine($"Hoş geldin, {isim}.");

            Console.Write("Yaşınız kaç? ");
            //string metinYas = Console.ReadLine();

            int sayiYas = int.Parse(Console.ReadLine());
            Console.WriteLine(sayiYas + 10);
        }
    }
}
