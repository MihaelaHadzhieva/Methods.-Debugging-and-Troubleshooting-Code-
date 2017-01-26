using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(firstNum, secondNum, thirdNum)); 
        }
        public static int GetMax(int firstNum, int secondNum, int thirdNum)
        {
            int Maxnumber = Math.Max(firstNum, secondNum);
            return Math.Max(Maxnumber, thirdNum);       
        }
    }
}
