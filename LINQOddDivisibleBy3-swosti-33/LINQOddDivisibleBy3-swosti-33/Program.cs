using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOddDivisibleBy3_swosti_33
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of numbers from 1 to 30
            List<int> numbers = Enumerable.Range(1, 30).ToList();

            // LINQ query to select numbers that are odd and divisible by 3
            var result = from num in numbers
                         where num % 2 != 0 && num % 3 == 0
                         select num;

            // Display the result
            Console.WriteLine("Odd numbers divisible by 3 from 1 to 30:");
            foreach (var number in result)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine(); // Optional newline
        }
    }
}
