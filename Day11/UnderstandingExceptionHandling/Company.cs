using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingExceptionHandling
{
   public class Company
    {
        Employee[] employees;
        public Company()
        {
            employees = new Employee[5];
        }
        public void AddEmployee()
        {
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    
                    employees[i] = new Employee();
                    try
                    {
                        Console.WriteLine("Please Enter the employee ID");
                        employees[i].Id = Convert.ToInt32(Console.ReadLine());


                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("your Entry for ID is not right");
                    }
                    Console.WriteLine("Enter Employee name");
                    employees[i].name = Console.ReadLine();
                  
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Dont try out of bound, See and do!!!!!");
            }
        }
        public void PrintEmployee()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }


    }
}
