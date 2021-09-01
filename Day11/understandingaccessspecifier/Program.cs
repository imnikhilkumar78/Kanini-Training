using System;

namespace understandingaccessspecifier
{
    public class c1
    {
        private protected int num1;
    }
    public class c2 : c1
    {
        public c2()
        {
            num1 = 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
