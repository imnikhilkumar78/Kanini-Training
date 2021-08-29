using System;

namespace removeduplicates
{
    class Program
    {
        static int removeDuplicate(int[] input_arr, int n)
        {
            if (n==0 || n==1)
            {
                return n;
            }
            int[] temp = new int[n];

            int j = 0;

            for (int i = 0; i < n-1; i++)
            {
                if (input_arr[i]!=input_arr[i+1])
                {
                    temp[j++] = input_arr[i];
                }
            }
            temp[j++] = input_arr[n - 1];
            for (int i = 0; i < j; i++)
            {
                input_arr[i] = temp[i];
            }
            return j;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter number of elements you want to input");
            int num_elements = Convert.ToInt32(Console.ReadLine());
            int[] input_arr = new int[num_elements];
            Console.WriteLine("Enter The Elements");
            for (int i = 0; i < num_elements; i++)
            {
                input_arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int loop = removeDuplicate(input_arr, num_elements);
            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine(input_arr[i]+" ");
            }
        }
    }
}
