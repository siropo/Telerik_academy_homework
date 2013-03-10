using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Compare_arrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int[] arrNumbers1 = new int[4];
            int[] arrNumbers2 = new int[4];

            Console.WriteLine("Enter 3 numbers for array 1");
            for (int i = 1; i < arrNumbers1.Length; i++)
            {
                arrNumbers1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter 3 numbers for array 2");
            for (int i = 1; i < arrNumbers2.Length; i++)
            {
                arrNumbers2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < arrNumbers1.Length; i++)
            {
                if (arrNumbers1[i] == arrNumbers2[i])
                {
                    Console.WriteLine("element {0} in arrNumbers1[{1}] is equals on element {0} in arrNumbers2[{2}]", i, arrNumbers1[i], arrNumbers2[i]);
                }
            }
        }
    }
}
