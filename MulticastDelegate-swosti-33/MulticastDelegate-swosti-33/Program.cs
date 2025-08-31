using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate_swosti_33
{
    public delegate void MathOperation(int x, int y);

    class Program
    {
        // Method to add two numbers
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition: {0} + {1} = {2}", a, b, a + b);
        }

        // Method to subtract two numbers
        public static void Subtract(int a, int b)
        {
            Console.WriteLine("Subtraction: {0} - {1} = {2}", a, b, a - b);
        }

        static void Main(string[] args)
        {
            // Create delegate instance and assign methods
            MathOperation operation = Add;        // Add first
            operation += Subtract;               // Then subtract

            // Call the multicast delegate
            Console.WriteLine("Enter two numbers:");

            Console.Write("First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPerforming operations using multicast delegate:\n");
            operation(num1, num2);  // Calls both Add and Subtract
        }
    }
}
