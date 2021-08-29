﻿using System;

namespace primeinrange
{
    class Program
    {
        void print_prime_in_range()
        {
            int min = 0, max = 0;
            int flag;
            Console.WriteLine("Enter the minimum range");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum range");
            max = Convert.ToInt32(Console.ReadLine());
            for (int i = min; i <= max; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;
                for (int j = 2; j <= i/2; ++j)
                {
                    if(i%j==0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if(flag==1)
                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program prg = new Program();
            prg.print_prime_in_range();
        }
    }
}
