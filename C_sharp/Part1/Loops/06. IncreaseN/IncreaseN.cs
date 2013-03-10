using System;

class CalcFact
{
    static void Main()
    {
        Console.Write("N = ");
        string inputN = Console.ReadLine();
        Console.Write("X = ");
        string inputX = Console.ReadLine();
        decimal N;
        decimal X;


        if (decimal.TryParse(inputN, out N) && decimal.TryParse(inputX, out X))
        {
            decimal s = 1;
            decimal fact = 1;
            decimal den = 1;

            Console.Write("S = 1");

            for (decimal i = 1; i <= N; i++)
            {
                fact *= i;
                den = den * X;
                s += (fact / den);

                Console.Write(" + " + i + "!/" + X + "^" + i);
            }
            Console.WriteLine(" = " + s);
        }
        else
        {
            Console.WriteLine("Please enter valid numbers");
        }
    }
}