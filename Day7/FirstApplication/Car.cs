using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Car
    {
        public string Car_Name { get; set; }
        public string Model { get; set; }
        public int price { get; set; }

        public void printAbout()
        {
            Console.WriteLine("The Name of mobile is " + Car_Name);
            Console.WriteLine("Price Of the mobile is " + price);
        }
    }
}
