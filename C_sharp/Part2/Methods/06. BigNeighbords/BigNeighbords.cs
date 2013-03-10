using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BigNeighbords
{
    class BigNeighbords
    {
        static int CheckNumIsBigNightbors(int[] arr)
        {
            int result = -1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                {
                    result = arr[i];
                    break;
                }
            }
            return result;
        }

        static void Main()
        {
            int[] arrNum = { 1, 2, 5, 4, 2, 3, 2};
            int result = CheckNumIsBigNightbors(arrNum);
            Console.WriteLine(result);
        }
    }
}
