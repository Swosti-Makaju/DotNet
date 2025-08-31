using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleinheritence_using_interface_swosti_33
{
    interface IPrintable
    {
        void Print();
    }

    // Second interface
    interface IScannable
    {
        void Scan();
    }

    // Class implementing both interfaces
    class MultiFunctionPrinter : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MultiFunctionPrinter mfp = new MultiFunctionPrinter();

            Console.WriteLine("Demonstrating Multiple Inheritance using Interfaces:\n");
            mfp.Print();
            mfp.Scan();

        }
    }
}