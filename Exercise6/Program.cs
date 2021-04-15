using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter number of rows");
            int a = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= a; i++)
            {
                for (j = 1; j <= a - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = a - 1; i >= 1; i--)
            {
                for (j = 1; j <= a - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
