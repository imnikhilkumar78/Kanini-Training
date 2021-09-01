using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Account
    {
        //Default Constructor which does not have parameter
        public Account()
        {
            Console.WriteLine("Default Constructor");
        }
        public float Balance { get; set; }
        public bool IdProof { get; set; }
        public string name { get; set; }

        public Account(string Name)
        {
            Console.WriteLine(Name = name);
        }


        public void CreateAccount(float amount)
        {
            Balance = amount;
            IdProof = false;
            Console.WriteLine(amount+" "+IdProof);
        }

        public void CreateAccount(float amount, bool IdProof)
        {
            Balance = amount;
            Console.WriteLine("The ID proof is "+IdProof);
            IdProof = true;
        }

        public static Account operator +(Account a1, Account a2)
        {
            Account account = new Account();
            account.Balance = a1.Balance + a2.Balance;
            return account;
        }

    }
}
