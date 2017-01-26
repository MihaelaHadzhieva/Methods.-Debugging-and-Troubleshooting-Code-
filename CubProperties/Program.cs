using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            Calculate(cubSide, parameter);

        }
        public static void Calculate(double side,string parameter)
        {
            if (parameter=="face")
            {
                var faceDiagonal = Math.Sqrt(2 * Math.Pow(side, 2));
                Console.WriteLine("{0:f2}", Math.Round(faceDiagonal, 2));
            }
            else if (parameter=="space")
            {
                var spaceDiagonal = Math.Sqrt(3 * Math.Pow(side, 2));
                Console.WriteLine("{0:f2}", Math.Round(spaceDiagonal, 2));
            }
            else if (parameter=="volume")
            {
                var volume = Math.Pow(side, 3);
                Console.WriteLine("{0:f2}", Math.Round(volume, 2));
            }
            else if (parameter=="area")
            {
                var surfaceArea = 6 * Math.Pow(side, 2);
                Console.WriteLine("{0:f2}",Math.Round(surfaceArea,2));
            }
        }
    }
}
