using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Bank
    {
        Account[] accounts;
        Transaction[] transactions;

        int MAX_SIZE = 5;
        int count, transactionCount;
        public Bank()
        {
            accounts = new Account[5];
            transactions = new Transaction[5];
            count = 0;
            transactionCount = 0;
        }
        public void AddAccounts()
            
        {
            string typechoice;
            do
            {
                Console.WriteLine("Do you want to open savings or current account");
                Console.WriteLine("Key in s for savings and c for current");
                Console.WriteLine("Please enter e to stop");
                typechoice = Console.ReadLine().ToLower();
                switch (typechoice)
                {
                    case "s":
                        accounts[count] = new SavingsAccount();
                        break;
                    case "c":
                        accounts[count] = new CurrentAccount();
                        break;
                    case "e":
                        Console.WriteLine("We are done creating accounts");
                        break;
                    default:
                        Console.WriteLine("Invalid, Try Again");                       
                        break;


                }
                if (accounts[count] != null)
                {
                    accounts[count].GetAccountDetailsFromUser();
                    count++;

                }
                else
                    continue;

            } while (count < MAX_SIZE && typechoice !="e");
        }
        public void PrintAllAccountDetails()
        {
            for (int i = 0; i < count; i++)
            {
                PrintAccount1(i);

            }
        }

        public void PrintAccountByNumber()
        {
            string userAccountNumber = GetAccountNumberFromUser();
            Account account = GetAccountUsingNumber(userAccountNumber);
            if(account==null)
            {
                Console.WriteLine("Invalid Account Number");
            }
            PrintAccount(account);


        }

        Account GetAccountUsingNumber(string accountNumber)
        {
            Account account = null;
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].AccountNumber == accountNumber)
                {
                    account = accounts[i];
                }

            }
            return account;
        }

        string GetAccountNumberFromUser()
        {
            Console.WriteLine("Please Enter the account Number");
            string accNumber = Console.ReadLine();
            if(accNumber == "" || accNumber == null)
            {
                Console.WriteLine("You have not entered anything, try again");
                GetAccountNumberFromUser();
            }
            return accNumber;
        }

        void PrintAccount(Account account)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine(account);
            Console.WriteLine("------------------");

        }

        void PrintAccount1(int idx)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine(accounts[idx]);
            Console.WriteLine("------------------");

        }
        public void Transact()
        {
            Transaction transaction = new Transaction();
            Console.WriteLine("Please Enter the from Account Number");
            string fromAccount = GetAccountNumberFromUser();
            transaction.FromAccount = GetAccountUsingNumber(fromAccount);
            if(transaction.FromAccount == null)
            {
                Console.WriteLine("Invalid from Account");
                return;
            }
            string toAccount = GetAccountNumberFromUser();
            transaction.ToAccount = GetAccountUsingNumber(toAccount);
            if (transaction.FromAccount == null)
            {
                Console.WriteLine("Invalid from Account");
                return;
            }
            transaction.transactionDate = DateTime.Today;
            Console.WriteLine("Please enter if it is credit or debit");
            string type = Console.ReadLine().ToLower();
            if (type=="credit")
            {
                transaction.Type = type;
                Console.WriteLine("Please enter transaction amount");
                double amount = Convert.ToDouble(Console.ReadLine());
                transaction.Amount = amount;
                if(transaction.FromAccount.CheckBalanceStatus(amount))
                    {
                    transaction.ToAccount.Balance += amount;
                    Console.WriteLine("Printing Updated Balance of From Account");
                    PrintAccount(transaction.FromAccount);
                    transaction.Status = "Success";
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                    transaction.Status = "Failed";
                }
                Console.WriteLine("The transaction details");
                Console.WriteLine(transaction);

            }
            transaction.Id = transactionCount + 1;
            transactions[transactionCount] = transaction;
            transactionCount++;
        }
        public void PrintAllTransaction()
        {
            for (int i = 0; i < transactionCount; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(transactions[i]);
                Console.WriteLine("------------------------");
            }
        }

    }
}
