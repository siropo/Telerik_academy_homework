using System;

class PrimeNumbers
{
    static void Main()
    {
        byte numprime = 100;

        for (byte i = 2; i <= numprime; i++)
        {

            bool prime = true;

            for (byte j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    // Console.WriteLine(i + "%" + j + " = " + i % j);
                    prime = false;
                }
            }

            if (prime)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}

