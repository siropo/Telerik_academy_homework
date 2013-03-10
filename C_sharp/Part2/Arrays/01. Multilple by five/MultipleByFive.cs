using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Multilple_by_five
{
    class MultipleByFive
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[21];
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] % 5 == 0)
                {
                    Console.WriteLine("number {0} is devided by 5", numbers[i]);
                }
            }
        }
    }
}
