using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter your string");
            input = Console.ReadLine();
            char[] toChar = input.ToCharArray();
            Array.Reverse(toChar);
            Console.WriteLine(new string(toChar));
        }
    }
}
