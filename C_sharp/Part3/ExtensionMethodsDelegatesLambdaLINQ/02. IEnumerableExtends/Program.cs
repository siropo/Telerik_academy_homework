using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtends
{
    public static class ExtendIEnumerable
    {
        public static T Sum<T>(this IEnumerable<T> arr)
        {
            dynamic sum = 0;
            foreach (var element in arr)
            {
                sum += element;
            }
            return sum;
        }

        public static T Max<T>(this IEnumerable<T> arr)
        {
            dynamic max = long.MinValue;
            foreach (var element in arr)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        public static T Min<T>(this IEnumerable<T> arr)
        {
            dynamic min = long.MaxValue;
            foreach (var element in arr)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }

        public static T Product<T>(this IEnumerable<T> arr)
        {
            dynamic product = 1;

            foreach (var element in arr)
            {
                product *= element;
            }

            return product;
        }

        public static decimal Average<T>(this IEnumerable<T> arr)
        {
            dynamic sum = 0;
            dynamic count = 0;

            foreach (var element in arr)
            {
                sum += element;
                count++;
            }
            sum = sum / count;
            return sum;
        }
    }

    class Program
    {
        static void Main()
        {
            int[] myarr = { 3, 5, 3, 15 };

            Console.WriteLine(myarr.Sum());
            Console.WriteLine(myarr.Max());
            Console.WriteLine(myarr.Min());
            Console.WriteLine(myarr.Product());
            Console.WriteLine(myarr.Average());

            for (int i = 0; i < myarr.Length; i++)
            {
                Console.Write(myarr[i] + " ");
            }

        }
    }
}
