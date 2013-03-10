using System;

class sortNum
{
    static void Main()
    {
        Console.Write("a = ");
        string line = Console.ReadLine();

        uint a = uint.Parse(line);

        Console.Write("b = ");
        line = Console.ReadLine();
        uint b = uint.Parse(line);

        Console.Write("c = ");
        line = Console.ReadLine();
        uint c = uint.Parse(line);

        if (a > c)
        {
            if (b > c)
            {
                if (a > b)
                {
                    Console.WriteLine("Sort result " + c + ", " + b + ", " + a);
                }
                else
                {
                    Console.WriteLine("Sort result " + c + ", " + a + ", " + b);
                }
            }
            else
            {
                Console.WriteLine("Sort result " + b + ", " + c + ", " + a);
            }
        } 
        if (b > a)
        {
            if (b > c)
            {
                if (c > a)
                {
                    Console.WriteLine("Sort result " + a + ", " + c + ", " + b);
                }
            }
        } 
        if (c > b)
        {
            if (c > a)
            {
                if (b > a)
                {
                    Console.WriteLine("Sort result " + a + ", " + b + ", " + c);
                }
                else
                {
                    Console.WriteLine("Sort result " + b + ", " + a + ", " + c);
                }
            }
        }


    }
}

