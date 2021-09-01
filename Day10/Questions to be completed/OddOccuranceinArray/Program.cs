using System;

namespace OddOccuranceinArray
{
    class Program
    {
        void OddOccurance(int[] array)
        {
            Console.WriteLine("Printing the array with index");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("["+i+"] : "+array[i]);
            }
            int result=0;
            for (int i = 0; i < array.Length; i++)
            {
                //a xor a gives 0
                result = result ^ array[i];
            }
            Console.WriteLine("Odd Occurance is "+result);
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
            prg.OddOccurance(array);
            Console.ReadKey();
        }
    }
}
