using System;

namespace Exercise2
{

     class Artimetic
    {

        static void Main(string[] args)
        {

            float a, b;

            Console.WriteLine("Enter your first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your seconde number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose only one of the following");
            Console.WriteLine(" 1 for Addition, 2 for Substraction, 3 for Multiplication, 4 for Division");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine(Addition(a, b));
                    break;
                case "2":
                    Console.WriteLine(Subtraction(a, b));
                    break;
                case "3":
                    Console.WriteLine(Multiplication(a, b));
                    break;
                case "4":
                    Console.WriteLine(Division(a, b));
                    break;

            }

          static float Addition(float a, float b)
            {
                return a + b;
            }
            static float Subtraction(float a, float b)
            {
                return a - b;
            }
            static float Multiplication(float a, float b)
            {
                return a * b;
            }
            static float Division(float a, float b)
            {
                return a / b;
            }


        }
    }
}

