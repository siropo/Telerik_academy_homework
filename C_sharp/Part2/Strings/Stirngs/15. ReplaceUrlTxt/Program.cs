using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ReplaceUrlTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            StringBuilder copyStr = new StringBuilder();
            copyStr.Append(str);

            bool isInUrl = false;
            int index = -1;
            int index2 = -1;
            List<string> originalUrl = new List<string>();
            List<string> replaceUrl = new List<string>();

            while (true)
            {
                index = str.IndexOf("<a href=\"", index + 1);
                index2 = str.IndexOf("</a>", index2 + 1);
                if (index != -1)
                {
                    isInUrl = true;
                    //int currentStartUrl = str.IndexOf("<a href=\"", index);
                    //int currentEndUrl = str.IndexOf("</a>", index2);
                    //Console.WriteLine(currentStartUrl + " " + currentEndUrl + " " + index);
                    int currentEnd = index2 - index;
                    string addUrl = str.Substring(index, currentEnd + 5);
                    originalUrl.Add(addUrl);
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < originalUrl.Count; i++)
            {
                Console.WriteLine(originalUrl[i]);
            }
            //Console.WriteLine(isInUrl);
        }
    }
}
