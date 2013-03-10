using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01a.Print_Matrix
{
    class PrintMatrix
    {
        static void PrintArrMatrix(int[,] matrix)
        {
            bool flip = false;
            int lengthFlip = matrix.GetLength(1) - 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                


                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (flip)
                    {
                       
                        Console.Write("{0, -2} | ", matrix[col, lengthFlip]);
                        flip = false;
                    }
                    else
                    {
                        Console.Write("{0, -2} |", matrix[col, row]);
                        flip = true;
                    }
                        
                }
                lengthFlip--;
                
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int n = 4;
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
