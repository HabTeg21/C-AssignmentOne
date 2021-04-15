using System;

namespace Exercise7
{
    class Program
    {
        static double amount = 1000;
        static void Main(string[] args)
        {
          
            int PINNum;
            int choice = 4;
            Console.WriteLine("Enter your PIN");
            PINNum = Convert.ToInt32(Console.ReadLine());
            do
            {
             
                if (PINNum == 123)
                {
                    Console.WriteLine("********Welcome to ATM Service**************");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Withdraw Cash");
                    Console.WriteLine("3. Deposit Cash");
                    Console.WriteLine("4. Quit");
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("Enter your choice:");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            CheckBalance();
                            break;
                        case 2:
                            Console.WriteLine("Enter the amount to Withdraw");
                            double withdraw = double.Parse(Console.ReadLine());
                            Console.WriteLine("Your current amount after withdrawal of " + withdraw + " is " + WithdrawCash(withdraw));
                            break;
                        case 3:
                            Console.WriteLine("Enter the amount to Deposit");
                            double deposit = double.Parse(Console.ReadLine());
                            Console.WriteLine("Your current amount after deposit of " + deposit + " is " + DepositCash(deposit));
                            break;
                        case 4:
                            Console.WriteLine("Thanks for choosing ATM!!! \n See you soon!!!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Your PIN number is incorrect");
                }
            } while (choice != 4);
        }
        static void CheckBalance()
        {
            Console.WriteLine(amount);
        }
        static double WithdrawCash(double withdraw)
        {
            return amount - withdraw;
        }
        static double DepositCash(double deposit)
        {

            return amount + deposit;
        }
    }
}
