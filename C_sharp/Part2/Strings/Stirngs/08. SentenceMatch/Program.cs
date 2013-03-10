using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SentenceMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string allTxt = "We are living in a yellow submarine. We don’t have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string match = "We";

            string[] splitTxt = allTxt.Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitTxt.Length; i++)
            {
                if (splitTxt[i].Contains(match))
                {
                    Console.WriteLine(splitTxt[i].Trim());
                }
                
            }
        }
    }
}
