using System;

namespace FirstApplication
{
    class Program
    {
        void add()
        {
            int num1, num2;
            Console.WriteLine("Please Enter the numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            int div = num1 / num2;
            Console.WriteLine($"The sum of {num1},{num2} is {sum}");
            Console.WriteLine($"The sub of {num1},{num2} is {sub}");
            Console.WriteLine($"The mul of {num1},{num2} is {mul}");
            Console.WriteLine($"The div of {num1},{num2} is {div}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name = "Nikhil";
            Console.WriteLine("Hello "+name);
            int num1 = int.MaxValue;
            Console.WriteLine("The value of num1 "+num1);
            num1 = num1 + 1;
            
            Console.WriteLine("The value of num1 after adding 1 is "+num1);

            Mobile obj = new Mobile();
            obj.name = "Oppo";
            obj.price = 250;
            obj.speed = 10;

            obj.Call();
            obj.printAbout();

            Car obj1 = new Car();
            obj1.Car_Name = "Honda Amaze";
            obj1.price = 700000;
            obj1.printAbout();
            String phone;
            Console.WriteLine("Please Enter the phone number to make a call");
            phone = Console.ReadLine();
            Console.WriteLine("Making Call to "+phone);

            Program prg = new Program();
            prg.add();

            Console.ReadKey();
        }
    }
}
