using System;

class calcSum
{
    static void Main()
    {
        Console.Write("Enter numbers: ");
        string line = Console.ReadLine();
        float numN = float.Parse(line);

        float sum = 1;

        Console.Write(sum);
        for (float i = 2; i < numN + 2; i++)
        {
            if (i % 2 == 0)
            {
                sum += 1 / i;
                Console.Write(" + " + "1" + "/" + i);
            }
            else
            {
                sum -= 1 / i;
                Console.Write(" - " + "1" + "/" + i);
            }
        }
        Console.Write(" = {0:0.0000}", sum);
        Console.WriteLine();
    }
}

