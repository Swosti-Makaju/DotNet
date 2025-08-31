using System;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string vowels = "";
        string consonants = "";
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char lowerChar = char.ToLower(c);
                if ("aeiou".Contains(lowerChar))
                    vowels += c;
                else
                    consonants += c;
            }
            File.WriteAllText("VOWEL.TXT", vowels);
            File.WriteAllText("CONSONANT.TXT", consonants);
            Console.WriteLine("Vowels written to VOWEL.TXT");
            Console.WriteLine("Consonants written to CONSONANT.TXT");
        }
    }
}