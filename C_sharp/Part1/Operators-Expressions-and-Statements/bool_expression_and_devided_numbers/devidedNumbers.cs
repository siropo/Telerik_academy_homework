using System;

class devidedNumbers
{
    static void Main()
    {
        short b = 35;
        Console.WriteLine((b % 5) == 0 && (b % 7) == 0 ? "number is divided by 7 and 5" : "number is not divided by 7 and 5");
    }
}

