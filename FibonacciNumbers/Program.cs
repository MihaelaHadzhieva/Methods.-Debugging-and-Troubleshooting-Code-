using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Fibonacci(number);
        }
        public static void Fibonacci(long number)
        {
            if (number == 1)
            {
                Console.WriteLine("1");
            }
            else if (number==0)
            {
                Console.WriteLine("1");
            }
            else
            {
                long firstFibNum = 0;
                long secondFibNum = 1;
                long thirdNum = 0;
                for (int i = 1; i <= number; i++)
                {
                    thirdNum = firstFibNum + secondFibNum;
                    firstFibNum = secondFibNum;
                    secondFibNum = thirdNum;
                }
                Console.WriteLine(thirdNum);
            }
        }
    }
}
