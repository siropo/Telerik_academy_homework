using System;

class biggestNum
{
    static void Main()
    {
        int[] myArray = new int[5];

        Console.Write("a = ");
        string line = Console.ReadLine();

        int a = int.Parse(line);

        Console.Write("b = ");
        line = Console.ReadLine();
        int b = int.Parse(line);

        Console.Write("c = ");
        line = Console.ReadLine();
        int c = int.Parse(line);

        Console.Write("d = ");
        line = Console.ReadLine();
        int d = int.Parse(line);

        Console.Write("f = ");
        line = Console.ReadLine();
        int f = int.Parse(line);

        myArray[0] = a;
        myArray[1] = b;
        myArray[2] = c;
        myArray[3] = d;
        myArray[4] = f;

        int max = myArray[0];

        for (int i = 0; i < myArray.Length; i++)
        {
            if (max < myArray[i])
            {
                max = myArray[i];
            }
        }
        Console.WriteLine("biggest num si {0}", max);
    }
}

