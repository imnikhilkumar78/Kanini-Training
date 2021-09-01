using System;

namespace CyclicRotationToRight
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the SizeOfArray");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[sizeOfArray];
            
            Console.WriteLine("Enter the array ");
            for (int i = 0; i < sizeOfArray; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the number for times to be rotated");
            int timesRotate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------");
            Console.WriteLine("Original Array");
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("------------------");
            for (int i = 0; i < timesRotate; i++)
            {
                int j, last;
                last = array[sizeOfArray - 1];
                for (j = array.Length-1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = last;
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Rotated Array");
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("-----------------------");

            Console.ReadKey();

        }
    }
}
