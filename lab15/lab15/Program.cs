using System;

class SwapUsingRef
{
    static void Main()
    {
        int a, b;

        Console.Write("Enter first number (a): ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number (b): ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nBefore swap: a = {a}, b = {b}");

        Swap(ref a, ref b);

        Console.WriteLine($"After swap: a = {a}, b = {b}");
    }

    // Method to swap two numbers using ref
    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
