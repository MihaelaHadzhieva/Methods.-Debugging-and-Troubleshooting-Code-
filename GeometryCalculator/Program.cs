using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFigure = Console.ReadLine();
            if (typeFigure=="triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                TriangleArea(side, height);
            }
            else if(typeFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());             
                SquareArea(side);
            }
            else if (typeFigure == "rectangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                RectangleArea(side, height);
            }
            else if (typeFigure == "circle")
            {
                double r = double.Parse(Console.ReadLine());             
                CircleArea(r);
            }
        }
        public static void TriangleArea(double side,double height)
        {
            Console.WriteLine("{0:f2}",Math.Round((side*height/2),2));
        }
        public static void SquareArea(double side)
        {
            Console.WriteLine("{0:f2}", Math.Round(side*side, 2));
        }
        public static void RectangleArea(double width, double height)
        {
            Console.WriteLine("{0:f2}", Math.Round((width * height), 2));
        }
        public static void CircleArea(double radius)
        {
            Console.WriteLine("{0:f2}", Math.Round((Math.PI*radius*radius), 2));
        }
    }
}
