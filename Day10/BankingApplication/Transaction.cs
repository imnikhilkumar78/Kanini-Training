using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
   public  class Transaction
    {
        public int Id { get; set; }
        public Account FromAccount { get; set; }
        public Account ToAccount { get; set; }
        public DateTime transactionDate { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }

        public override string ToString()
        {
            string strAmount = "";
            if (Type == "Credit")
            {
                strAmount = "+" + Amount.ToString();
            }
            else
                strAmount = "-" + Amount.ToString();
            return "transaction Number : " + Id +
                "\n from Account details : " + FromAccount.ToString() +
                "\n To Account Details : " + ToAccount.ToString() +
                "\n Transaction date : " + transactionDate +
                "\n Transaction Amount : " + Amount+
                "\n Status : "+Status;
        }



    }
}
