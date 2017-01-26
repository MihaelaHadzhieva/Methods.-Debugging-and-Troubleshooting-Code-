using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            Factorial(number);
        }
        public static void Factorial(BigInteger number)
        {
            BigInteger result = 1;
            for (BigInteger i = 1; i <= number; i++)
            {
                result = result * i;
            }

            long timesZero = 0;

            while (result % 10 == 0)
            {
                timesZero++;
                result /= 10;
            }
            Console.WriteLine(timesZero);
        }

    }
}
