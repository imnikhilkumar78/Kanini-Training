﻿using System;

namespace notrepeatingnumber
{
    class Program
    {
        void NonRepeating()
        {
            bool flag = false;
            Console.WriteLine("Enter 11 numbers separate by ',' :");
            string[] line = new string[11];
            line = Console.ReadLine().Split(",");
            int[] arr = new int[11];
            for (int i = 0; i < 11; i++)
            {
                arr[i] = Convert.ToInt32(line[i]);
            }
            for (int i = 0; i < 11; i++)
            {
                flag = false;
                for (int j = 0; j < 11; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine($"Number which not repeat is: {arr[i]}");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program prg = new Program();
            prg.NonRepeating();

        }
    }
}
