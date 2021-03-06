using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter the input");

        int n = Int32.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();
        Stack<int> max = new Stack<int>();
        
        for (int i = 0; i < n; i++)
        {
           
            string[] cmd = Console.ReadLine().Split(' ');
            if (cmd[0].Equals("1"))
            {
                int val = Int32.Parse(cmd[1]);
                stack.Push(val);

                if (max.Count == 0 || val >= max.Peek())
                {
                    max.Push(val);
                }
            }
            else if (cmd[0].Equals("2"))
            {
                int val = stack.Pop();
                if (max.Peek() == val)
                {
                    max.Pop();
                }
            }
            else if (cmd[0].Equals("3"))
            {
                Console.WriteLine(max.Peek());
            }
        }
    }
}