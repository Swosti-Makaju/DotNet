using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword_swosti_33
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor called.");
        }

        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    // Derived class
    class Dog : Animal
    {
        public Dog() : base()  // Calls base class constructor
        {
            Console.WriteLine("Dog constructor called.");
        }

        public void ShowBehavior()
        {
            base.Eat();  // Calls base class method
            Console.WriteLine("Dog is barking.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.ShowBehavior();
        }
    }
}
