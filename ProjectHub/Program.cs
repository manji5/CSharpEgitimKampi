using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            //Menü
            string[] secenekler =
            {
                "Hesap Makinesi",
                "Sayı Tahmin Oyunu",
                "Günlük Uygulaması",
                "Çıkış"
            };

            int seciliIndex = 0;

            while (true)
            {
                //1. Menü Çizme
                Console.Clear();
                Console.ResetColor();

                //Başlık
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("==========================================");
                Console.WriteLine("      C# PROJECT HUB (UYGULAMA MERKEZİ)   ");
                Console.WriteLine("==========================================\n");
                Console.ResetColor();

                for (int i = 0; i < secenekler.Length; i++)
                {
                    if (i == seciliIndex)
                    {
                        //Seçili satırı boya
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"  >> {secenekler[i]} <<  ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"    {secenekler[i]}    ");
                    }
                }

                //2. Tuş okuma ve hareket kısmı
                ConsoleKeyInfo tus = Console.ReadKey(true);

                if (tus.Key == ConsoleKey.UpArrow)
                {
                    seciliIndex--;
                    if (seciliIndex < 0) seciliIndex = secenekler.Length - 1;
                }
                else if (tus.Key == ConsoleKey.DownArrow)
                {
                    seciliIndex++;
                    if (seciliIndex >= secenekler.Length) seciliIndex = 0;
                }
                else if (tus.Key == ConsoleKey.Enter)
                {
                    //3.Seçim yapıldığında

                    //ekranı temizleme ve imleci açma
                    Console.CursorVisible = true;
                    Console.Clear();

                    switch (seciliIndex)
                    {
                        case 0:
                            CalculatorApp();
                            break;
                        case 1:
                            GuessTheNumber();
                            break;
                        case 2:
                            DiaryApp();
                            break;
                        case 3:
                            Console.WriteLine("Çıkış yapılıyor. Hoşça kalın!");
                            return;
                    }

                    //Uygulamaya dönmeden önce beklet
                    Console.WriteLine("\nAna menüye dönmek için bir tuşa basın...");
                    Console.ReadKey();

                    //Menüye dönünce imleci gizle
                    Console.CursorVisible = false;
                }
            }
        }

        static void CalculatorApp()
        {
            char devamMi;

            do
            {
                double sayi1, sayi2;
                double sonuc = 0;
                char islem;

                Console.WriteLine("----- Gelişmiş Hesap Makinesi -----");

                Console.Write("Birinci sayıyı giriniz: ");
                sayi1 = double.Parse(Console.ReadLine());

                Console.Write("İkinci sayıyı giriniz: ");
                sayi2 = double.Parse(Console.ReadLine());

                Console.Write("İşlem girin (+, -, *, /, %) ");
                islem = Convert.ToChar(Console.ReadLine());

                switch (islem)
                {
                    case '+':
                        sonuc = sayi1 + sayi2;
                        break;

                    case '-':
                        sonuc = sayi1 - sayi2;
                        break;

                    case '*':
                        sonuc = sayi1 * sayi2;
                        break;

                    case '/':
                        if (sayi2 != 0)
                        {
                            sonuc = sayi1 / sayi2;
                        }
                        else
                        {
                            Console.WriteLine("Hata: Bir sayı sıfıra bölünemez!");
                        }
                        break;

                    case '%':
                        sonuc = sayi1 % sayi2;
                        break;

                    default:
                        Console.WriteLine("Hata: Geçersiz bir işlem girdiniz!");
                        break;
                }

                if (islem == '+' || islem == '-' || islem == '*' || (islem == '/' && sayi2 != 0) || islem == '%')
                {
                    Console.WriteLine($"Sonuç: {sayi1} {islem} {sayi2} = {sonuc}");
                }

                Console.Write("\nYeni bir işlem yapmak ister misiniz? (E/H): ");
                devamMi = Convert.ToChar(Console.ReadLine());
            } while (devamMi == 'E' || devamMi == 'e');

            Console.WriteLine("Hesap makinesi kapatılıyor...");
        }

        static void GuessTheNumber()
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
        
        static void DiaryApp()
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

            void GunlukYaz()
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

            void GunlukOku()
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

            void GunlukSil()
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
}
