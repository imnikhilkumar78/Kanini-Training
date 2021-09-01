using System;

namespace TapeEquilibrium
{
    class Program
    {
        int Solution(int[] array)
        {
            int size = array.Length;
            int sumMin = (int)array[0];
            int sumMax = 0;
            for (int i = 0; i < size; i++)
            {
                sumMax += (int)array[i];
            }
            int MinDiff = (int)Math.Abs(sumMax - sumMin);
            for (int i = 0; i < size; i++)
            {
                int Diff = (int)Math.Abs(sumMax - sumMin);
                if (Diff < MinDiff)
                    MinDiff = Diff;
                sumMin += array[i];
                sumMax -= array[i];
            
            }
            
            return MinDiff;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter The size of array");
            int sizeofArray = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[sizeofArray];
            Console.WriteLine("Enter the array");
            for (int i = 0; i < sizeofArray; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Program prg = new Program();
            int minimalDiff = prg.Solution(array);
            Console.WriteLine("Minimal Difference that can be achieved is "+minimalDiff);
        }
    }
}
