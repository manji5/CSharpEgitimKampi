namespace Ders8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sayısal İfadelerde Atama ve Bileşik Atama
            //int skor = 100;
            //Console.WriteLine($"Başlangıç Skoru: {skor}");

            //skor = skor + 50;
            //Console.WriteLine($"Yeni Skor: {skor}");

            //int bakiye = 1000;
            //Console.WriteLine($"Başlangıç Bakiyesi: {bakiye}");

            //bakiye += 500; // bakiye = bakiye + 500;
            //Console.WriteLine($"Arttırılmış Bakiye: {bakiye}");

            //bakiye -= 200; // 1500 - 200 -- bakiye = bakiye - 200;
            //Console.WriteLine($"Çıkarılmış Bakiye: {bakiye}");

            //bakiye *= 2;
            //Console.WriteLine($"Çarpılmış Bakiye: {bakiye}");

            //bakiye /= 2;
            //Console.WriteLine($"Bölünmüş Bakiye: {bakiye}");
            #endregion

            string mesaj = "Merhaba";
            // Merhaba, Dünya!
            mesaj += ", Dünya!";

            Console.WriteLine(mesaj);
        }
    }
}