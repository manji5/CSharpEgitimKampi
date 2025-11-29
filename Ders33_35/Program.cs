using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders33_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exception Handling

            ////try
            ////{
            ////    //Hata çıkma ihtimali olan kodlar
            ////}
            ////catch
            ////{
            ////    //Gata durumunda burası çalışır
            ////    //B planı buraya yazılır.
            ////}

            //Console.WriteLine("--- Bölme İşlemi ---");

            //try
            //{
            //    Console.Write("1. Sayı: ");
            //    int s1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("2. Sayı: ");
            //    int s2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = s1 / s2;

            //    Console.WriteLine("Sonuç: " + sonuc);
            //}
            //catch (Exception ex) 
            //{
            //    // Hata olursa çalışıcak blok
            //    Console.WriteLine("HATA OLUŞTU!");
            //    Console.WriteLine("Sistemin verdiği hata mesajı: " + ex.Message);
            //}

            #endregion

            #region Çoklu catch Yapısı

            ///*
            // * DivideByZeroException: Sifira bölme hatası
            // * FormatException: Sayı yerine harf girilmesi
            // * OverflowException: int sınırını aşmak
            // * Exception: Tüm hataların atası
            // */

            //bool acik = true;
            //while (acik)
            //{
            //    Console.Write("Böleceğiniz sayıyı girin: ");
            //    try
            //    {
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        int sonuc = 100 / sayi;
            //        Console.WriteLine($"100 / {sayi} = {sonuc}");
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        Console.WriteLine("Hata: Matematik kurallarına aykırı! 0'a bölmezsin.");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Hata: Lütfen geçerli bir sayı giriniz (harf girdiniz).");
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Hata: Girdiğiniz sayı çok büyük.");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Beklenmedik bir hata oluştu: " + ex.Message);
            //    }
            //    finally
            //    {
            //        acik = false;
            //    }
            //}

            #endregion

            #region throw Anahtar Kelimesi

            Ogrenci ogr = new Ogrenci();
            try
            {
                Console.Write("Öğrenci notunu giriniz: ");
                int gNot = Convert.ToInt32(Console.ReadLine());

                ogr.Not = gNot;
                Console.WriteLine("Not başarıyla atandı.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("HATA: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Beklenmedik hata oluştu: " + ex.Message);
            }

            #endregion

        }
    }
}
