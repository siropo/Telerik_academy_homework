using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ReplaceText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework PHP 4.0 and is implemented as a dynamic language in CLR.";
            string[] textToReplace = { "Microsoft", "PHP", ".NET" };
            string[] textStar = new string[textToReplace.Length];

            StringBuilder newStr = new StringBuilder();
            char[] charText = text.ToCharArray();

            int count = 0;
            newStr.Append(text);
            for (int i = 0; i < textToReplace.Length; i++)
            {
                StringBuilder star = new StringBuilder();
                for (int j = 0; j < textToReplace[i].Length; j++)
			    {
                    star.Append("*");
			    }
                textStar[i] = star.ToString();
            }

            for (int i = 0; i < textToReplace.Length; i++)
            {
                newStr.Replace(textToReplace[i], textStar[i]);
            }
            

                int index = -1;
                while (true)
                {
                    index = text.IndexOf(textToReplace[1], index + 1);
                    if (index == -1)
                    {
                        break;
                    }
                    count++;
                }



                Console.WriteLine(newStr);
        }
    }
}
