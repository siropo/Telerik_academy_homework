using System;

class MinMax
{
    static void Main()
    {
        Console.Write("How meny numbers to check = ");
        string consoleInput = Console.ReadLine();
        int n;
        int max = 0;
        int min = 0;

        if (int.TryParse(consoleInput, out n))
        {
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    string nInput = Console.ReadLine();
                    int current;
                    if (int.TryParse(nInput, out current))
                    {
                        if (i == 0)
                        {
                            min = current;
                            max = current;
                        }
                        if (current > max)
                        {
                            max = current;
                        }
                        else if (current < min)
                        {
                            min = current;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid number");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter number > 1");
            }
        }
        else
        {
            Console.WriteLine("Please enter valid number");
        }

        Console.WriteLine("Max is " + max);
        Console.WriteLine("Min is " + min);
    }
}

