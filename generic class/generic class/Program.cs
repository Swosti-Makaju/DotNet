using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_class
{
    using System;

    class GenericClass<T>
    {
        private T value;   // generic member variable

        // generic constructor
        public GenericClass(T val)
        {
            value = val;
        }

        // generic property
        public T Data
        {
            get { return value; }
            set { this.value = value; }
        }

        // generic method
        public void Show<U>(U msg)
        {
            Console.WriteLine($"Value: {value}, Message: {msg}");
        }
    }

    class Program
    {
        static void Main()
        {
            GenericClass<int> obj1 = new GenericClass<int>(100);
            obj1.Show("Integer Example");

            GenericClass<string> obj2 = new GenericClass<string>("Hello World ");
            obj2.Show(2025);
        }
    }

}

