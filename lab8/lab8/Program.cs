using System;

class MatrixAdditionJagged
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        // Declare three jagged arrays
        int[][] matrixA = new int[rows][];
        int[][] matrixB = new int[rows][];
        int[][] resultMatrix = new int[rows][];

        // Input matrix dimensions and elements
        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Enter number of columns for row {i + 1}: ");
            int cols = int.Parse(Console.ReadLine());

            matrixA[i] = new int[cols];
            matrixB[i] = new int[cols];
            resultMatrix[i] = new int[cols];

            Console.WriteLine($"Enter elements for Matrix A, Row {i + 1}:");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"A[{i}][{j}] = ");
                matrixA[i][j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Enter elements for Matrix B, Row {i + 1}:");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"B[{i}][{j}] = ");
                matrixB[i][j] = int.Parse(Console.ReadLine());

                // Add and store in result matrix
                resultMatrix[i][j] = matrixA[i][j] + matrixB[i][j];
            }
        }

        // Display all three matrices
        Console.WriteLine("\nMatrix A:");
        PrintMatrix(matrixA);

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nResult (A + B):");
        PrintMatrix(resultMatrix);
    }

    static void PrintMatrix(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            foreach (int val in matrix[i])
            {
                Console.Write(val + "\t");
            }
            Console.WriteLine();
        }
    }
}
