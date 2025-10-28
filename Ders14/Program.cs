namespace Ders14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }
                Console.WriteLine("Continue: " + i);
            }

            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    break;
                }
                Console.WriteLine("Break: " + i);
            }
        }
    }
}