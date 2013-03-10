using System;

class greaterNum
{
    static void Main()
    {
        Console.WriteLine("first num = ");
        string line = Console.ReadLine();
        uint a = uint.Parse(line);

        Console.WriteLine("second num = ");
        line = Console.ReadLine();

        uint b = uint.Parse(line);

        Console.WriteLine("Max is {0}", Math.Max(a, b));
    }
}
