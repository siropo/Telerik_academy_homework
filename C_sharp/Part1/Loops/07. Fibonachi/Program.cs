using System;

class CalcFact
{
    static void Main()
    {
        Console.Write("N = ");
        string inputN = Console.ReadLine();
        uint N;

        if (uint.TryParse(inputN, out N))
        {
            uint F;
            uint K;

            if (N % 2 == 0)
            {
                F = N / 2;
                K = F + 1;
            }
            else
            {
                F = N / 2 + 1;
                K = F;
            }
            Console.WriteLine("f is " + F);
            uint fi = 1;
            uint old = 0;
            uint sum = 1;
            Console.WriteLine(0);
            for (uint i = 1; i <= F; i++)
            {
                fi = old + fi;
                old = old + fi;
                Console.WriteLine(fi);
                sum += fi;
                if (i < K)
                {
                    Console.WriteLine(old);
                    sum += old;
                }
            }
            Console.WriteLine("sum = " + (sum - 1));
        }
        else
        {
            Console.WriteLine("Please enter valid numbers");
        }
    }
}