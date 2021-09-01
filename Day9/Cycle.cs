using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class Cycle
    {
        public int speed { get; set; }
        public virtual void  run()
        {
            Console.WriteLine($"Cycle runs in {speed} speed");
        }
    }

    public class MountainCycle : Cycle
    {
        public MountainCycle()
        {
            speed = 40;
            Console.WriteLine("Can climb mountains.");
        }
        public void mountainrun()
        {
            Console.WriteLine($"Mountain CycleCycle runs in {speed} speed");
        }
        public override void run()
        {
            Console.WriteLine($"Mountain Cycle runs in {speed} speed");
        }
    }

    public class Motorcycle : Cycle
    {
        public string brand { get; set; }
        public Motorcycle()
        {
          
        Console.WriteLine("has motor");
            speed = 60;

        }
        public void motorrun()
        {
            Console.WriteLine($"Motor Cycle runs in {speed} speed");
        }
        public override void run()
        {
            Console.WriteLine($"Motor Cycle runs in {speed} speed");
        }
    }
    public class supercycle : Motorcycle
    {
        public supercycle()
        {
            speed = 40;
            brand = "Yamaha";
        }
    }
}
