using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Reverse_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C# is not C++ and PHP is not Delphi";
            string[] strSplit = str.Split(' ');

            for (int i = strSplit.Length-1; i >= 0; i--)
            {
                Console.Write(strSplit[i] + " ");
            }
        }
    }
}
