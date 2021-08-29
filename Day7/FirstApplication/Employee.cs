using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public DateTime DOB { get; set; }

        void GetEmployeeData()
        {
            Console.WriteLine("Enter Employee ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Employee DOB");
            DOB = Convert.ToDateTime(Console.ReadLine());
        }

        void PrintEmpDetails()
        {
            Console.WriteLine("Employee ID "+id);
            Console.WriteLine("Employee Name "+name);
            Console.WriteLine("Employee Salary "+salary);
            Console.WriteLine("Employee DOB "+DOB);
        }

        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.GetEmployeeData();
            emp1.PrintEmpDetails();
            Console.WriteLine("Employee Class");
            Console.ReadKey();
        }
    }
}
