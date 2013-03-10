using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forestRoad
{
    class forestRoad
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool star = true;
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (star && count == j)
                    {
                        Console.Write('*');
                        star = false;
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                count++;
                star = true;
                Console.WriteLine();
            }
            count = 1;
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (star && count == j)
                    {
                        Console.Write('*');
                        star = false;
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                count++;
                star = true;
                Console.WriteLine();
            }
        }
    }
}
