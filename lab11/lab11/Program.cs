using System;

internal class Program
{
    static void Main(string[] args)
    {
        int[] arrone = { 2, 3, 4, 5 };
        int[] arrtwo = { 1, 3, 5, 7 };

        Console.WriteLine(isBalanceArray(arrone));
        Console.WriteLine(isBalanceArray(arrtwo));
        Console.ReadLine();
    }
    public static bool isBalanceArray(int[] a)
    {
        int count_even = 0;
        int count_odd = 0;

        foreach (int num in a)
        {
            if (num % 2 == 0)
                count_even++;
            else
                count_odd++;
        }

        return count_even == count_odd;
    }
}
