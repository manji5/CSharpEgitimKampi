namespace Ders20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Selamla("Fatih");
            int secim;

            do
            {
                MenuyuGoster();
                Console.Write("Seçiminiz: ");
                secim = int.Parse(Console.ReadLine());

                NotEkle();

            }while (false);
        }

        static void MenuyuGoster()
        {
            //Ana Menü
            Console.WriteLine("\n----- Ana Menü -----");
            Console.WriteLine("1. Yeni Not Ekle");
            Console.WriteLine("2. Notları Görüntüle");
            Console.WriteLine("3. Not Sil");
            Console.WriteLine("4. Çıkış");
            Console.Write("Lütfen seçiminizi yapın (1 - 4): ");
        }

        static void NotEkle()
        {
            List<string> basliklar = new List<string>();
            List<string> icerikler = new List<string>();

            string baslik, icerik;

            Console.Write("Başlık: ");
            baslik = Console.ReadLine();

            Console.Write("İçerik: ");
            icerik = Console.ReadLine();

            basliklar.Add(baslik);
            icerikler.Add(icerik);

            Console.WriteLine($"{basliklar[0]}\n{icerikler[0]}");
        }

        static void Selamla(string isim)
        {
            Console.WriteLine($"Merhaba, {isim}!");
        }
    }
}