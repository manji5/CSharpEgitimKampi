namespace StudentPortal
{
    internal class Program
    {
        static List<Ogrenci> ogrenciListesi = new List<Ogrenci>();

        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Yönetim Portalına Hoş Geldiniz!");
            int secim;

            do
            {
                //Menü
                Console.WriteLine("\n--- Ana Menü ---");
                Console.WriteLine("1. Öğrenci Ekle");
                Console.WriteLine("2. Öğrencileri Listele");
                Console.WriteLine("3. Çıkış");
                Console.Write("Seçiminiz (1-3): ");

                try
                {
                    secim = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Hata: Bir sayı girmelisiniz!");
                    secim = 0;
                    continue;
                }

                //Seçimi Yönlendir
                switch (secim)
                {
                    case 1: 
                        OgrenciEkle();
                        break;

                    case 2:
                        OgrencileriListele();
                        break;

                    case 3:
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;

                    default:
                        Console.WriteLine("Hata: Geçersiz seçim!");
                        break;
                }

            }while (secim != 3);

            Console.WriteLine("Program kapatıldı.");
        }

        static void OgrenciEkle()
        {
            Console.WriteLine("\n--- Yeni Öğrenci Ekleme ---");

            Console.Write("Öğrenci Adı:");
            string ad = Console.ReadLine();

            Console.Write("Öğrenci Soyadı:");
            string soyad = Console.ReadLine();

            Console.Write("Öğrenci Numarası:");
            int numara = Convert.ToInt32(Console.ReadLine());

            Console.Write("Öğrenci Notu:");
            int not = Convert.ToInt32(Console.ReadLine());

            Ogrenci yeniOgrenci = new Ogrenci(ad, soyad, numara, not);

            ogrenciListesi.Add(yeniOgrenci);

            Console.WriteLine("Öğrenci başarıyla eklendi!");
        }

        static void OgrencileriListele()
        {
            Console.WriteLine("\n--- Kayıtlı Öğrenciler ---");

            if (ogrenciListesi.Count == 0)
            {
                Console.WriteLine("Sistemde kayıtlı öğrenci bulunamadı.");
                return;
            }

            foreach (Ogrenci ogrenci in ogrenciListesi)
            {
                ogrenci.BilgiYadir();
            }
        }
    }
}