using System;

namespace Exercise5
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int a, last = 0;
            Console.Write("Enter the Number of Rows : ");
            a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (last == 1)
                    {
                        Console.Write("0");
                        last = 0;
                    }
                    else if (last == 0)
                    {
                        Console.Write("1");
                        last = 1;
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
