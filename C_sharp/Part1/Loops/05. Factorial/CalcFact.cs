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
            if (N > 1 && K > N)
            {
                uint kFact = K;
                uint nFact = N;
                uint nkFact = K - N;

                for (var i = kFact - 1; i > 0; i--) {
                    kFact *= i;

                    if (kFact == nFact) 
                    {
                        kFact = nFact;
                    } 
                    else if (i < nFact) 
                    {
                        nFact *= i;
                    }
                    if (i < nkFact) 
                    {
                        nkFact *= i;
                    }
                }
                uint calc = (nFact * kFact) / nkFact;
                Console.WriteLine("The result of n!*k!/(k-n)! is {0}", calc);
            }
            else
            {
                Console.WriteLine("K must be > 1 and N must be > K");
            }
        }
        else
        {
            Console.WriteLine("Please enter valid numbers");
        }
    }
}

