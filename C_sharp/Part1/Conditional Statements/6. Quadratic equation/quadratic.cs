using System;

class quadratic
{
    static void Main()
    {
        Console.Write("a = ");
        string line = Console.ReadLine();
        double a = double.Parse(line);

        Console.Write("b = ");
        line = Console.ReadLine();

        double b = double.Parse(line);

        Console.Write("c = ");
        line = Console.ReadLine();

        double c = double.Parse(line);

        double D = (b * b) - (4 * a * c);

        if (D < 0) {
           Console.WriteLine("D = {0} Уравнението няма реални корени!", D);
        } else if (D == 0) {
            double x = -b / (2 * a);
            Console.WriteLine("D = {0}, x = {1}. Уравнението има един реален корен!", D, x);
        } else {
            double x1 = (-b + Math.Sqrt(D)) / (a * 2);
            double x2 = (-b - Math.Sqrt(D)) / (a * 2);
            Console.WriteLine("D = {0} Уравнението има два реални корена! x1 = {1}, x2 = {2}", D, x1, x2);
        }
    }
}


