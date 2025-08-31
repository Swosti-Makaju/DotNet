using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentmarks_swosti_33
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a jagged array: 3 students with different number of subjects
            int[][] studentMarks = new int[3][];
            studentMarks[0] = new int[] { 85, 78, 92 };           // Student 1: 3 subjects
            studentMarks[1] = new int[] { 88, 74, 90, 69 };       // Student 2: 4 subjects
            studentMarks[2] = new int[] { 91, 87 };               // Student 3: 2 subjects

            // Display marks and average for each student
            for (int i = 0; i < studentMarks.Length; i++)
            {
                Console.WriteLine($"Student {i + 1} Marks:");
                int total = 0;

                for (int j = 0; j < studentMarks[i].Length; j++)
                {
                    Console.WriteLine($"  Subject {j + 1}: {studentMarks[i][j]}");
                    total += studentMarks[i][j];
                }

                double average = (double)total / studentMarks[i].Length;
                Console.WriteLine($"  Average Marks: {average:F2}\n");
            }

        }
    }
}