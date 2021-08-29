using System;
using System.Linq;

namespace questions
{
    class Program
    {

        void numbersdiv7()
        {
            int sum = 0;
            int avg = 0;
            Console.WriteLine("Input 10 elements");
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] div7arr = new int[10];
            for (int j = 0; j < arr.Length; j++)
            {
                
                if (arr[j] % 7 == 0)
                   div7arr= div7arr.Append(arr[j]).ToArray();
            }

            for (int k = 0; k < div7arr.Length; k++)
            {
               
                sum += div7arr[k];
              
            }
            int len = div7arr.Length;
            Console.WriteLine("len "+len);
                
            avg = sum / len;
            Console.WriteLine("The Sum is "+sum);
            Console.WriteLine("The avg is "+avg);
            
        }
        void prime()
        {
            Console.WriteLine( "Enter a number you want to check");
            int a = Convert.ToInt32(Console.ReadLine());
            int prime=0;
            if(a < 1)
                Console.WriteLine("Invalid");
            else
            {
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        prime++;
                        break;
                    }

                   
                }
                if(prime==0)
                    Console.WriteLine("Its a prime");
                
                else
                    Console.WriteLine("Not a prime");

            }
        }
        void checknumber()
        {
            int number = 0;
            while (number >= 0)
            {
                Console.WriteLine("Enter a number");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                    Console.WriteLine("You entered 0");
                else if (number < 0)
                    Console.WriteLine("You Entered Negative Number..yay!!!");
                else if (number % 2 == 0)
                    Console.WriteLine("Its an even number");
                else
                    Console.WriteLine("Its a odd number ");
            }
        }

            void primearray()
            {
            
                Console.WriteLine("Please Enter 10 numbers");
                int[] arr = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    arr[i]=Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 2; j < arr[i]; j++)
                    {
                    if (arr[i] % j == 0)
                        break;
                    else
                    {
                        
                        Console.WriteLine("Prime Numbers"+arr[i]);
                        break;
                    }      
                           
                    }
                
            }

            }

        void norepeat()
        {
            Console.WriteLine("Enter 11 numbers Please");
            int[] arr = new int[11];
            for (int i = 0; i < 11; i++)
            {
               arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < arr.Length; j++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if(j!=k && arr[j]==arr[k])
                    {
                        
                        break;

                    }
                   
                }
                if(j==arr.Length)
                {
                    Console.WriteLine("Same Number " + arr[j]);
                }
            }
        }
        


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program prg = new Program();
            //prg.numbersdiv7();
            //prg.prime();
            //prg.checknumber();
            //prg.primearray();
            prg.norepeat();
        }
    }
}
