using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03__PrintLastNum
{
    class PrintLastNum
    {
        static void PrintLast(uint a)
        {
            string aString = a.ToString();
            char last = aString[aString.Length - 1];

            int numLast = int.Parse(last.ToString());
            
            switch (numLast)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default: Console.WriteLine("Please enter number from 0 to 9");
                    break;
            }
        }

        static void Main()
        {
            Console.Write("a = ");
            string line = Console.ReadLine();

            uint a = uint.Parse(line);

            PrintLast(a);
        }
    }
}
