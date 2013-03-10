using System;

class bitExpresion
{
    static void Main()
    {

        int i = 39; // Number
        int b = 2; // Position of the bit

        int mask = 1 << b;

        Console.WriteLine("The {0} bit in {1} is {2}", b, i, (i & mask) != 0 ? 1 : 0);

    }
}

