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
            int[] firstAddNum = new int[4];

            for (int i = 0; i < 4; i++)
            {
                firstAddNum[i] = int.Parse(Console.ReadLine());
            }

            int R = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            int sumCount = R * C;
            int sum1 = firstAddNum[0] + firstAddNum[1] + firstAddNum[2] + firstAddNum[3];
            int sum2 = firstAddNum[1] + firstAddNum[2] + firstAddNum[3];
            int sum3 = firstAddNum[2] + firstAddNum[3];
            int sum4 = firstAddNum[3];
            int finalSum = 0;
            string sumAll = "";
            sumAll = firstAddNum[0].ToString() + " " + firstAddNum[1].ToString() + " " + firstAddNum[2].ToString() + " " + firstAddNum[3].ToString() + " ";
            

            for (int j = 0; j < R; j++)
            {
                if (j == 0)
                {
                    Console.Write(sumAll);
                    C = C - 4;
                }
                else
                {
                    C = C + 4;
                }

                for (int i = 0; i < C; i++)
                {
                    
                    if (i == 0 && j == 0)
                    {
                        finalSum += sum1;//10
                        Console.Write(finalSum + " ");
                    }
                    else if (i == 1 && j == 0)
                    {
                        finalSum += sum2;//19
                        Console.Write(finalSum + " ");
                    }
                    else if (i == 2 && j == 0)
                    {
                        sum2 = finalSum;
                        finalSum += sum1 + sum3; // 36
                        Console.Write(finalSum + " ");
                    }
                    else if (i == 3 && j == 0)
                    {
                        sum3 = finalSum;
                        finalSum += sum2 + sum1 + sum4; // 69 sum2 = 19 sum1 = 10 sum4 - 4
                        Console.Write(finalSum + " ");
                    }
                    else 
                    {
                        if (i == 4 && j == 0)
                        {
                            sum4 = sum1; // 10
                            sum1 = sum2; // 19 sum3 = 36
                            finalSum += sum2 + sum3 + sum4; // 69
                            Console.Write(finalSum + " ");
                        }
                        else
                        {
                            if (i == 5 && j == 0)
	                        {
		                        sum1 = 19;
                                sum2 = 36;
                                sum3 = 69;
                                sum4 = 134;
                                finalSum += sum1 + sum2 + sum3; // 69

                                sum1 = 36;
                                sum2 = 69;
                                sum3 = 134;
                                Console.Write(finalSum + " ");
	                        }
                        
                            else {

                                int temp1 = sum1;
                                int temp2 = sum2;
                                int temp3 = sum3;
                                int temp4 = finalSum;

                                finalSum += sum1 + sum2 + sum3; // 69

                                sum1 = temp2;
                                sum2 = temp3;
                                sum3 = temp4;
                                Console.Write(finalSum + " ");
                            }
                        }
                    }

                }
                Console.WriteLine();
            }
            
            
        }
    }
}
