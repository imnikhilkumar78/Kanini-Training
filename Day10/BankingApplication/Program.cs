using System;

namespace BankingApplication
{
    class Program
    {
        Bank bank = new Bank();
        void PrintMenu()
        {
            int ichoice = 0;
            do
            {
                PrintMenuList();
                ichoice = Convert.ToInt32(Console.ReadLine());
                switch (ichoice)
                {
                    case 0:
                        Console.WriteLine("You have selected to Exit");
                        break;
                    case 1:
                        bank.AddAccounts();
                        break;
                    case 2:
                        bank.PrintAllAccountDetails();
                        break;
                    case 3:
                        bank.PrintAccountByNumber();
                        break;
                    case 4:
                        bank.Transact();
                        break;
                    case 5:
                        bank.PrintAllTransaction();
                        break;
                    default:
                        Console.WriteLine("Invalid Choices, Start again!!");
                        break;



                }

            } while (ichoice != 0); ;
        }
        void PrintMenuList()
        {
            Console.WriteLine("0 Exit");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Print all account's Details");
            Console.WriteLine("3. Print Details of an account ");
            Console.WriteLine("4. Do Transaction");
            Console.WriteLine("5. Print all Transaction");


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Program().PrintMenu();
            Console.ReadKey();
        }
    }
}
