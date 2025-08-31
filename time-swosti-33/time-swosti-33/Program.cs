using System;

class Time
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    // Constructor
    public Time(int h, int m, int s)
    {
        Hours = h;
        Minutes = m;
        Seconds = s;
        NormalizeTime();
    }

    // Display Time
    public void DisplayTime()
    {
        Console.WriteLine($"{Hours:D2}:{Minutes:D2}:{Seconds:D2}");
    }

    // Normalize time (if seconds or minutes > 59)
    private void NormalizeTime()
    {
        if (Seconds >= 60)
        {
            Minutes += Seconds / 60;
            Seconds %= 60;
        }
        if (Minutes >= 60)
        {
            Hours += Minutes / 60;
            Minutes %= 60;
        }
        Hours %= 24; // 24-hour format
    }

    // Operator overloading: + (Add two times)
    public static Time operator +(Time t1, Time t2)
    {
        return new Time(
            t1.Hours + t2.Hours,
            t1.Minutes + t2.Minutes,
            t1.Seconds + t2.Seconds
        );
    }

    // Operator overloading: - (Subtract two times)
    public static Time operator -(Time t1, Time t2)
    {
        int totalSeconds1 = t1.Hours * 3600 + t1.Minutes * 60 + t1.Seconds;
        int totalSeconds2 = t2.Hours * 3600 + t2.Minutes * 60 + t2.Seconds;
        int diff = totalSeconds1 - totalSeconds2;

        if (diff < 0) diff += 24 * 3600; // wrap around

        int h = diff / 3600;
        int m = (diff % 3600) / 60;
        int s = diff % 60;

        return new Time(h, m, s);
    }

    // Operator overloading: == and !=
    public static bool operator ==(Time t1, Time t2)
    {
        return t1.Hours == t2.Hours && t1.Minutes == t2.Minutes && t1.Seconds == t2.Seconds;
    }

    public static bool operator !=(Time t1, Time t2)
    {
        return !(t1 == t2);
    }

    // Override Equals and GetHashCode when overloading == and !=
    public override bool Equals(object obj)
    {
        if (obj is Time t)
            return this == t;
        return false;
    }

    public override int GetHashCode()
    {
        return Hours ^ Minutes ^ Seconds;
    }
}

class Program
{
    static void Main()
    {
        Time t1 = new Time(10, 45, 50);
        Time t2 = new Time(2, 30, 15);

        Console.Write("Time 1: ");
        t1.DisplayTime();

        Console.Write("Time 2: ");
        t2.DisplayTime();

        Time t3 = t1 + t2;
        Console.Write("After Addition: ");
        t3.DisplayTime();

        Time t4 = t1 - t2;
        Console.Write("After Subtraction: ");
        t4.DisplayTime();

        Console.WriteLine("Are t1 and t2 equal? " + (t1 == t2));
    }
}
