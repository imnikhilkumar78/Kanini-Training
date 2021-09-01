using System;

namespace arrayofaccount
{
    class Program
    {

        static void Main(string[] args)
        {
            account act = new account();
            account savings = new savings(101, "Nikhil", 4000, 8888);
           
            act.Transact();
            savings.Transact();


            Console.WriteLine("Hello World!");
        }
    }
}
