using System;
using System.Collections.Generic;

namespace findingsubarray
{
    class Program
    {
    
        static bool SubArrayExists(int[] arr)
        {
           
            HashSet<int> hs = new HashSet<int>();
           
            int sum = 0;

           
            for (int i = 0; i < arr.Length; i++)
            {
                
                sum += arr[i];

                
                if (arr[i] == 0
                    || sum == 0
                    || hs.Contains(sum))
                    return true;

               
                hs.Add(sum);
            }

           
            return false;
        }

      
        public static void Main()
        {
            int[] arr = new int[7];
            Console.WriteLine("Please Enter array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (SubArrayExists(arr))
                Console.WriteLine("Found a subarray with 0 sum");
            else
                Console.WriteLine("No Such Sub Array Exists!");
        }
    }
}

