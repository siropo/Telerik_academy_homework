using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CheckNeigbords
{
    class CheckNeighbords
    {
        static void CheckNumIsBigOrSmall(int[] arr, int position)
        {
            int start = 0;
            int end = arr.Length - 1;
            string result = "Position is ";

            if (position == start)
            {
                if (arr[1] > arr[0])
                {
                    result += " arr[" + position + "] is <  arr[" + (position + 1) + "]\n";
                }
                else if (arr[1] == arr[0])
                {
                    result += " arr[" + position + "] is = arr[" + (position + 1) + "]\n";
                }
                else
                {
                    result += " arr[" + position + "] is >  arr[" + (position + 1) + "]\n";
                }
            }
            else if (position == end)
            {
                if (arr[end] > arr[end - 1])
                {
                    result += " arr[" + position + "] is >  arr[" + (position - 1) + "]\n";
                }
                else if (arr[end] == arr[end - 1])
                {
                    result += " arr[" + position + "] is = arr[" + (position - 1) + "]\n";
                }
                else
                {
                    result += " arr[" + position + "] is <  arr[" + (position - 1) + "]\n";
                }
            }
            else if (position < end && position > start)
            {
                if (arr[position] > arr[position - 1])
                {
                    result += " arr[" + position + "] is >  arr[" + (position - 1) + "]\n";
                }
                else if (arr[position] == arr[position - 1])
                {
                    result += " arr[" + position + "] is = arr[" + (position - 1) + "]\n";
                }
                else
                {
                    result += " arr[" + position + "] is <  arr[" + (position - 1) + "]\n";  
                }

                Console.WriteLine();
                if (arr[position] > arr[position + 1])
                {
                    result += " arr[" + position + "] is >  arr[" + (position + 1) + "]\n";
                }
                else if (arr[position] == arr[position + 1])
                {
                    result += " arr[" + position + "] is = arr[" + (position + 1) + "]\n";
                }
                else
                {
                    result += " arr[" + position + "] is <  arr[" + (position + 1) + "]\n";
                }
            }
            else
            {
                result += " out if array";
            }

            Console.WriteLine(result);
        }

        static void Main()
        {
            int[] arrNum = {1, 2, 2, 4};
            Console.WriteLine("Enter position = ");
            int pos = int.Parse(Console.ReadLine());
            CheckNumIsBigOrSmall(arrNum, pos);
        }
    }
}
