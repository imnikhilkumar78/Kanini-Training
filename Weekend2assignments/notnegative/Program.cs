using System;
using System.Linq;

namespace notnegative
{
    class Program
    {
        void nonnegative()
        {
            int max = 200;
            int[] user_input = new int[max];
            int[] temp = new int[max];
            Console.WriteLine( "Please Enter a number");
            for (int i = 0; i < max; i++)
            {
                temp[i] = int.Parse(Console.ReadLine());
                if(temp[i]>0)
                {
                    user_input = user_input.Append(temp[i]).ToArray();
                    
                }
                else
                {
                    break;
                }
                
            }
            Console.WriteLine("user entered data");
            for (int i = 0; i < user_input.Length; i++)
            {
                Console.WriteLine(user_input[i]);
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program prg = new Program();
            prg.nonnegative()
        }
    }
}
