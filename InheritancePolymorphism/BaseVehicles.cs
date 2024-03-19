using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PolymorphismAndInheritance;
public abstract class Vehicles
{
    public string type { get; set; }
    public string color { get; set; }


    public abstract void Travel();

    public virtual void Engine()
    {
        Console.WriteLine($"{type} is a vehicle with an engine.");
    }


    public class Bicycle : Vehicles
    {
        public override void Travel()
        {
            Console.WriteLine($"I have a {color} {type} and i love traveling with it.");
        }
        public override void Engine()
        {
            Console.WriteLine($"{type} is a vehicle without an engine.");
        }
    }


    public class Motocycles : Vehicles
    {
        public override void Travel()
        {
            Console.WriteLine($"I have a {color} {type} and i love traveling with it.");
        }

        public override void Engine()
        {
            Console.WriteLine($"{type} is a vehicle with an engine.");
        }

    }

    public class Cars : Vehicles
    {
        public override void Travel()
        {
            Console.WriteLine($"I have a {color} {type} and i love traveling with it.");
        }

        public override void Engine()
        {
            Console.WriteLine($"{type} is a vehicle with an engine.");
        }
    }
}