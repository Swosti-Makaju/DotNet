using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21_swosti_33
{
    class Rectangle
    {
        protected double length;
        protected double breadth;

        public void SetDimensions(double l, double b)
        {
            length = l;
            breadth = b;
        }
    }

    // Derived class
    class AreaCalculator : Rectangle
    {
        public double CalculateArea()
        {
            return length * breadth;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator rect = new AreaCalculator();

            Console.Write("Enter length of rectangle: ");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter breadth of rectangle: ");
            double b = Convert.ToDouble(Console.ReadLine());

            rect.SetDimensions(l, b);
            double area = rect.CalculateArea();

            Console.WriteLine("Area of Rectangle = " + area);

            Console.ReadLine(); // Keep console window open
        }
    }
}