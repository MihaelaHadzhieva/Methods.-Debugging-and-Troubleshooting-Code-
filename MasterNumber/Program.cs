using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            IsPalindrom(number);
        }

        public static void IsPalindrom(int num)
        {

            for (int i = 101; i <= num; i++)
            {
                int firstDigit = 0; ;
                int n = i;
                int number = i;
                int dig = n % 10;
                while (number > 0)
                {
                    firstDigit = number % 10;
                    number /= 10;
                }
                if (firstDigit == dig)
                {
                    int sum = 0;
                    int number1 = i;
                    while (number1 > 0)
                    {
                        sum += number1 % 10;

                        number1 /= 10;
                    }
                    if (sum % 7 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }

}








