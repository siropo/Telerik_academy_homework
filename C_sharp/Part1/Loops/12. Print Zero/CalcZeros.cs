using System;

class CalcZeros
{
    static void Main()
    {
        Console.Write("N = ");
        string inputN = Console.ReadLine();
        int N;


        if (int.TryParse(inputN, out N))
        {
            int result = 0;
            for (int i = 5; i <= N; i *= 5)
            {
                result = result + (N / i);
            }
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Please enter valid numbers");
        }
    }
}

