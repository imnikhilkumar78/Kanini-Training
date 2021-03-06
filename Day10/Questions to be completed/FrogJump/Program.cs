using System;

namespace FrogJump
{
    class Program
    {
        int FrogJumpSolution(int Start, int End, int Distance)
        {
            int Route = Start;
            int count = 0;
            while(Route < End)
            {
                Route += Distance;
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter The starting point of Frog");
            int Start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Destination/End point of Frog");
            int Destination = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fixed distance it can Jump");
            int fixedDistance = Convert.ToInt32(Console.ReadLine());
            Program prg = new Program();
            int result = prg.FrogJumpSolution(Start, Destination, fixedDistance);
            Console.WriteLine("The minimum number of Jumps required are "+result);

            Console.ReadKey();
        }
    }
}
