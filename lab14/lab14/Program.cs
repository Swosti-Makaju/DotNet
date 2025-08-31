using System;

class RowSum2DArray
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        // Input matrix elements
        Console.WriteLine("\nEnter matrix elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Display matrix and row sums
        Console.WriteLine("\nMatrix and Row Sums:");
        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            Console.Write("Row " + (i + 1) + ": ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
                rowSum += matrix[i, j];
            }
            Console.WriteLine("=> Sum = " + rowSum);
        }
    }
}
