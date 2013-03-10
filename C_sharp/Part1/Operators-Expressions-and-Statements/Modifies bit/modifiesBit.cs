using System;

class modifiesBit
{
    static void Main()
    {
        int n = 48;
        int p = 3;
        int v = 0;
        int replace = 0;

        int mask = 1 << p;
        int nAndMask = n & mask;
        int nBit = nAndMask >> p;

        if (v != 0)
        {
            replace = n ^ mask;
            
        }
        else
        {
            if (nBit != 0)
            {
                
                replace = n ^ mask;
            }
            else
            {
                replace = n;
            }
        }
        
        Console.WriteLine(replace);

    }
}
