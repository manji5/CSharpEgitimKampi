namespace Ders17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for

            //string[,] bolgeler = {
            //    { "İstanbul", "Bursa", "Edirne" },
            //    { "Ankara", "Konya", "Kayseri" },
            //    { "İzmir", "Aydın", "Manisa" }
            //};

            //for (int satir = 0; satir < 3; satir++)
            //{
            //    for (int sutun = 0; sutun < 3; sutun++)
            //    {
            //        Console.WriteLine(bolgeler[satir, sutun]);
            //    }
            //}

            #endregion

            /*
             * foreach (veriTipi degiskenAdi in koleksiyon) 
             * {
             *      kodlar
             * }
             */

            //int[] notlar = { 80, 90, 75, 100 };

            //foreach (int not in notlar)
            //{
            //    Console.WriteLine(not);
            //}

            string[,] bolgeler = {
                { "İstanbul", "Bursa", "Edirne" },
                { "Ankara", "Konya", "Kayseri" },
                { "İzmir", "Aydın", "Manisa" }
            };

            foreach (string sehirler in bolgeler)
            {
                Console.WriteLine(sehirler);
            }
        }
    }
}