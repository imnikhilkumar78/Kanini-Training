using System;
using System.IO;
using System.Collections.Generic;

namespace UnderstandingExceptionHandling
{
    class Program
    {
        int check()
        {
            int num1 = 100;
            int num2 = 10;
            try
            {
                int result = num1 / num2;
                Console.WriteLine(result);
                return result;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Have a nice day");
                
            }
            Console.WriteLine("All Done");
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Array IndexOutOfBound Exception
            /* Console.WriteLine("Enter size of array");
             int sizeofArray = Convert.ToInt32(Console.ReadLine());
             int[] array = new int[sizeofArray];
             Console.WriteLine("Enter the elements");
             for (int i = 0; i < sizeofArray; i++)
             {
                 array[i] = Convert.ToInt32(Console.ReadLine());
             }*/
            // Console.WriteLine("Printing Arrays");
            //for (int i = 0; i < sizeofArray+1; i++)
            //{
            //  Console.WriteLine(array[i]);
            //}

            //Format Exception
            //String number = "33.5";
            //int number1 = int.Parse(number);
            //Console.WriteLine(number1);

            //FileNotFound IOException
            /* using (StreamReader filereader = new StreamReader("nofile.txt"))
             {
                 filereader.ReadToEnd();

             }
            */


            //Overflow Exception
            /* int value = 780000000;
             int square = value * value;
             Console.WriteLine("Square is "+square);
            */

            //Divide by zero
            /* int val1 = 5;
            int val2 = 0;
            int val3 = val1 / val2;
            Console.WriteLine(val3);
            */

            /*int value = Int32.Parse(args[0]);
            List<String> names;
            if (value > 0)
                names = new List<String>();

            names.Add("Major Major Major");*/

            Company comp = new Company();
            //comp.AddEmployee();
            //comp.PrintEmployee();

            Program prg = new Program();
            prg.check();
            Console.ReadKey();
        }




    }
    }
