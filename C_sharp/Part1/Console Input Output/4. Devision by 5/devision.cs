//Write a program that reads two positive integer numbers and 
//prints how many numbers p exist between them such that the reminder of
//the division by 5 is 0 (inclusive). Example: p(17,25) = 2.


using System;

class devision
{
    static void Main()
    {
        Console.WriteLine("first num = ");
        string line = Console.ReadLine();
        uint a = uint.Parse(line);

        Console.WriteLine("second num = ");
        line = Console.ReadLine();

        uint b = uint.Parse(line);

        int count = 0;
        for (uint i = a; i <= b; i++) {
            if(i % 5 == 0) {
                Console.WriteLine("found {0}", i);
                count++;
            }
        }
        Console.WriteLine("Count founded {0}", count);
    }
}

