using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_operator_swosti_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation a = new Calculation(10);
            Calculation b = new Calculation(5);

            Calculation sum = a + b;
            Console.WriteLine("a + b = " + sum.Display());  // Output: 15

            Calculation diff = a - b;
            Console.WriteLine("a - b = " + diff.Display());  // Output: 5

            Calculation product = a * b;
            Console.WriteLine("a * b = " + product.Display());  // Output: 50

            Calculation quotient = a / b;
            Console.WriteLine("a / b = " + quotient.Display());  // Output: 2
            Calculation reminder = a % 2;
            Console.WriteLine("a % 2 = " + reminder.Display());  // Output: 0

            Console.ReadLine();

        }
    }
    public class Calculation
    {
        int x;
        public Calculation(int x)
        {
            this.x = x;
        }
        // Binary + operator
        public static Calculation operator +(Calculation a, Calculation b)
        {
            return new Calculation(a.x + b.x);
        }

        // Binary - operator
        public static Calculation operator -(Calculation a, Calculation b)
        {
            return new Calculation(a.x - b.x);
        }

        // Binary * operator
        public static Calculation operator *(Calculation a, Calculation b)
        {
            return new Calculation(a.x * b.x);
        }

        // Binary / operator
        public static Calculation operator /(Calculation a, Calculation b)
        {
            return new Calculation(a.x / b.x);
        }
        public static Calculation operator %(Calculation a, int scalar)
        {
            return new Calculation(a.x % scalar);
        }

        public int Display()
        {
            return x;
        }

    }

}
