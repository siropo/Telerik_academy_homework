using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USFlag
{
    class quadronaciRect
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int dots = (N - 3) / 2;
            int line = N - dots;
            int centerLine = (N / 2);
            int leftLine = 0;
            int rightLine = N - 1;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (centerLine == j) {
                        if (i == centerLine)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("|");
                        }
                    } 
                    else if (leftLine == j)
                    {
                        if (i == centerLine)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write("\\");
                        }
                    } 
                    
                    else if (rightLine == j) 
                    {
                        if (i == centerLine)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                        
                    }
                    else 
                    {
                        if (i == centerLine)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                        
                    }
                }
                leftLine += 1;
                rightLine -= 1;
                dots -= leftLine;
                Console.WriteLine();
            }
        }
    }
}
