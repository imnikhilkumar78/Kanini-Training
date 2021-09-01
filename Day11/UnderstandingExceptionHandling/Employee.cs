using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingExceptionHandling
{
    class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name)
        {
            Id = id;
            this.name = name;
        }
    }
}
