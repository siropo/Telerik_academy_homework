/*----------------------------------------------------------------------------------------
Write a program to print the first 100 members of the sequence of Fibonacci: 
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
--------------------------------------------------------------------------------------- */

using System;

class fibonacci
{
    static void Main()
    {
        Console.Write("Enter numbers: ");
        string line = Console.ReadLine();
        uint numN = uint.Parse(line);

        numN = numN / 2;

        uint fi = 1;
        uint old = 0;
        uint sum = 1;
        Console.WriteLine(0);
        for (uint i = 1; i <= numN; i++)
        {
            fi = old + fi;
            old = old + fi;
            Console.WriteLine(fi);
            sum += fi;
            if (i < numN)
            {
                Console.WriteLine(old);
                sum += old;
            }
        }
        Console.WriteLine("sum = " + (sum - 1));
    }
}

