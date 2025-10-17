using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implict veri tipi dönüşümü
            //int tamSayi = 50;
            //double ondalikliSayi = tamSayi;

            //Console.WriteLine(ondalikliSayi);
            #endregion

            #region Excplict veri tipi dönüşüm
            //double ondalikliSayi2 = 99.85;
            //Console.WriteLine(ondalikliSayi2);

            //int tamSayi2 = (int)ondalikliSayi2;
            //Console.WriteLine(tamSayi2);
            #endregion

            #region Conver ile dönüştürme
            //string metinYas = "28";
            //int sayiYas = Convert.ToInt32(metinYas);

            //Console.WriteLine($"Kullanıcın 5 yıl sonraki yaşı : {sayiYas + 5}");
            #endregion

            #region Parse ile dönüşüm

            //string metinFiyat = "149.99";
            //string metinStok = "250";

            //double sayiFiyat = double.Parse(metinFiyat);
            //int sayiStok = int.Parse(metinStok);

            //Console.WriteLine($"Ürünün KDV dahil fiyatı: {sayiFiyat}, Ürünün stok sayısı: {sayiStok}");

            #endregion
        }
    }
}
