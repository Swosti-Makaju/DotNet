using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass_swosti_33
{
    class MyGenericClass<T>
    {
        // Generic member variable
        private T _value;

        // Generic constructor
        public MyGenericClass(T value)
        {
            _value = value;
        }

        // Generic property
        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }

        // Generic method
        public void Display<U>(U additionalValue)
        {
            Console.WriteLine($"Main value: {_value}");
            Console.WriteLine($"Additional value: {additionalValue}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instance with int
            MyGenericClass<int> intObj = new MyGenericClass<int>(100);
            intObj.Display<string>("Test");

            Console.WriteLine();

            // Create instance with string
            MyGenericClass<string> stringObj = new MyGenericClass<string>("Hello");
            stringObj.Display<double>(3.14);
        }
    }
}