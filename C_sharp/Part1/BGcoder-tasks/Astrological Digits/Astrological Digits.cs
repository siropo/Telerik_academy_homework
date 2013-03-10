using System;

class AstrologicalDigits
{
    static void Main()
    {
        int sumDigit = 0;
        
        while (true)
        {
            int ch = Console.Read();
            if ((ch == -1) ||  (ch == '\n') || (ch == '\r'))
            {
                break;
            }
            if (ch >= '0' && ch <= '9')
            {
                char nextChar = (char)ch;
                int digit = int.Parse(nextChar.ToString());

                sumDigit += digit;
            }

            while (sumDigit > 9)
            {
                int finalSum = 0;
                while (sumDigit > 0)
                {
                    int lastDigit = sumDigit % 10;
                    finalSum += lastDigit;
                    sumDigit = sumDigit / 10;
                }
                sumDigit = finalSum;
            }
        }
        Console.WriteLine(sumDigit);
    }
}

