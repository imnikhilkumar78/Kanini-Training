﻿using System;

namespace PermMissingElement
{
    class Program
    {
        int FindMissingElemnt(int[] array, int SizeofArray)
        {
            int sum = 0;
            Console.WriteLine("You have Entered");
            for (int i = 0; i < SizeofArray; i++)
            {
                Console.WriteLine("["+i+"] "+array[i]);
                sum = sum + array[i];
            }
            //n*(n+1)/2-total sum
            int num = SizeofArray + 1;
            int permute=num*(num+1)/2;
            int missingNumber = permute - sum;
            return missingNumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the size of Array");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[sizeOfArray];
            Console.WriteLine("Enter the array");
            for (int i = 0; i < sizeOfArray; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Program prg = new Program();
            int missingelement = prg.FindMissingElemnt(array, sizeOfArray);
            Console.WriteLine("The missing element was "+missingelement);
        }
    }
}
