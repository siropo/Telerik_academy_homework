using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_digits_count
{
    class DigitCount
    {
        static void Main(string[] args)
        {
            byte B = byte.Parse(Console.ReadLine());
            short N = short.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int count = 0;
                uint number = uint.Parse(Console.ReadLine());
                while (number != 0) 
                {
                    if ((number & 1) == B)
                    {
                        count++;
                    }
                    number = number >> 1;
                }
                Console.WriteLine(count);
            }
            
        }
    }
}
