using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_majority_multiple
{
    class List
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int max = 100 * 100 * 100;

            for (int i = 4; i < max; i++)
            {
                int divsCount = 0;
                if (i % a == 0)
                {
                    divsCount++; 
                }
                if (i % b == 0)
                {
                    divsCount++;
                }
                if (i % c == 0)
                {
                    divsCount++;
                }
                if (i % d == 0)
                {
                    divsCount++;
                }
                if (i % e == 0)
                {
                    divsCount++;
                }
                if (divsCount >= 3) 
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}
