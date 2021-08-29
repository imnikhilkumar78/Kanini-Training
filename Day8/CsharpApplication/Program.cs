using System;

namespace CsharpApplication
{
    class Program
    {
        void UnderstandingIf()
        {
            Console.WriteLine("Please Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1>100)
            {
                Console.WriteLine("good");
                Console.WriteLine("Line 2");
            }
            else
            {
                Console.WriteLine("OK");
            }
                 
        
        }

        void UnderstandingSwitch()
        {
            Console.WriteLine("Please Enter a day");
            String choice = Console.ReadLine();
            switch(choice)
            {
                case "Monday":
                    Console.WriteLine("Week Start");
                    break;
                case "Tuesday":
                    Console.WriteLine("Day 2");
                    break;
                case "Wednesday":
                    Console.WriteLine("Mid Week");
                    break;
                case "Thursday":
                    Console.WriteLine("Almost WeekEnd");
                    break;
                case "Friday":
                    Console.WriteLine("Last Working Day");
                    break;
                case "Saturday":
                    Console.WriteLine("Weekend");
                    break;
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Invalid Day");
                    break;
            }
        }

        void UnderstandingForLoop()  
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("The count to 10 is using value of i "+i);
            }
               
    
        }

        void UnderstandingWhileLoop()
        {
            int num = 10;
            while (num<100)
            {
                Console.WriteLine("The number is "+num);
                Console.WriteLine("Change the number");
                num = Convert.ToInt32(Console.ReadLine());
            }
        }

        void UnderstandingDoWhile()
        {
            int num=0;
            do
            {
                Console.WriteLine("The number is " + num);
                Console.WriteLine("Change the number");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 100);

        }

        void UnderstandingCsharpFeatures()
        {

            int iNum1; //= int.MaxValue;
                       // checked
                       //{
                       //  Console.WriteLine(iNum1);
                       //iNum1++;
                       //Console.WriteLine(iNum1);
                       //}

            Console.WriteLine("Please Enter a number");
            //bool res = int.TryParse(Console.ReadLine(), out iNum1);
            //if(res==true)
            //{
            //Console.WriteLine("You have entered"+iNum1);
            //}
            //else
            //{
            //Console.WriteLine("Incorrect Enter again");
            //}
            //while (int.TryParse(Console.ReadLine(), out iNum1)==false)
            //{
            //Console.WriteLine("Invalid Entry, please Write Correct Number");
            //}
            // Console.WriteLine("You have entered "+iNum1);


            int? inum2 = null;
            iNum1 = inum2 ?? 10;
            Console.WriteLine($"The value is {iNum1}");

            
        }

        void LearningStringArray()
        {
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Please enter the {i+1} name");
                names[i] = Console.ReadLine();


            }
            for (int i = 0; i < names.Length-1; i++)
            {
                Console.WriteLine(names[i]+", ");
            }
            Console.WriteLine(names[names.Length-1]);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //new Program().UnderstandingIf();
            //new Program().UnderstandingSwitch();
            //new Program().UnderstandingForLoop();
            //new Program().UnderstandingWhileLoop();
            //new Program().UnderstandingDoWhile();
            //new Program().UnderstandingCsharpFeatures();
            new Program().LearningStringArray();
            Console.ReadKey();
        }
    }
}
