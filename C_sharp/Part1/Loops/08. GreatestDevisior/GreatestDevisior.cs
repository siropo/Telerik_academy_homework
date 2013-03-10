using System;

class GreatestDevisior
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
            uint chkResult = 1;

            while (chkResult > 0)
            {
                chkResult = N % K;
                N = K;
                K = chkResult;
            }
            Console.WriteLine("GCD = " + N);
        }
        else
        {
            Console.WriteLine("Please enter valid numbers");
        }
    }
}

