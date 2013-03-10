using System;

class PrintNNumber
{
    static void Main()
    {
        Console.Write("n = ");
        string consoleInput = Console.ReadLine();
        int n;

        if (int.TryParse(consoleInput, out n))
        {
            if (n < 2)
            {
                Console.WriteLine("Please enter number > 1");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter valid number");
        }
        
    }
}

