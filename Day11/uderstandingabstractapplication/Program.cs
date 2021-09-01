using System;

namespace uderstandingabstractapplication
{
    class Program
    {
        void EmployeeManage(IEmployeeManager empmanager)
        {
            empmanager.ConductMeeting();
            empmanager.CheckWork();
        }
        void CustomerManage(ICustomerManager custManager)
        {
            custManager.ApproveLoan();
            custManager.SolveIssues();
        }
        void VisitingForest(IAnimal animal)
        {
            animal.Sleep();
            animal.Eat();
        }
        void SkyShow(IFlying flying)
        {
            flying.TakeOFF();
            flying.FLy();
            flying.Land();
        }
        static void Main(string[] args)
        {
            Bird bird = new Bird("Parrot");
            Program prg = new Program();
            bird.Eat();
            prg.VisitingForest(bird);
            prg.SkyShow(bird);

            Console.WriteLine("Hello World!");


            Console.WriteLine("--------------------");
            Manager manager = new Manager("Albus Dumbledore");
            prg.CustomerManage(manager);
            prg.EmployeeManage(manager);
            Console.WriteLine("----------------------------");

            GreatDane gd = new GreatDane();
            gd.Look();

            Console.ReadKey();
        }
    }
}
