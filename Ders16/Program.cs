namespace Ders16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // veriTipi[,] diziAdi;

            //int[,] sinavNotlari;
            //sinavNotlari = new int[2,3];

            int[,] sinavNotlari = new int[2,3];

            sinavNotlari[0, 0] = 80;
            sinavNotlari[0, 1] = 85;
            sinavNotlari[0, 2] = 90;

            sinavNotlari[1, 0] = 70;
            sinavNotlari[1, 1] = 65;
            sinavNotlari[1, 2] = 75;

            Console.WriteLine($"2.Öğrencinin 3.sınavı: {sinavNotlari[1,2]}");

            string[,] bolgeler =
            {
                    { "İstanbul", "Bursa", "Edirne" },  // 0. Satır (Marmara)
                    { "Ankara", "Konya", "Kayseri" },  // 1. Satır (İç Anadolu)
                    { "İzmir", "Aydın", "Manisa" }      // 2. Satır (Ege)
            };
            // boyut - 1
            Console.WriteLine(bolgeler[2, 0] );

            int[,,] kup = new int[2,3,4];

            kup[0, 1, 2] = 50;
        }
    }
}