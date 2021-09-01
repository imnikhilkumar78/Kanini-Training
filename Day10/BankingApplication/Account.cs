using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }

        public Account()
        {
            Balance = 5000;

        }

        public Account(string accountNumber, string name, string phone, double balance)
        {
            AccountNumber = accountNumber;
            Name = name;
            Phone = phone;
            Balance = balance;
        }

        public void GetAccountDetailsFromUser()
        {
            Console.WriteLine("Enter Account Number");
            AccountNumber = Console.ReadLine();
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Phone");
            Phone = Console.ReadLine();
            Console.WriteLine("Enter Account Type");
            AccountType = Console.ReadLine();
            Console.WriteLine("Enter Initial Balance");
            Balance = double.Parse(Console.ReadLine());

        }
        public override string ToString()
        {
            return "Account number : "+AccountNumber+
                "\n Account Type : "+AccountType+
                "\n Name : "+Name+
                "\n Current Balance : "+Balance+
                "\n Contact Numer : "+Phone;

        }
        public virtual bool CheckBalanceStatus(double amount)
        {
            bool result = false;
            return result;
        }
    }
}
