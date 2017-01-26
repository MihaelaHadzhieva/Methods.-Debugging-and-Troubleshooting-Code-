using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number)); 
        }
        public static bool IsPrime(long number)
        {
            bool result = true;
            if (number==0 || number==1)
            {
                return false;
            }
            for (int dividend = 2; dividend <= Math.Sqrt(number); dividend++)
            {                  
                   if (number % dividend == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}

