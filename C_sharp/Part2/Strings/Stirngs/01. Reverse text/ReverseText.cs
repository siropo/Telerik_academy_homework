using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_text
{
    class ReverseText
    {
        public static string ReverseStr(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char ch = str[i];
                result.Append(ch);
            }
            return result.ToString();
        }

        static void Main(string[] args)
        {
            string nesho = "SDdasdSsada";

            Console.WriteLine(ReverseStr(nesho));
        }
    }
}
