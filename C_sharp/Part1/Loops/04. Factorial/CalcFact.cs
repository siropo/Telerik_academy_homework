using System;

class CalcFact
{
    static void Main()
    {
        Console.Write("N = ");
        string inputN = Console.ReadLine();
        Console.Write("K = ");
        string inputK = Console.ReadLine();
        uint N;
        uint K;

        if (uint.TryParse(inputN, out N) && uint.TryParse(inputK, out K))
        {
            if (K > 1 && N > K)
            {
                uint result = N;
                for (uint i = N - 1; i > K; i--)
                {
                    result *= i;
                }
                Console.WriteLine("N!/K! = " + result);
            }
            else
            {
                Console.WriteLine("K must > 1 and N must > K");
            }
        }
        else
        {
            Console.WriteLine("Please enter valid numbers");
        }

    }
}

