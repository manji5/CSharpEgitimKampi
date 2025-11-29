namespace Ders10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen haftanın günün rakam olarak yazınız: ");
            int gun = int.Parse(Console.ReadLine());
            #region if-else
            //if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen geçerli bir gün giriniz.");
            //}
            #endregion

            #region switch-case

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;

                case 2:
                    Console.WriteLine("Salı");
                    break;

                case 3:
                    Console.WriteLine("Çarşamba");
                    break;

                case 4:
                    Console.WriteLine("Perşembe");
                    break;

                case 5:
                    Console.WriteLine("Cuma");
                    break;

                case 6:
                    Console.WriteLine("Cumartesi");
                    break;

                case 7:
                    Console.WriteLine("Pazar");
                    break;

                default:
                    Console.WriteLine("Lütfen geçerli bir gün giriniz.");
                    break;
            }

            #endregion
        }
    }
}