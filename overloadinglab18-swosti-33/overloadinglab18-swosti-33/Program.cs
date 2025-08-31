using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadinglab18_swosti_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(20, 5);
            Rectangle rect2 = new Rectangle(20, 5);

            Console.WriteLine("Rectangle 1:");
            rect1.Display();

            Console.WriteLine("Rectangle 2:");
            rect2.Display();

            Rectangle result = rect1 + rect2; // Calls overloaded + operator

            Console.WriteLine("Result of Addition:");
            result.Display();
            // Check equality
            Console.WriteLine("Is Rectangle 1 equal to Rectangle 2?");
            Console.WriteLine(rect1 == rect2 ? "Yes" : "No");
            Console.ReadLine();
        }
    }
    class Rectangle
    {
        public int Width, Height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // Overload the + operator
        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            return new Rectangle(r1.Width + r2.Width, r1.Height + r2.Height);
        }
        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            return r1.Width == r2.Width && r1.Height == r2.Height;
        }
        // Overload != operator
        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return !(r1 == r2);
        }
        // Override Equals and GetHashCode (required when overloading == and !=)
        public override bool Equals(object obj)
        {
            if (obj is Rectangle)
            {
                Rectangle r = (Rectangle)obj;
                return this == r;
            }
            return false;

        }

        public override int GetHashCode()
        {
            return (Width, Height).GetHashCode();
        }

        public void Display()
        {
            Console.WriteLine($"Width: {Width}, Height: {Height}");
        }
    }

}
