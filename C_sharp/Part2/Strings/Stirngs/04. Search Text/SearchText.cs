using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Search_Text
{
    class SearchText
    {
        static void FindTxt(string str, string findPart)
        {
            int count = 0;
            str = str.ToLower();
            int found = 0;
            found = str.IndexOf(findPart);
            //Console.WriteLine(str.Length);
            for (int i = found; i < str.Length; i++)
            {
                if (found != -1)
                {
                    found = str.IndexOf(findPart, i + 1);
                    count++;
                    //Console.WriteLine(count);
                    i = found;
                }
            }

            Console.WriteLine(count);
        }

        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string textToFind = "ysds";
            FindTxt(text, textToFind);
            Console.WriteLine();
        }
    }
}
