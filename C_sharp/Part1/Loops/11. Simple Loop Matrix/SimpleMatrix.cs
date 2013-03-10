using System;

class SimpleMatrix
{
    static void Main()
    {
        Console.Write("N = ");
        string inputN = Console.ReadLine();
        byte N;


        if (byte.TryParse(inputN, out N))
        {
            if (N < 20)
            {
                for (int i = 1; i < N + 1; i++)
                {
                    for (int j = i; j < N + i; j++)
                    {
                        Console.Write("{0, 3}", j);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Please enter number < 20");
            }
        }
        else
        {
            Console.WriteLine("Please enter valid numbers");
        }
    }
}

