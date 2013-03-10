using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01c.Print_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            int direction = 0;
            int row = 0;
            int col = 0;
            int count = 1;
            int maxStep = n;
            int currStep = 0;

            while (count < n * n)
            {
                currStep++;
                if (currStep == maxStep)
                {
                    currStep = 0;
                    direction++;
                    direction = direction % 4;
                    if (direction == 1 || direction == 3)
                    {
                        maxStep--;
                    }
                }

                switch(direction) { 
                    case 0: row++; break;
                    case 1: col++; break;
                    case 2: row--; break;
                    case 3: col--; break;
                }

                matrix[row, col] = count++;

            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0:E}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
