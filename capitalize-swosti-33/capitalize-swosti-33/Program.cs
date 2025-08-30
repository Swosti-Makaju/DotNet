using System;
using System.IO;
using System.Globalization;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string capitalized = textInfo.ToTitleCase(input.ToLower());
        File.WriteAllText("output.txt", capitalized);
        Console.WriteLine("Capitalized sentence written to output.txt");
    }
}
