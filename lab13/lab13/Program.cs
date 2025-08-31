using System;

class JaggedArrayWithRowSum
{
    static void Main()
    {
        // Initialize a jagged array with sample data
        int[][] jaggedArray = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 6, 7, 8, 9 }
        };

        Console.WriteLine("Jagged Array Elements and Row Sums:\n");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            int rowSum = 0;
            Console.Write("Row " + (i + 1) + ": ");

            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
                rowSum += jaggedArray[i][j];
            }

            Console.WriteLine("=> Sum = " + rowSum);
        }
    }
}
