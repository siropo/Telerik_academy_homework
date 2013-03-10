using System;

class CirclePrAr
{
    static void Main()
    {
        Console.WriteLine("r = ");
        string line = Console.ReadLine();

        int r = int.Parse(line);

        Console.WriteLine("Perimeter is 2 * {0} = {1}", r, 2 * r);
        Console.WriteLine("Area is PI * {0} * {0} = {1}", r, 3.14 * (r * r));
    }
}

