using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region char veri tipi

            char harf = 'F';
            char rakam = '5';
            char sembol = '!';

            Console.WriteLine($"Harf: {harf}, Rakam: {rakam}, Sembol: {sembol}\n\n\n\n\n");

            #endregion

            #region string veri tipi

            //string isim = "Fatih";
            //string mesaj = "C# öğreniyorum.";
            //string isimMesaj = isim + " " + mesaj;
            //Console.WriteLine(isimMesaj);
            //Console.WriteLine("İsim: " + isim + "\n" + "Mesaj: " + mesaj);

            //string number1 = "50";
            //int number2 = 25;
            //Console.WriteLine(number1 + number2);

            string mesaj = "C# öğreniyorum.";
            Console.WriteLine("Metnin uzunluğu: " + mesaj.Length);
            Console.WriteLine($"Büyük Harf: {mesaj.ToUpper()}");
            Console.WriteLine($"Küçük Harf: {mesaj.ToLower()}\n\n\n\n\n");

            #endregion

            #region bool veri tipi

            bool kullancıGirisYaptiMi = true;
            bool urunStoktaVarMi = false;
            bool isAdmin = true;

            Console.WriteLine($"Kullanıcı giriş yaptı mı? {kullancıGirisYaptiMi}");
            Console.WriteLine($"Ürün stokta var mı? {urunStoktaVarMi}");

            #endregion
        }
    }
}
