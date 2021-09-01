using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApplication
{
    class insurance
    {
        public string Name { get; set; }
        public double Premium { get; set; }
        public string Type { get; set; }
        public int tenure { get; set; }
        

        public insurance()
        {
            Premium = 5000;
            Type = "Not Set yet";

        }

        public insurance(string name, double premium, string type, int tenure)
        {
            Name = name;
            Premium = premium;
            Type = type;
            this.tenure = tenure;
        }

        public virtual bool CalcPremium(string ttype, double Premium )
        {
            bool result = false;
            return result;
        }

        public void TakeInputFromUser()
        {
            Console.WriteLine("Please Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please Enter Prev Premium Else Enter 0");
            Premium = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Insurance Type");
            Type = Console.ReadLine();
            Console.WriteLine("Please Enter Premium");
            Premium = int.Parse(Console.ReadLine());
        }
    }
}