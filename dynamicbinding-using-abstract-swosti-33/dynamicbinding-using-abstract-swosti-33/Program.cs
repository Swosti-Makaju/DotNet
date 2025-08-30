using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicbinding_using_abstract_swosti_33
{
    abstract class Shape
    {
        // Abstract method - must be overridden in derived classes
        public abstract void Draw();
    }

    // Derived class 1
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }

    // Derived class 2
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Array of base class references
            Shape[] shapes = new Shape[2];
            shapes[0] = new Circle();
            shapes[1] = new Rectangle();

            Console.WriteLine("Demonstrating dynamic binding using abstract methods:\n");

            // Loop through shapes and call Draw method
            foreach (Shape shape in shapes)
            {
                shape.Draw();  // Calls the overridden method at runtime
            }

          
        }
    }
}
