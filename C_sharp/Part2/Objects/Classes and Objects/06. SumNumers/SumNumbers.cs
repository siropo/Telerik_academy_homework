using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumNumers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            string myString = "43 68,9   , 23 / // 318";
            int calc = SumOfStrings(myString);

            Console.WriteLine(calc);
        }

        private static int SumOfStrings(string myString)
        {
            int sum;
            char[] charSeparators = new char[] { ' ', ',', '-', '/' };
            string[] splittedArray = myString.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            sum = Sum(splittedArray);

            return sum;
        }

        private static int Sum(string[] splittedArray)
        {
            int total = 0;
            foreach (string number in splittedArray)
            {
                total += int.Parse(number);
            }

            return total;
        }
    }
}
