using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndInheritance
{
    public abstract class Animals
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }


        public abstract void Pet();
        public virtual void Sounds()
        {
            Console.WriteLine($"{Name} has no sound");
        }
    }

    public class Dog : Animals
    {

        public override void Pet()
        {
            Console.WriteLine($"{Name} is a {Age} years old dog and and it's race is {Race}");
        }
        public override void Sounds()
        {
            Console.WriteLine($"{Name} barks.");
        }
    }

    public class Cat : Animals
    {

        public override void Pet()
        {
            Console.WriteLine($"{Name} is a {Age} years old cat and and it's race is {Race}");
        }
        public override void Sounds()
        {
            Console.WriteLine($"{Name} meows.");
        }
    }

    public class Bird : Animals
    {

        public override void Pet()
        {
            Console.WriteLine($"{Name} is a {Age} years old bird and it's race is {Race}");
        }
        public override void Sounds()
        {
            Console.WriteLine($"{Name} sings.");
        }
    }

    public class Fish : Animals
    {

        public override void Pet()
        {
            Console.WriteLine($"{Race} is a wild animal and can't be tamed");
        }
        public override void Sounds()
        {
            Console.WriteLine($"{Race} has no sound.");
        }
    }
}
