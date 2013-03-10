using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01c.Print_Matrix
{
    class PrintMatrix
    {
        static void PrintArrMatrix(int[,] matrix)
        {
            
        }

        static void Main()
        {
            int n = 8;
            int[,] matrix = new int[n, n];

            for (int i = 0, counter = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = counter++;
                }
            }

            PrintArrMatrix(matrix);
        }
    }
}
