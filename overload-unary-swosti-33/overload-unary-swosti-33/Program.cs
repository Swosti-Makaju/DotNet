using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload_unary_swosti_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation num = new Calculation(5);
            // Unary + operator
            Calculation positiveNum = +num;
            Console.WriteLine("Unary + : " + positiveNum.Display());  // Output: 5
            // Unary - operator
            Calculation negatedNum = -num;
            Console.WriteLine("Unary - : " + negatedNum.Display());  // Output: -5
            // Unary ! operator
            Console.WriteLine("Unary ! : " + (!num));  // Output: False 
            // Unary ++ operator
            num++;
            Console.WriteLine("Unary ++ : " + num.Display());  // Output: 6
            // Unary -- operator
            num--;
            Console.WriteLine("Unary -- : " + num.Display());  // Output: 5

            Console.ReadLine();

        }
    }
}
public class Calculation
{
    int x;
    public Calculation(int x)
    {
        this.x = x;
    }
    public static Calculation operator +(Calculation a)
    {
        return new Calculation(+a.x);
    }
    public static Calculation operator -(Calculation a)
    {
        return new Calculation(-a.x);
    }
    public static bool operator !(Calculation a)
    {
        return a.x == 0;
    }
    public static Calculation operator ++(Calculation a)
    {
        a.x += 1;
        return a;
    }
    public static Calculation operator --(Calculation a)
    {
        a.x -= 1;  // Decrement the value
        return a;
    }
    public int Display()
    {
        return x;
    }
}