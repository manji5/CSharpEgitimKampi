using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders38_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Console Renkleri ve Cursor Pozisyonu

            ///* 
            // * ForegroundColor: Yazının rengi
            // * BackgroundColor: Yazının arkasındaki renk
            // * ResetColor(): Ayarları varsayıla döndürür
            // */

            //Console.WriteLine("Normal yazı");

            ////hata
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Hata: Bağlantı kurulamadı!");

            ////başarı mesajı
            //Console.ResetColor();
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.WriteLine("Başarılı: Veriler kaydedildi.");

            ////reset
            //Console.ResetColor();


            //// ---------- İmleç pozisyonu
            ////(left = x, right = y)
            ////Console.Clear(): ekranı tamamen siler
            ////Console.SetCursorPosition(x,y) : İmceli belirtilen pozisyona taşır

            //Console.Clear();

            //Console.SetCursorPosition(20, 10);

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("***********************");

            //Console.SetCursorPosition(20, 11);
            //Console.WriteLine("* Merhaba C# Dünyası! *");

            //Console.SetCursorPosition(20, 12);
            //Console.WriteLine("***********************");

            //Console.ResetColor();
            //Console.SetCursorPosition(0, 20);

            #endregion

            #region Basit Menü Navigasyonu

            Console.WriteLine("Bir tuşa bas (ok tuşlarını dene)...");

            ////basılan tuşun bilgisini tutma
            //ConsoleKeyInfo basilanTus = Console.ReadKey(true);

            //if (basilanTus.Key == ConsoleKey.UpArrow)
            //{
            //    Console.WriteLine("Yukarı bastın!");
            //}
            //else if (basilanTus.Key == ConsoleKey.DownArrow)
            //{
            //    Console.WriteLine("Aşağı bastın!");
            //}

            // 1. Menü Seçeneklerimiz
            string[] secenekler = { "Yeni Oyun", "Ayarlar", "Hakkında", "Çıkış" };
            int seciliSıra = 0;

            while(true)
            {
                Console.Clear();
                Console.WriteLine("--- Oyun Menüsü ----\n");

                // 2. Seçenekleri Ekrana Yazdır
                for (int i = 0; i < secenekler.Length; i++)
                {
                    if (i == seciliSıra)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($">> {secenekler[i]} <<");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"    {secenekler[i]}");
                    }
                }

                // 3. Tuşu Oku
                ConsoleKeyInfo tus = Console.ReadKey(true);

                // 4. Tuşa Göre Hareket Et
                if (tus.Key == ConsoleKey.UpArrow)
                {
                    seciliSıra--;
                    if (seciliSıra < 0) seciliSıra = secenekler.Length - 1;
                }
                else if (tus.Key == ConsoleKey.DownArrow)
                {
                    seciliSıra++;
                    if (seciliSıra >= secenekler.Length) seciliSıra = 0;
                }
                else if (tus.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }

            // 5. Sonuç
            Console.Clear();
            Console.WriteLine($"Seçiminiz yapıldı: {secenekler[seciliSıra]}");

            #endregion
        }
    }
}
