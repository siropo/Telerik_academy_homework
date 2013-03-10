using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Get_max
{
    class GetMax
    {
        static int GetMaxNum(int one, int two)
        {
            if (one > two)
            {
                return one;
            }
            else
            {
                return two;
            }
        }

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int getMax = GetMaxNum(num1, num2);
            int num3 = int.Parse(Console.ReadLine());
            getMax = GetMaxNum(getMax, num3);

            Console.WriteLine(getMax);
        }
    }
}
