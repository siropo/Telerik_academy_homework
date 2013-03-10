using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_text
{
    class ReverseText
    {
        public static string CheckBrackets(string str)
        {
            bool isValid = true;
            int countBrackets = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    countBrackets++;
                }
                if (str[i] == ')')
                {
                    countBrackets--;
                }
            }

            if (countBrackets != 0)
            {
                isValid = false;
            }
            return isValid.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CheckBrackets("((a + b) / 5 - d("));
            Console.WriteLine(CheckBrackets("((a+b))"));
        }
    }
}
