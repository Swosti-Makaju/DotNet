using System;

class UserProfile
{
    static void Main()
    {
        // Read user details
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your country: ");
        string country = Console.ReadLine();

        Console.Write("Enter your favorite hobby: ");
        string hobby = Console.ReadLine();

        Console.Write("Enter your job post/title: ");
        string jobPost = Console.ReadLine();

        // Determine senior citizen eligibility (assuming age 60+)
        string eligibility = age >= 60 ? "Eligible" : "Not Eligible";

        // Display the personalized message
        Console.WriteLine("\n--- Personalized Message ---\n");
        Console.WriteLine($"Hello, {firstName} {lastName}!");
        Console.WriteLine($"You are {age} years old and are {eligibility} for senior citizen benefits.");
        Console.WriteLine($"You currently work as a {jobPost} in {country}.");
        Console.WriteLine($"Your favorite hobby is {hobby}. That's awesome!");
        Console.WriteLine("\n---\n\"Thank you for sharing your details!\"");
    }
}
