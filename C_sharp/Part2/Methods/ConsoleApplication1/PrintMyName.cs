using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PrintMyName
    {
        static void PrintName(string name)
        {
            Console.WriteLine("Your name {0}", name);
        }

        static void Main(string[] args)
        {
            string myName = Console.ReadLine();

            PrintName(myName);
        }
    }
}
