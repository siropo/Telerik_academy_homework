using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.isLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(year) ? "Year is leap" : "Year is not leap");
        }
    }
}
