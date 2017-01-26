using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(PrintInRevereseOrder(number));

        }
        public static string PrintInRevereseOrder(string number)
        {
            char[] reverseNumber = number.ToCharArray();           
            Array.Reverse(reverseNumber);
            return new string(reverseNumber);
        }

    }
}
