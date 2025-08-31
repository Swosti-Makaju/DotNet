using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab20_swosti_33
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNumber num1 = new MyNumber(5);
            MyNumber num2 = new MyNumber(5);
            // Using the overloaded ++ operator
            Console.WriteLine("Before increment: " + num1.Value);
            ++num1;
            Console.WriteLine("After increment: " + num1.Value);
            // Using the overloaded == operator
            if (num1 == num2)
                Console.WriteLine("num1 is equal to num2");
            else
                Console.WriteLine("num1 is not equal to num2");
            Console.ReadLine();

        }
    }
    class MyNumber
    {
        public int Value;
        // Constructor
        public MyNumber(int value)
        {
            Value = value;
        }
        // Overloading the ++ operator (prefix version)
        public static MyNumber operator ++(MyNumber num)
        {
            num.Value++;
            return num;
        }
        // Overloading the == operator
        public static bool operator ==(MyNumber num1, MyNumber num2)
        {
            return num1.Value == num2.Value;
        }

        // Overloading the != operator (must be overloaded when == is overloaded)
        public static bool operator !=(MyNumber num1, MyNumber num2)
        {
            return !(num1 == num2);
        }
        // Overriding Equals and GetHashCode methods
        public override bool Equals(object obj)
        {
            MyNumber num = (MyNumber)obj;
            return Value == num.Value;
        }
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }

}
