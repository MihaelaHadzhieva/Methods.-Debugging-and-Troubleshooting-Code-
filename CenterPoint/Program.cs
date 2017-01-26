using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());
            Checker(x1, y1, x2, y2);
        }
        public static void Checker(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            if ((x1 > x2 && y1 > y2) || (x1 == x2 && y1 == y2))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if ((x1 == x2 && y1 == y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (x1 < x2 && y1 < y2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (x1 > x2 && y1 < y2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (x1 > x2 && y1 > y2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (x1 < x2 && y1 > y2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (x1==0 && x2!=0 && y1<y2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
             else if (x1 == 0 && x2 != 0 && y1 > y2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (x1!=0  && x2 == 0 && y1 > y2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (x1 != 0 && x2 == 0 && y1 < y2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (x1 > x2  && y1==0 && y2!=0)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (x1 < x2 && y1 == 0 && y2 != 0)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (x1 > x2 && y2 == 0 && y1 != 0)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (x1 < x2 && y2 == 0 && y1 != 0)
            {
                Console.WriteLine($"({x1}, {y1})");
            }



        }
    }
}
