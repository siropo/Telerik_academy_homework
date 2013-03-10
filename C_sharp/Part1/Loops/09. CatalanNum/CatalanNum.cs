using System;

class CatalanNum
{

    static decimal FactorialCalc(decimal number)
    {
        decimal sum = 1;
        for (int i = 1; i <= number; i++)
        {
            sum = sum * i;
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("N = ");
        string inputN = Console.ReadLine();
        decimal N;


        if (decimal.TryParse(inputN, out N))
        {
             decimal CatalanSum = 0;
             CatalanSum = FactorialCalc(2 * N) / (FactorialCalc(N + 1) * FactorialCalc(N));
             Console.WriteLine(CatalanSum);
        }
        else
        {
            Console.WriteLine("Please enter valid numbers");
        }
    }
}

