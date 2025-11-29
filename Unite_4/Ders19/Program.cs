namespace Ders19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> notlar = new List<int>();
            List<string> isimler = new List<string>();

            isimler.Add("Ahmet");
            isimler.Add("Mehmet");

            Console.WriteLine($"Listede {isimler.Count} kişi var.");
            //isimler.Remove("Mehmet");
            Console.WriteLine($"Listede {isimler.Count} kişi var.");

            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }

            notlar.Add(80);
            notlar.Add(55);
            notlar.Add(99);
            notlar.Add(68);

            foreach (int not in notlar)
            {
                Console.WriteLine(not);
            }

            int bulunan = notlar.Find(x => x > 75);

            Console.WriteLine($"75'den büyük bulunan ilk sayı: {bulunan}");
        }
    }
}