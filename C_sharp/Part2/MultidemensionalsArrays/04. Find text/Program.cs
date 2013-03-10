using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Find_text
{
    class Program
    {
        StringBuilder allMatch = new StringBuilder();
        List<string> appendMatch = new List<string>();
        static string[] matches = new string[3];
        static void Main(string[] args)
        {
            string[,] matrix = {
                                {"ds", "ss", "ss", "ss"},
                                {"hsa", "ha", "ss", "ddd"},
                                {"fd", "dasd", "das", "das"}
                               };
            int bestMatch = 0;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matches = SearchCols(matrix, row, col);
                    if (int.Parse(matches[0]) > bestMatch)
                    {
                        bestMatch = int.Parse(matches[0]);
                        bestRow = int.Parse(matches[1]);
                        bestCol = int.Parse(matches[2]);
                    }
                    
                }
            }
            Console.WriteLine("best row " + bestRow + " best col " + bestCol);
            Console.WriteLine(bestMatch);
        }

        private static string[] SearchCols(string[,] matrix, int CurRow, int CurCol)
        {
            int bestMatch = 0;
            
            string[] result = new string[3];
            for (int row = CurRow; row < matrix.GetLength(0); row++)
            {
                int mathches = 0;
                for (int col = CurCol; col < matrix.GetLength(1); col++)
                {
                    
                    if (matrix[CurRow, CurCol] == matrix[row, col])
                    {
                        mathches++;
                        if (mathches > bestMatch)
                        {
                            bestMatch = mathches;
                            result[0] = bestMatch.ToString();
                            result[1] = CurRow.ToString(); 
                            result[2] = CurCol.ToString();
                        }
                    }
                }
            }
            return result;
        }

        private static int SearchRows(string[,] matrix)
        {
            int mathches = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, row] == "1")
                {
                    mathches++;
                }
            }
            return mathches;
        }

        private static int SearchDiagonals(string[,] matrix)
        {
            int mathches = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == "1")
                    {
                        mathches++;
                    }
                }
                
            }
            return mathches;
        }
    }
}
