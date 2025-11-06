namespace ConsoleNotesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> basliklar = new List<string>();
            List<string> icerikler = new List<string>();
            int secim, notSecimi;

            Console.WriteLine("Console Not Uygulamasına Hoş Geldiniz!");

            do
            {
                //Ana Menü
                Console.WriteLine("\n----- Ana Menü -----");
                Console.WriteLine("1. Yeni Not Ekle");
                Console.WriteLine("2. Notları Görüntüle");
                Console.WriteLine("3. Not Sil");
                Console.WriteLine("4. Çıkış");
                Console.Write("Lütfen seçiminizi yapın (1 - 4): ");

                try
                {
                    secim = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Hata: Lütfen sadece sayı girin!");
                    secim = 0;
                    continue;
                }

                //Seçim Yönlendirme
                switch (secim)
                {
                    case 1:
                        //1. Not Ekleme
                        Console.Write("\nNot Başlığı Girin: ");
                        string yeniBaslik = Console.ReadLine();

                        Console.Write("Not İçeriği Girin: ");
                        string yeniIcerik = Console.ReadLine();

                        //Listeye ekleme işlemi
                        basliklar.Add(yeniBaslik);
                        icerikler.Add(yeniIcerik);

                        Console.WriteLine("Not başarıyla eklendi!");
                        Console.ReadKey();
                        break;

                    case 2:
                        //2. Notları Görüntüle
                        Console.WriteLine("\n--- Kayıtlı Not Başlıkları ---");

                        if (basliklar.Count == 0)
                        {
                            Console.WriteLine("Kayıtlı not bulunamadı...");
                        }
                        else
                        {
                            //Aşama 1: sadece başlıkları göster
                            for (int i = 0; i < basliklar.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {basliklar[i]}");
                            }

                            //Aşama 2: kullanıya hangi notu görüntülemek istediğini sor
                            Console.Write("\nGörüntülemek istediğiniz notu seçiniz (Geri dönmek için 0 yazın): ");
                            try
                            {
                                notSecimi = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Hata: Geçerli bir sayı girmediniz!");
                                Console.ReadKey();
                                continue;
                            }

                            if (notSecimi == 0)
                            {
                                break; // ana menüye geri at
                            }

                            if (notSecimi > 0 && notSecimi <= basliklar.Count)
                            {
                                int indeks = notSecimi - 1;

                                //indeksleri kullanarak noptları çağır
                                Console.WriteLine("\n--- Seçilen Not Detayı ---");
                                Console.WriteLine($"Başlık: {basliklar[indeks]}");
                                Console.WriteLine("----------------------------");
                                Console.WriteLine($"İçerik: {icerikler[indeks]}");
                            }
                            else
                            {
                                Console.WriteLine("Hata: Geçersiz not numarası girdiniz!");
                            }
                        }

                        Console.ReadKey();
                        break;

                    case 3:
                        //3. Not Silme
                        Console.WriteLine("\n--- Kayıtlı Not Başlıkları ---");

                        if (basliklar.Count == 0)
                        {
                            Console.WriteLine("Kayıtlı not bulunamadı...");
                        }
                        else
                        {
                            //Aşama 1: sadece başlıkları göster
                            for (int i = 0; i < basliklar.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {basliklar[i]}");
                            }

                            //Aşama 2: kullanıya hangi notu silmek istediğini sor
                            Console.Write("\nSilmek istediğiniz notu seçiniz (Geri dönmek için 0 yazın): ");
                            try
                            {
                                notSecimi = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Hata: Geçerli bir sayı girmediniz!");
                                Console.ReadKey();
                                continue;
                            }

                            if (notSecimi == 0)
                            {
                                break; // ana menüye geri at
                            }

                            if (notSecimi > 0 && notSecimi <= basliklar.Count)
                            {
                                int indeks = notSecimi - 1;

                                //indeksleri kullanarak noptları çağır
                                Console.WriteLine("\n--- Silinen Not Detayı ---");
                                Console.WriteLine($"Başlık: {basliklar[indeks]}");
                                Console.WriteLine("----------------------------");
                                Console.WriteLine($"İçerik: {icerikler[indeks]}");

                                basliklar.Remove(basliklar[indeks]);
                                icerikler.Remove(icerikler[indeks]);
                            }
                            else
                            {
                                Console.WriteLine("Hata: Geçersiz not numarası girdiniz!");
                            }
                        }

                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Çıkış Yapılıyor...");
                        break;

                    default:
                        //Hatalı Seçim
                        Console.WriteLine("Hata: Lütfen geçerli işlem seçiniz!");
                        Console.ReadKey();
                        break;
                }

            } while (secim != 4);
        }
    }
}