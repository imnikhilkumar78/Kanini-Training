﻿using System;

namespace findnumofevennum
{
    class Program
    {
        public int calcevennumber(int[] number)
        {
            int count=0;
            

            for (int i = 0; i < number.Length; i++)
            {
                if(iseven(number[i]))
                {
                    count++;
                }
            }
            return count;
            
        }
        bool iseven(int num)
        {
            int count = 0;
            while (num != 0)
            {
                count++;
                num = num / 10;
            }
            return count % 2 == 0;
        }
        static void Main(string[] args)
        {
            
            int[] number = new int[5];
            Console.WriteLine("Please enter 5 values");
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            int numberofdigits;
            Program prg = new Program();
            numberofdigits = prg.calcevennumber(number);
            Console.WriteLine("The numbers with even number of digits are "+numberofdigits);


        }
    }
}
