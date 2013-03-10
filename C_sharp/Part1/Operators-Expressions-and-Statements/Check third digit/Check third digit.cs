using System;

class CheckThirdDigit
{
    static void Main()
    {
        int c = 7777777;
        int new_c = c / 100;
        new_c = new_c % 10;

        Console.WriteLine(new_c == 7 ? "found 7" : "7 not found");
    }
}

