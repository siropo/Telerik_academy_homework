using System;

class bigNum
{
    static void Main()
    {
        Console.Write("a = ");
        string line = Console.ReadLine();

        int a = int.Parse(line);

        Console.Write("b = ");
        line = Console.ReadLine();
        int b = int.Parse(line);

        Console.Write("c = ");
        line = Console.ReadLine();
        int c = int.Parse(line);

        if (a > c && a > b)
        {
            Console.WriteLine("a is most larger");           
        }
        if (b > a && b > c)
        {
            Console.WriteLine("b is most larger");
        }
        if (c > b && c > a)
        {
            Console.WriteLine("c is most larger");
        }
    }
}

