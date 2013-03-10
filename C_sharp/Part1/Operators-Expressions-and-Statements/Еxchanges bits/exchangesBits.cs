// * Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class exchangesBits
{
    static void Main()
    {

        int n = 2046820347; // number to change bits
        int mask = 0;
        int nAndMask = 0;
        int bit = 0;
        
        int replace = n; 

        byte q = 2; // start first position to get bits
        byte k = 25; // start second position to get bits
        byte p = 4; // number of bits to gets after choise first and second positions

        int[] myArrayQ = new int[p]; // array for first bits
        int[] myArrayK = new int[p]; // array for second bits

        for (byte i = 0; i < p; i++)
        {
            byte firstPos = q; // start position to get bits
            firstPos += i;     // position + i 
            mask = 1 << firstPos;
            nAndMask = n & mask;
            bit = nAndMask >> firstPos; // return bit on position
            myArrayQ[i] = bit; // create array for bits
        }

        for (byte i = 0; i < p; i++)
        {
            byte secondPos = k; // start position to get bits
            secondPos += i; // position + i
            mask = 1 << secondPos; 
            nAndMask = n & mask;
            bit = nAndMask >> secondPos; // return bit on position
            myArrayK[i] = bit;
            if (bit != myArrayQ[i]) // if bit on position + p not equal to position on bit on ArrayQ whit bits
            {
                replace = replace ^ mask; // replace bit on this position whit bit on current array position
            }
        }

        for (byte i = 0; i < p; i++)
        {
            byte firstPos = 2; // start position to get bits
            firstPos += i; // position + i
            mask = 1 << firstPos;
            if (myArrayQ[i] != myArrayK[i]) // if ArrayQ[i] not equal to position on bit on ArrayK[i] 
            {
                replace = replace ^ mask; // replace bit on this position whit bit on current array position
            }
        }
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(replace, 2).PadLeft(32, '0'));
    }
}

