using System;

class sum
{
    static void Main()
    {
        Console.WriteLine("a = ");
        string line = Console.ReadLine();

        int a = int.Parse(line);

        Console.WriteLine("b = ");
        line = Console.ReadLine();

        int b = int.Parse(line);

        Console.WriteLine("c = ");
        line = Console.ReadLine();

        int c = int.Parse(line);

        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
    }
}

