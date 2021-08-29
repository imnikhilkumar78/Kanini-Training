using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApplication
{
    class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string strength { get; set; }


        void AddEmployee()
        {
            Console.WriteLine("Enter Employee ID");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Strength");
            strength = Console.ReadLine();
            Console.WriteLine("You have Entered this Data");
            Console.WriteLine("Employee ID "+ID);
            Console.WriteLine("Employee Name "+Name);
            Console.WriteLine("Employee Strength "+strength);

        }


        void reliveEmployee()
        {
            Console.WriteLine("Enter ID of Employee to be relieved");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x==ID)
            {
                Console.WriteLine("Employee has been relieved");
            }
            else
            {
                Console.WriteLine("Employee Does not exist");
            }

        }

        static void Main(string[] args)
        {
            Department dep = new Department();
            Console.WriteLine("Company Application");
            int n;
            Console.WriteLine("Please Enter choice of Operation");
            
            int b=1;
            while (b!= 0)
            {
                Console.WriteLine("Enter 1 for Adding Employee and 2 from Releiving Employee");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    dep.AddEmployee();
                }
                else if (n == 2)
                {
                    dep.reliveEmployee();
                }
                else
                {
                    Console.WriteLine("Incorrect Option, Begin the program again");
                }
                Console.WriteLine("Enter 0 to exit and 1  to perform another operation");
                b = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
