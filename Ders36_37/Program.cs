using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders36_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ders 36
            //#region Klasor Oluşturma
            //string klasorYolu = @"D:\DenemeKlasoru";

            //if (Directory.Exists(klasorYolu)) 
            //{
            //    Console.WriteLine("Bu klasör zaten var!");
            //}
            //else
            //{
            //    Directory.CreateDirectory(klasorYolu);
            //    Console.WriteLine("Klasör başarıyla oluşturuldu.");
            //}
            //#endregion

            //#region Dosya Islemleri

            ////File.Exists(yol)
            ////File.Copy(kaynak, hedef)
            ////File.Move(kaynak, hedef)
            ////File.Delete(yol)

            //string dosyaYolu = @"D:\DenemeKlasoru\notlar.txt";
            //string kopyaYolu = @"D:\DenemeKlasoru\yedek_notlar.txt";

            //if (File.Exists(dosyaYolu))
            //{
            //    //kopyalama
            //    //File.Copy(dosyaYolu, kopyaYolu);
            //    Console.WriteLine("Dosya yedeklendi.");

            //    //silme
            //    File.Delete(dosyaYolu);
            //    Console.WriteLine("Orjinal dosya silindi.");

            //}
            //else
            //{
            //    Console.WriteLine("İşlem Yapılacak Dosya Bulunamadı");

            //    //oluşturma
            //    File.Create(dosyaYolu).Close();
            //}

            //#endregion
            #endregion

            #region Ders 37

            string dosyaYolu = "notlarim.txt";

            //Dosyaya yazma
            //using (StreamWriter yazar = new StreamWriter(dosyaYolu, append: true))
            //{
            //    yazar.WriteLine("Bugün hava çok güzel.");
            //    yazar.WriteLine("C# öğrenmek harika.");
            //}

            //Console.WriteLine("Dosyaya yazıldı.");

            if (File.Exists(dosyaYolu))
            {
                using (StreamReader okuyucu = new StreamReader(dosyaYolu))
                {
                    string satir;

                    while ((satir = okuyucu.ReadLine()) != null)
                    {
                        Console.WriteLine(satir);
                    }
                }
            }
            else
            {
                Console.WriteLine("Okunacak dosya bulunamadı");
            }

            #endregion
        }
    }
}
