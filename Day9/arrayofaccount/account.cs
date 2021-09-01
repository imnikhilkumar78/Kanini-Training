using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayofaccount
{
    public class account
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public float Balance { get; set; }

        public string Type { get; set; }
        public int Phone { get; set; }

        public account()
        {
            Balance = 5000;
            Type = "Not set yet";

        }

        public account(int accountNumber, string name, float balance, string type, int phone)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = balance;
            Type = type;
            Phone = phone;
        }

        public virtual bool Transact(string toAccount, string transType, double amount)
        {
            bool result = false;
            return result;

        }

        public override string ToString()
        {
            return "Account Number : "+AccountNumber+"\n Name: "+Name+"\n Type : "+Type+"\n Phone : "+Phone;
        }
    }

    public class savings : account
    {
        public savings(int accnumber, string name,float balance, int phone)
        {
            Type = "Savings";

        }

        public savings(int accountNumber, string name, float balance, string type, int phone) : base(accountNumber, name, balance, type, phone)
        {
        }

        public override bool Transact(string toAccount, string transType, double amount)
        {
            bool result = false;
            return result;




        }

    }





    public class current : account
    {
        public current(int accnumber, string name, float balance, int phone)
        {
            Type = "Current";

        }

        public current(int accountNumber, string name, float balance, string type, int phone) : base(accountNumber, name, balance, type, phone)
        {
        }

        public override bool Transact(string toAccount, string transType, double amount)
        {
            bool result = false;
            return result;


        }

    }
}
    

