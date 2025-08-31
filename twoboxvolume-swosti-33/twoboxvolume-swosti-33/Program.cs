using System;
class Box
{
    public double Length { get; }
    public double Width { get; }
    public double Height { get; }
    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
    public double Volume()
    {
        return Length * Width * Height;
    }
    public static double operator +(Box b1, Box b2)
    {
        return b1.Volume() + b2.Volume();
    }
}
class Program
{
    static void Main()
    {
        Box box1 = new Box(3, 3, 4);
        Box box2 = new Box(1.5, 2.5, 3);
        double totalVolume = box1 + box2;
        Console.WriteLine($"Volume of Box 1: {box1.Volume()}");
        Console.WriteLine($"Volume of Box 2: {box2.Volume()}");
        Console.WriteLine($"Total Volume (Box1 + Box2): {totalVolume}");
    }
}