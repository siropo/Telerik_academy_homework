using System;

class sign
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

        if (a > 0)
        {
            if (b > 0)
            {
                if (c > 0)
                {
                    Console.WriteLine("We have (+a +b +d) = +");
                }
                else
                {
                    Console.WriteLine("We have(+a +b -d) = +");
                }
            }
            else
            {
                if (c > 0)
                {
                    Console.WriteLine("We have (+a -b +d) = +");
                }
                else
                {
                    Console.WriteLine("We have(+a -b -d) = -");
                }
            }
        }
        else
        {
            if (b < 0)
            {
                if (c < 0)
                {
                    Console.WriteLine("We have (-a -b -d) = -");
                }
                else
                {
                    Console.WriteLine("We have (-a -b +d) = -");
                }
            }
            else
            {
                if (c < 0)
                {
                    Console.WriteLine("We have (-a +b -d) = -");
                }
                else
                {
                    Console.WriteLine("We have (-a +b +d) = +");
                }
            }
        }

    }
}

