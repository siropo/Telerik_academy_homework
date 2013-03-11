using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Extend_StringBuilder
{
    public static class SubStringStreamBilder
    {
        public static StringBuilder SubString(this StringBuilder str, int startIntex, int endIndex)
        {
            StringBuilder subStr = new StringBuilder();

            endIndex = startIntex + endIndex;

            for (int i = startIntex; i < endIndex; i++)
            {
                subStr.Append(str[i]);
            }

            return subStr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pesho = new StringBuilder();
            pesho.AppendLine("hello");
            Console.WriteLine(pesho.SubString(0,2));
        }
    }
}
