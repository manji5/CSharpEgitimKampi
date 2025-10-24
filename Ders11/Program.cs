namespace Ders11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Deneme 1
            //Console.Write("Notonuzu Giriniz: ");
            //int not = int.Parse(Console.ReadLine());

            #region if-else
            //string durum;
            //if (not >= 50)
            //{
            //    durum = "Geçti";
            //}
            //else
            //{
            //    durum = "Kaldı";
            //}
            #endregion

            // (koşul) ? dogruysa : yanlışsa;

            //string durum = (not >= 50) ? "Geçti" : "Kaldı";

            //Console.WriteLine(durum);
            #endregion

            int sayi = 5;

            string sonuc = (sayi % 2 == 0) ? "Sayı Çifttir." : "Sayı Tektir.";
            Console.WriteLine(sonuc);
        }
    }
}