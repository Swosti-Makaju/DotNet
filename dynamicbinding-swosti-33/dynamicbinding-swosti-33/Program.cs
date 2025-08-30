using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicbinding_swosti_33
{
    // Base class
    class Animal
    {
        // Virtual method
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    // Derived class 1
    class Dog : Animal
    {
        // Override the virtual method
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    // Derived class 2
    class Cat : Animal
    {
        // Override the virtual method
        public override void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Array of base class references
            Animal[] animals = new Animal[3];
            animals[0] = new Animal();
            animals[1] = new Dog();
            animals[2] = new Cat();

            Console.WriteLine("Demonstrating dynamic binding using virtual methods:\n");

            // Call Speak method using base class reference
            foreach (Animal animal in animals)
            {
                animal.Speak();  // Calls the overridden method depending on actual object
            }
        }
    }
}