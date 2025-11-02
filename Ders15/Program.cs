namespace Ders15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // veriTipi[] diziAdi;

            int[] not;
            string[] isimler;

            // diziAdi = new veriTipi[boyut]

            //int[] notlar;
            //notlar = new int[30];

            int[] notlar = new int[3];

            // boyut - 1 
            notlar[0] = 70;
            notlar[1] = 85;
            notlar[2] = 90;

            Console.WriteLine($"İlk öğrencinin notu: {notlar[0]}");
            Console.WriteLine($"İkinci öğrencinin notu: {notlar[1]}");
            Console.WriteLine($"Üçüncü öğrencinin notu: {notlar[2]}");
            Console.WriteLine($"Dördüncü öğrencinin notu: {notlar[3]}");
        }
    }
}