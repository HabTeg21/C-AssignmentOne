using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter your first number (Starting number):");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your seconde number (Ending number):");
            b = Convert.ToInt32(Console.ReadLine());
            //int  x = a;

            while (a < b)
            {
                if (Check(a) != 0)
                    Console.WriteLine(Check(a));
                a++;
            }
        }
        static int Check(int a)
        {
            int sum, rem, temp, x = a;
            sum = 0;
            temp = x;
            while (x > 0)
            {
                rem = x % 10;
                sum += (rem * rem * rem);
                x = x / 10;
            }

            if (temp == sum)
                return temp;
            else
                return 0;
        }
    }
    
}
