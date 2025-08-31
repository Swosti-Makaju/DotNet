using System;

class UserInfo
{
    static void Main()
    {
        // Read user input
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your country: ");
        string country = Console.ReadLine();

        // Display message using string interpolation
        Console.WriteLine($"\nHello {name}, you are {age} years old and live in {country}.");
    }
}
