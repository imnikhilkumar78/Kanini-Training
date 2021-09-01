using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uderstandingabstractapplication
{
    class Bird : IFlying, IAnimal
    {
        public string Name { get; set; }

        public Bird()
        {
            Console.WriteLine("You have created a bird");
        }

        public Bird(string name)
        {
            Name = name;
        }
        public void Eat()
        {
            Console.WriteLine(Name+" Bird you can Eat");


        }
        public void FLy()
        {
            Console.WriteLine("FLy Fly Fly.....");
        }

        public void Land()
        {
            Console.WriteLine("Let's make a landing");
        }

        public void TakeOFF()
        {
            Console.WriteLine("Flap Wing Fast");
            
        }

        public void Sleep()
        {
            Console.WriteLine("You can sleep now...");
        }
    }
}
