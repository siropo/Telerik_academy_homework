using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Compare_Chars
{
    class CompareChars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first char elements:");
            string firstChars = Console.ReadLine();
            char[] firstArray = firstChars.ToCharArray();
            int firstArrayLength = firstArray.Length;  

            Console.WriteLine("Enter the second char elements:");
            string secondChars = Console.ReadLine();
            char[] secondArray = secondChars.ToCharArray();
            int secondArrayLength = secondArray.Length;

            int minLen = Math.Min(secondArrayLength, firstArrayLength); 

            bool equalCharArrays = true; 

            for (int i = 0; i < minLen; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    continue;
                }
                else
                {
                    equalCharArrays = false;
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine("The first char array is lexicografically before the second.");
                    }
                    else
                    {
                        Console.WriteLine("The second char array is lexicografically before the first.");
                    }
                    break;
                }
            }
            if (equalCharArrays == true && firstArrayLength < secondArrayLength)
            {
                Console.WriteLine("The first char array is lexicografically before the second.");
            }
            else if (equalCharArrays == true && firstArrayLength > secondArrayLength)
            {
                Console.WriteLine("The second char array is lexicografically before the first.");
            }
            else if (equalCharArrays == true && firstArrayLength == secondArrayLength)
            {
                Console.WriteLine("The arrays are equal.");
            }
        }
    }
}
