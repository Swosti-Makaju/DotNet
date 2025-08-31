using System;

namespace ConsoleApp101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rows: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter columns: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] first = new int[m, n];
            int[,] second = new int[m, n];
            int[,] resultant = new int[m, n];

            Console.WriteLine("Enter elements of First Matrix:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"First[{i},{j}]: ");
                    first[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements of Second Matrix:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Second[{i},{j}]: ");
                    second[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Performing Matrix addition
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resultant[i, j] = first[i, j] + second[i, j];
                }
            }

            Console.WriteLine("Resultant Matrix:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(resultant[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

