using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountNumberAppers
{
    class NumAppears
    {
        static int CheckNumbersAppears(int[,] arr, int num)
        {
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (num == arr[i, j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static void Main()
        {
            int[,] arrNum = {
                  {1, 2, 2, 4}, // row 0 values
                  {5, 6, 6, 6}, // row 1 values
            };
            Console.WriteLine("Find number = ");
            int num = int.Parse(Console.ReadLine());

            int findMaches = CheckNumbersAppears(arrNum, num);

            Console.WriteLine(findMaches);
        }
    }
}
