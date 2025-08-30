using System;

// Define generic delegate
public delegate T MyGenericDelegate<T>(T value);

class Program
{
    // Method for delegate
    public static T Display<T>(T data)
    {
        Console.WriteLine("Value: " + data);
        return data;
    }

    static void Main()
    {
        // Create delegate instance for int
        MyGenericDelegate<int> intDelegate = new MyGenericDelegate<int>(Display);
        intDelegate(100);

        // Create delegate instance for string
        MyGenericDelegate<string> stringDelegate = new MyGenericDelegate<string>(Display);
        stringDelegate("Good Morning !");
    }
}
