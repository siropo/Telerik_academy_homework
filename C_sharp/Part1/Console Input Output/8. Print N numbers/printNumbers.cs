/*----------------------------------------------------------------------------------------
Write a program that reads an integer number n from the console
and prints all the numbers in the interval [1..n], each on a single line.
--------------------------------------------------------------------------------------- */

using System;

class printNumbers
{
    static void Main()
    {
        Console.Write("Enter numbers: ");
        string line = Console.ReadLine();
        int enterNum = int.Parse(line);

        for (int i = 1; i <= enterNum; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}

