using System;

class findZero
{
    static void Main()
    {

        int[] MainArray = {1, -2, -2, -1, 4};

        for (int i = 0; i < MainArray.Length; i++)
        {
            for (int j = i + 1; j < MainArray.Length; j++)
            {
                if (MainArray[i] + MainArray[j] == 0)
                {
                    Console.WriteLine(MainArray[i] + " " + MainArray[j] + " = 0");
                }
                for (int k = j + 1; k < MainArray.Length; k++)
                {
                    if (MainArray[i] + MainArray[j] + MainArray[k] == 0)
                    {
                        Console.WriteLine(MainArray[i] + " " + MainArray[j] + " " + MainArray[k] + " = 0");
                    }
                    for (int h = k + 1; h < MainArray.Length; h++)
                    {
                        if (MainArray[i] + MainArray[j] + MainArray[k] + MainArray[h] == 0)
                        {
                            Console.WriteLine(MainArray[i] + " " + MainArray[j] + " " + MainArray[k] + " " + MainArray[h] + " = 0");
                        }
                    }
                }
            }
            
        }

        if (MainArray[0] + MainArray[1] + MainArray[2] + MainArray[3] + MainArray[4] == 0)
        {
            Console.WriteLine(MainArray[0] + " " + MainArray[1] + " " + MainArray[2] + " " + MainArray[3] + " " + MainArray[4] + " = 0");
        }

    }
}
