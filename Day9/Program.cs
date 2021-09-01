using System;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
           supercycle stc = new supercycle();
            Console.WriteLine("Speed is "+stc.speed);
            Console.WriteLine("Brand is "+stc.brand);

            Cycle cyc = new Motorcycle();
            Console.WriteLine( "Speed of Cycle is "+cyc.speed);
            cyc.run();

            cyc = new MountainCycle();
            Console.WriteLine("Speed is "+cyc.speed);
            cyc.run();
            

            if(cyc.GetType().ToString() == "Day9.Motorcycle")
            {
                Console.WriteLine("Yes");
                ((Motorcycle)cyc).motorrun();
            }

            Account acc = new Account();
            acc.CreateAccount(1100);
            Account Jack = new Account();
            Account Jill = new Account("Jill");
            Console.WriteLine("The account is opened by "+Jill.name);

            Console.WriteLine("---------------------------------");

            Account acc1 = new Account();
            acc1.CreateAccount(1000.2f);
            Account acc2 = new Account();
            acc2.CreateAccount(2000.2f);
            Account acc3 = acc1 + acc2;
            Console.WriteLine("Total is "+acc3);

            Console.WriteLine("-------------------------------------");

            Dog dog = new Dog();
            dog.look();
            Dog dog1 = new Pug();
            dog1.look();
            Dog dog2 = new GreatDane();
            dog2.look();

            Console.WriteLine("--------------------------------------------------------------");













            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
