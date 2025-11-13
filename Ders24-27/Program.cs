namespace Ders24_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk Öğrenci Sayısı: " + Ogrenci.ToplamOgrenciSayisi);
            Ogrenci ogr1 = new Ogrenci("Ali", 90);
            Ogrenci ogr2 = new Ogrenci("Ayşe", 100);

            ogr1.BilgiYazdir();
            ogr2.BilgiYazdir();

            Console.WriteLine("Oluşturulan Öğrenci Sayısı: " + Ogrenci.ToplamOgrenciSayisi);

            if (ogr1.GectiMi())
            {
                Console.WriteLine("Ali dersten geçti.");
            }
            if (ogr2.GectiMi())
            {
                Console.WriteLine("Ayşe dersten geçti.");
            }

        }
    }
}