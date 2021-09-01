using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uderstandingabstractapplication
{
    public abstract class Dog
    {
        public void Eat()
        {
            Console.WriteLine("Dogs start Eating");
        }
        public void Sleep()
        {
            Console.WriteLine("Dogs then sleep");
        }
        public abstract void Look();
    }
}
