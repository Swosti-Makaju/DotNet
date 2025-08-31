using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration_swosti_33
{
    enum Department
    {
        ComputerScience,
        Electronics,
        Civil,
        Mechanical,
        Management
    }

    // Enumeration for College
    enum College
    {
        Engineering,
        Business,
        Arts,
        Science,
        Law
    }

    class Program
    {
        // Function to display values of Department enum
        static void DisplayDepartments()
        {
            Console.WriteLine("Departments:");
            foreach (string dept in Enum.GetNames(typeof(Department)))
            {
                Console.WriteLine($"- {dept}");
            }
        }

        // Function to display values of College enum
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
            // Display both enums
            DisplayDepartments();
            Console.WriteLine(); // for spacing
            DisplayColleges();

        }
    }
}
