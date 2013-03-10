using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintToday
{
    class PrintToday
    {
        static void Main()
        {
            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);
        }
    }
}
