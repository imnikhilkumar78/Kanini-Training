using System;

namespace binarygap
{
    class binarygap
    {
        public int solution(int number)
        {
            String bits = Convert.ToString(number, 2);
            Console.WriteLine("Printing bits string "+bits);
            int size=0;
            int sizeReal=0;
            int count = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '0')
                {
                    if (count > 0)
                        count = count + 1;
                    else
                        count = 1;
                }
                else
                    count = 0;
                if (count > size)
                    size = count;
                if (bits[i] == '1' && size > sizeReal)
                    sizeReal = size;
            }
            return sizeReal;
        }
    }
       
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            binarygap bg = new binarygap();
            string control = "";
            while (control != "e")
            {
                Console.WriteLine("Enter the integer you want to check");
                int number = Convert.ToInt32(Console.ReadLine());
                int longestbinarygap = bg.solution(number);
                Console.WriteLine("longest Binary Gap in entered integer is " + longestbinarygap);
                Console.WriteLine("Ënter e to exit, any other key to enter another integer");
                control = Console.ReadLine();
                
            }
            Console.ReadKey();
        }
    }
}
