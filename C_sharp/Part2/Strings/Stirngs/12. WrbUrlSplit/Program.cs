using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.WrbUrlSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.devbg.org/forum/index.php";

            
            string[] urlSprit = url.Split(new string[] {"://"}, StringSplitOptions.RemoveEmptyEntries);

            int findFirstLine = urlSprit[1].IndexOf('/');

            string getUrl = urlSprit[1].Substring(0, findFirstLine);
            string getDirectory = urlSprit[1].Substring(findFirstLine);

            Console.WriteLine(getDirectory);
        }
    }
}
