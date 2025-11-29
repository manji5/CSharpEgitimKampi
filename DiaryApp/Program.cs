using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kişisel Günlük Uygulamasına Hoş Geldiniz!");
            string secim;

            do
            {
                Console.WriteLine("\n--- MENÜ ---");
                Console.WriteLine("1. Günlük Yaz");
                Console.WriteLine("2. Günlük Oku");
                Console.WriteLine("3. Günlüğü Sil (Sıfırla)");
                Console.WriteLine("4. Çıkış");
                Console.Write("Seçim: ");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        GunlukYaz();
                        break;

                    case "2":
                        GunlukOku();
                        break;

                    case "3":
                        GunlukSil();
                        break;

                    case "4":
                        Console.WriteLine("Görüşmek üzere...");
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }

            } while (secim != "4");
        }

        static void GunlukYaz()
        {
            string dosyaYolu = "gunluk.txt";

            Console.WriteLine("\n--- Sevgili Günlük... (Yazmayı bitirmek için ENTER'a bas)");
            string metin = Console.ReadLine();

            using (StreamWriter yazar = new StreamWriter(dosyaYolu, append: true))
            {
                yazar.WriteLine($"[{DateTime.Now}]");
                yazar.WriteLine(metin);
                yazar.WriteLine("----------------------------------------------------------------------------------");
            }

            Console.WriteLine("Günlük başarıyla kaydedildi!");
        }

        static void GunlukOku()
        {
            string dosyaYolu = "gunluk.txt";

            Console.WriteLine("\n--- Eski Anılar ---");
            
            if (File.Exists(dosyaYolu))
            {
                using (StreamReader okuyucu = new StreamReader(dosyaYolu))
                {
                    string icerik = okuyucu.ReadToEnd();
                    Console.WriteLine(icerik);
                }
            }
            else
            {
                Console.WriteLine("Henüz hiç günlük yazılmamış. İlk yazan sen ol!");
            }

            Console.WriteLine("\n(Devam etmek için bir tuşa basın...)");
            Console.ReadKey();
        }

        static void GunlukSil()
        {
            string dosyaYolu = "gunluk.txt";

            if (File.Exists(dosyaYolu))
            {
                Console.WriteLine("Tüm günlüğü silmek istediğine emin misin? (E/H): ");
                string cevap = Console.ReadLine().ToUpper();

                if (cevap == "E")
                {
                    File.Delete(dosyaYolu);
                    Console.WriteLine("Günlük silindi. Tertemiz bir sayfa!");
                }
                else
                {
                    Console.WriteLine("İşlem iptal edildi.");
                }
            }
            else
            {
                Console.WriteLine("Silinecek bir günlük dosyası bulunamadı.");
            }
        }
    }
}
