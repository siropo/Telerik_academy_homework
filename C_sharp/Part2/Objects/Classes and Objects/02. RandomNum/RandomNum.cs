using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomNum
{
    class RandomNum
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine("{0}",randomNumber.Next(100,201));
            }
        }
    }
}
