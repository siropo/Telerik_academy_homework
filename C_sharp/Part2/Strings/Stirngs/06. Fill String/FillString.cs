using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fill_String
{
    class FillString
    {
        public static string ReplaceText(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 21; i++)
            {
                if (i < str.Length)
                {
                    char ch = str[i];
                    result.Append(ch);
                }
                else
                {
                    char ch = '*';
                    result.Append(ch);
                }
                
            }

            return result.ToString();
        }

        static void Main()
        {
            string text = "peshodw  fdw  efef  dwa dwad wadwa dwad wdawdw";
            string replace = ReplaceText(text);
            Console.WriteLine(replace);
        }
    }
}
