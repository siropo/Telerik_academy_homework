using System;

class Tribonacci
{
    static void Main()
    {
        long firstNum = long.Parse(Console.ReadLine());
        long secondNum = long.Parse(Console.ReadLine());
        long thirdNum = long.Parse(Console.ReadLine());

        long rows = long.Parse(Console.ReadLine());
        long finalSum = 0;
        Console.WriteLine(firstNum + "\n" + secondNum + " " + thirdNum);
        for (long i = 2; i < rows; i++)
        {
            for (long j = 0; j < i + 1 ; j++)
            {
                long temp1 = firstNum; // 1
                long temp2 = secondNum; // -1
                long temp3 = thirdNum; // 1
                long temp4 = finalSum; // 1 1 

                if (j == 0 && i == 2)
                {
                    temp4 = thirdNum;
                    temp3 = secondNum;
                }

                finalSum += firstNum + secondNum + thirdNum;

                firstNum = 0;
                secondNum = temp3;
                thirdNum = temp4;

                Console.Write(finalSum + " ");
            }
            Console.WriteLine();
        }
    }
}
