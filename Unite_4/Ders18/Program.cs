using System.Collections;

namespace Ders18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList dinamikListe = new ArrayList();

            dinamikListe.Add("Merhaba");
            dinamikListe.Add(100);
            dinamikListe.Add(true);
            dinamikListe.Add('a');

            Console.WriteLine($"Listedeki eleman sayısı: {dinamikListe.Count}");

            //dinamikListe.Remove('a');
            //dinamikListe.RemoveAt(0);

            ////Console.WriteLine(dinamikListe[0]);

            //foreach (object eleman in dinamikListe)
            //{
            //    Console.WriteLine(eleman);
            //}

            int sayi = (int)dinamikListe[1];
            Console.WriteLine(sayi + 5);

            int sayi2 = (int)dinamikListe[0];
        }
    }
}