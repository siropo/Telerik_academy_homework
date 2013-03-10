using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Upper_Text
{
    class UpperText
    {
        public static string ReplaceText(string str)
        {
            string openTag = "<upcase>";
            string closeTag = "</upcase>";

            while (str.IndexOf(openTag) != -1)
            {
               
                int start = str.IndexOf(openTag);
                int end = str.IndexOf(closeTag);
                //Console.WriteLine(end - start - openTag.Length);
                string sub = str.Substring(start + openTag.Length, end - start - openTag.Length);
                str = str.Replace(openTag + sub + closeTag, sub.ToUpper());
            }

            return str;
        }

        static void Main()
        {
            string text = "dwaw waewa ewa <upcase>wae</upcase> hwai";
            string replace = ReplaceText(text);
            Console.WriteLine(replace);
        }
    }
}
