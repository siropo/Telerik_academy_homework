using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count3x3
{
    class BestSumPlatform
    {
        static void Main(string[] args)
        {
            int N = 10;
            int M = 20;

            int[,] rectMatrix = {
                                    {2, 4,  5,  7,  9,   8,  2,  5,  6,  8},
                                    {4, 4,  2,  7,  9,   12, 4,  22, 6,  4},
                                    {5, 33, 23, 72, 120, 12, 42, 22, 16, 14},
                                    {4, 2,  3,  2,  11,  32, 42, 22, 16, 24}
                                };

            //Console.WriteLine(rectMatrix.GetLength(1));
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < rectMatrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < rectMatrix.GetLength(1) - 2; col++)
                {
                    int currentSum = 0;
                    currentSum = rectMatrix[row, col] + rectMatrix[row, col + 1] + rectMatrix[row, col + 2] +
                                 rectMatrix[row + 1, col] + rectMatrix[row + 1, col + 1] + rectMatrix[row + 1, col + 2] +
                                 rectMatrix[row + 2, col] + rectMatrix[row + 2, col + 1] + rectMatrix[row + 2, col + 2];
                    if (currentSum > bestSum)
                    {
                        bestRow = row;
                        bestCol = col;
                        bestSum = currentSum;
                    }
                }
            }
            Console.WriteLine(bestSum);
            Console.WriteLine("best row " + bestRow + " best col " + bestCol);
        }
    }
}
