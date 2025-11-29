using AnimalKingdom.Hayvanlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Hayvanlar Alemi Simülasyonu ---");

            List<Hayvan> hayvanatBahcesi = new List<Hayvan>();

            hayvanatBahcesi.Add(new Kedi("Leydi", 1));
            hayvanatBahcesi.Add(new Kopek("Karabaş", 5));
            hayvanatBahcesi.Add(new Kus("Maviş", 6));
            hayvanatBahcesi.Add(new Kedi("Pamuk", 2));

            foreach (Hayvan h in hayvanatBahcesi)
            {
                h.BilgiYazdir();

                h.SesCikar();

                Console.WriteLine("--------------------------------------");
            }

            Console.WriteLine("Simülasyon tamamlandı.");
        }
    }
}
