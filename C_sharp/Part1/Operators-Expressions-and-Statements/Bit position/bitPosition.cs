using System;

class bitPosition
{
    static void Main()
    {
        int n = 35;
        int p = 2;
        int i = 1;

        int mask = i << p;
        Console.WriteLine((n & mask) != 0 ? true : false);
    }
}

