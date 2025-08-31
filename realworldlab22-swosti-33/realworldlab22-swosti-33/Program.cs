using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realworldlab22_swosti_33
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle Rect = new Rectangle();
            int area;
            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();

            // Print the area of the object.
            Console.WriteLine("Total area:" + Rect.getArea());
            Console.WriteLine("Total paint cost:" + Rect.getCost(area));
            Console.ReadLine();
        }
    }
    class Shape
    {
        protected int width;
        protected int height;

        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }

    // Base class PaintCost
    public interface PaintCost
    {
        int getCost(int area);
    }
    // Derived class
    class Rectangle : Shape, PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }
    }

}
