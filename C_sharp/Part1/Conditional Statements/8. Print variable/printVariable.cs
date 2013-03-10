using System;

class printVariable
{
    static void Main()
    {
        Console.Write("a = ");
        string str = Console.ReadLine();
        int number;
        double dNumber;

        if (int.TryParse(str, out number))
        {
            Console.WriteLine("Int number: {0}", number);
            Console.WriteLine("Int number increase whit 1: {0}", number + 1);
        }
        else if (double.TryParse(str, out dNumber))
        {
            Console.WriteLine("Double: {0}", dNumber);
            Console.WriteLine("Double number increase whit 1: {0}", dNumber + 1);
        }
        else
        {
            Console.WriteLine("String: {0}", str);
            Console.WriteLine("New string " + str + "*");
        }
    }
}


