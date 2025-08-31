using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_swosti_33
{
    // Define enumeration for Departments
    enum Department
    {
        ComputerScience,
        Electronics,
        Civil,
        Mechanical,
        Architecture
    }

    // Define enumeration for Colleges
    enum College
    {
        Engineering,
        Medical,
        Business,
        Law,
        Arts
    }

    class Program
    {
        // Function to display Department enumeration
        static void DisplayDepartments()
        {
            Console.WriteLine("Departments:");
            foreach (string dept in Enum.GetNames(typeof(Department)))
            {
                Console.WriteLine($"- {dept}");
            }
        }

        // Function to display College enumeration
        static void DisplayColleges()
        {
            Console.WriteLine("Colleges:");
            foreach (string college in Enum.GetNames(typeof(College)))
            {
                Console.WriteLine($"- {college}");
            }
        }

        static void Main(string[] args)
        {
            // Call the display functions
            DisplayDepartments();
            Console.WriteLine(); // For spacing
            DisplayColleges();

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}