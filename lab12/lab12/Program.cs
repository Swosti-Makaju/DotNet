using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(hasMirrorEnds(new int[] { 1, 2, 3, 2, 1 }));  // True
        Console.WriteLine(hasMirrorEnds(new int[] { 7, 8, 9, 8, 7 }));  // True
        Console.WriteLine(hasMirrorEnds(new int[] { 1, 2, 3, 4, 5 }));  // False
        Console.WriteLine(hasMirrorEnds(new int[] { 1, 2, 2, 1 }));     // True
        Console.WriteLine(hasMirrorEnds(new int[] { 1, 2, 3, 1 }));     // False
        Console.ReadLine();
    }
    public static bool hasMirrorEnds(int[] a)
    {
        int n = a.Length;

        for (int i = 0; i < n / 2; i++)
        {
            if (a[i] != a[n - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
