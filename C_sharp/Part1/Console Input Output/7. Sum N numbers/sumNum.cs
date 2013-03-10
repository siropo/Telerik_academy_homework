//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class sumNum
{
    static void Main()
    {
        Console.Write("How meny numbers: ");
        string line = Console.ReadLine();
        int enterNum = int.Parse(line);
        int sum = 0;
        for (int i = 0; i < enterNum; i++)
        {
            Console.Write("enter num: ");
            line = Console.ReadLine();
            int num = int.Parse(line);
            int plus = sum;
            sum += num;
            Console.WriteLine("{0} + {1} = {2}",num, plus, sum);
        }
        
    }
}

