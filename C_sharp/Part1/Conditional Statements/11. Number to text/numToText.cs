using System;

class numToText
{
    static void Main()
    {
        string a = "500";
        string[] dg = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] tn = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tw = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        int arrLen = a.Length;
        int[] b = new int[arrLen];

        for (int i = 0; i < arrLen; i++)
        {
            b[i] = int.Parse(a[i].ToString());
        }

        if (arrLen == 1)
        {
            if (b[0] == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("" + dg[a[0]]);
            }
        }

        if (arrLen == 2)
        {
            if (b[0] == 1)
            {
                Console.WriteLine("" + tn[a[1]]);
            }
            if ((b[0] >= 2) && (b[0] <= 9))
            {
                Console.WriteLine("" + tw[a[0]] + " " + dg[a[1]]);
            }
        }

        if (arrLen == 3)
        {
            if ((b[1] == 0) && (b[2] == 0))
            {
                Console.WriteLine("" + dg[b[0]] + " hundred ");
            }
            if ((b[1] == 0) && (b[2] > 0))
            {
                Console.WriteLine("" + dg[b[0]] + " hundred " + dg[b[2]]);
            }
            if (b[1] == 1)
            {
                Console.WriteLine("" + dg[b[0]] + " hundred " + tn[b[2]]);
            }
            if ((b[1] >= 2) && (b[1] <= 9))
            {
                Console.WriteLine("" + dg[b[0]] + " hundred " + tw[b[1]] + " " + dg[b[2]]);
            }
        }
    }
}

