using System;

class FindingBit3
{
    static void Main()
    {
        int p = 3;
        int n = 85;               
        int mask = 1 << p;        
        int nAndMask = n & mask;  
        int bit = nAndMask >> p;  
        Console.WriteLine(bit);   
    }
}

