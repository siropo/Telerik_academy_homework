using System;

class NotDevisible
{
    static void Main()
    {
        Console.Write("n = ");
        string consoleInput = Console.ReadLine();
        int n;

        if (int.TryParse(consoleInput, out n))
        {
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i % 21 != 0) 
                    {
                        Console.WriteLine(i);
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
        
    }
}

