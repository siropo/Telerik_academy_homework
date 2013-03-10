using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixDiagonal
{
    class Program
    {
        static int count = 1;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int rows = n - 1;
            int cols = 0;

            while (!(rows == -1) && !(cols == n))
            {
                //matrix[rows, cols] = count++;
                if (rows > 0)
                {
                    rows--;
                }
                else
                {
                    cols++;
                }
                FillDiagonal(matrix, rows, cols);
            }

            PrintMatrix(matrix);
        }

        static void FillDiagonal(int[,] matrix, int row, int col)
        {
            int currRow = row;
            int currCol = col;
            while (currRow < matrix.GetLength(0) && currCol < matrix.GetLength(1))
            { 

                matrix[currRow, currCol] = count++;
                currRow++;
                currCol++;
                
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, 3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
