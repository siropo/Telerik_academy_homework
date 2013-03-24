using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Student pesho = new Student("Pesho", "Goshev", "Peshev", 123456, "P. Karevelov 29", 088228822,
            "pesh0@gamail.com", 2, Universities.NewBulgarianUniversity, Faculties.EPU, Specialties.History);

            Console.WriteLine(pesho);

            Student gosho = pesho.Clone();
            Console.WriteLine(gosho);
            gosho.FirstName = "Gosho";
            Console.WriteLine(gosho.FirstName);
            Console.WriteLine(pesho.FirstName);
            Console.WriteLine();

            Console.WriteLine(pesho.CompareTo(gosho));
            gosho.FirstName = "Pesho";
            Console.WriteLine(pesho.CompareTo(gosho));

            Console.WriteLine(pesho.Equals(gosho));
            gosho.FirstName = "Gosho";
            Console.WriteLine(pesho.Equals(gosho));
            Console.WriteLine(pesho.FirstName != gosho.FirstName);
        }
    }
}
