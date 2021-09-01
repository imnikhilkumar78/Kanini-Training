using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int age { get; set; }

        public virtual void look()
        {
            Console.WriteLine($"Looking in Dog {Name}, of {Breed} aged {age}");

        }

    }
    public class Pug : Dog
    {
        public Pug()
        {
            Breed = "Pug";
            age = 10;
        }
        public override void look()
        {
            Console.WriteLine($"Looking in Dog {Name}, of {Breed} aged {age}");

        }

    }
    public class GreatDane : Dog
    {
        public GreatDane()
        {
            Breed = "Great Dane";
            age = 7;
        }
        public override void look()
        {
            Console.WriteLine($"Looking in Dog {Name}, of {Breed} aged {age}");

        }

    }

}
