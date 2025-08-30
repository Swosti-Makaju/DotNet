using System;

class Program
{
    delegate void SpeakDelegate();

    static void Main()
    {
        SpeakDelegate dogSpeak = () => Console.WriteLine("Dog barks");
        SpeakDelegate catSpeak = () => Console.WriteLine("Cat meows");

        dogSpeak(); // Dog barks
        catSpeak(); // Cat meows
    }
}
