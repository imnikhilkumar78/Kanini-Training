using System;

namespace validatingcard
{
    class Program
    {
        void check_credit_card()
        {
            Console.WriteLine("Please Enter your 16 digit Credit card Number");
            int[] card_arr = new int[16];
            for (int i = 0; i < 16; i++)
            {
                card_arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Original Array");
            for (int i = 0; i < card_arr.Length; i++)
            {
                Console.WriteLine(card_arr[i]);
            }
            int[] rev_arr = new int[16];
            rev_arr = card_arr;
            Array.Reverse(rev_arr);

            Console.WriteLine("Reverse Array");
            for (int i = 0; i < rev_arr.Length; i++)
            {
                Console.WriteLine(rev_arr[i]);
            }

            for (int i = 0; i < rev_arr.Length+1; i++)
            {
                if ((i+1) % 2 == 0)
                {
                    rev_arr[i] = rev_arr[i] * 2;
                    if (rev_arr[i] < 9)
                    {
                        rev_arr[i] = rev_arr[i];
                        
                    }
                    else
                    {
                        rev_arr[i] = (rev_arr[i] / 10) + (rev_arr[i] % 10);
                        
                    }
                }

            }
            Console.WriteLine("Reversed Array after calculation");
            for (int i = 0; i < rev_arr.Length; i++)
            {
                Console.WriteLine(rev_arr[i]);
            }
            int sum=0;
            Console.WriteLine("Calculating Sum");
            for (int i = 0; i < rev_arr.Length; i++)
            {
                sum = sum + rev_arr[i];
            }
            Console.WriteLine( "The Sum is "+sum);

            if(sum%10==0)
            {
                Console.WriteLine("Valid Credit Card");
            }
            else
            {
                Console.WriteLine("Invalid Credit Card");
            }
        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program prg = new Program();
            prg.check_credit_card();
        }
    }
}
