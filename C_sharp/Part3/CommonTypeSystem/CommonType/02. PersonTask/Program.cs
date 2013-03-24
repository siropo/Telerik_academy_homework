using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PersonTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho");
            Person gosho = new Person("Gosho", 22);
            Person sasho = new Person("Sasho");
            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
            Console.WriteLine(sasho);
        }
    }
}
