using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Animals;

namespace _03.AnimalsDemo
{
    class Program
    {
        static void Main()
        {
            Dog sharo = new Dog(3, "Sharo", Sex.Female);
            Frog pesho = new Frog(9, "Pesho", Sex.Female);

            Animal[] animals = { sharo, pesho };

            Console.WriteLine(pesho.animalSound());

            Console.WriteLine(Animal.AverageAge(animals));
        }
    }
}
