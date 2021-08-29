using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Mobile
    {
        public int speed { get; set; }
        public float price { get; set; }
        public string name { get; set; }

        public void Call()
        {
            Console.WriteLine("Make Call");
        }
        public void printAbout()
        {
            Console.WriteLine("The Name of mobile is "+name);
            Console.WriteLine("Price Of the mobile is "+price);
        }
    }
}
