namespace Ders9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tekli if
            //Console.WriteLine("Lütfen yaşınızı giriniz: ");
            //int yas = int.Parse(Console.ReadLine());

            //if (yas >= 18)
            //{
            //    Console.WriteLine("Mekana hoş geldiniz!");
            //    Console.WriteLine("Giriş işleminiz tamamlandı.");
            //}

            //Console.WriteLine("Program Bitti");
            #endregion

            #region if else

            Console.Write("Sınav notunuzu giriniz: ");
            int not = int.Parse(Console.ReadLine());

            if (85 <= not && not <= 100)
            {
                Console.WriteLine("A");
            }
            else if (70 <= not && not <= 84)
            {
                Console.WriteLine("B");
            }
            else if (50 <= not && not <= 69)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("Maalesef dersten kaldınız...");
            }

            #endregion
        }
    }
}