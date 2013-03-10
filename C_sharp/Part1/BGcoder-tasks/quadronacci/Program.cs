using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadronacci_rect
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] firstAddNum = new long[4];

            for (long i = 0; i < 4; i++)
            {
                firstAddNum[i] = long.Parse(Console.ReadLine());
            }

            long R = long.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());

            long sum1 = firstAddNum[0];
            long sum2 = firstAddNum[1];
            long sum3 = firstAddNum[2];
            long sum4 = firstAddNum[3];
            long finalSum = 0;

            Console.Write(sum1 + " " + sum2 + " " + sum3 + " " + sum4 + " ");

            for (long i = 0; i < R; i++)
            {
                if (i == 0 && C == 4)
	            {
                    R -= 1;
                    Console.WriteLine();
	            }
                else 
                {
                    if (i == 0)
                    {
                        C -= 4;
                    }
                    else if (i == 1 && C != 4) 
                    {
                        C += 4;
                    }
                }

                for (long j = 0; j < C; j++)
                {

                    long temp1 = sum1;
                    long temp2 = sum2;
                    long temp3 = sum3;
                    long temp4 = finalSum;

                    if (i == 0 && j == 0)
                    {
                        temp4 = sum4;
                    }

                    finalSum += sum1 + sum2 + sum3 + sum4;

                    sum1 = temp2;
                    sum2 = temp3;
                    sum3 = temp4;
                    sum4 = 0;

                    Console.Write(finalSum + " ");

                }
                Console.WriteLine();
            }

            
            
        }
    }
}
