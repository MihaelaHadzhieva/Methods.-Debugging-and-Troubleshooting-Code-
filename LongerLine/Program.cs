using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
        }
        public static void Checker(double x1, double y1, double x2, double y2,
                                   double x3, double y3, double x4, double y4)
        {
            double firstDistance = 0;
            firstDistance = Math.Sqrt(Math.Pow((x1 - x2), 2) - Math.Pow((y1 - y2),2));

        }
    }
}
