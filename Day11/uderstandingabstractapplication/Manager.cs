using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uderstandingabstractapplication
{
    class Manager : ICustomerManager, IEmployeeManager
    {
        public string Name { get; set; }
        public Manager()
        {
            Console.WriteLine("I am Manager");
           

        }

        public Manager(string name)
        {
            Name = name;
            Console.WriteLine("My name is "+Name);
        }


        public void ApproveLoan()
        {
            Console.WriteLine("I am approving Loan");
        }

        public void CheckWork()
        {
            Console.WriteLine("Scheduling Audit");
        }

        public void ConductMeeting()
        {
            Console.WriteLine("Starting Meeting");
            Console.WriteLine("Meeting Summary");
        }

        public void SolveIssues()
        {
            Console.WriteLine("Raising issues");
            Console.WriteLine("Solving Issue");
            Console.WriteLine("issue resolved");
        }
    }
}
