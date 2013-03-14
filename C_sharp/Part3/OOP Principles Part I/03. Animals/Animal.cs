using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animals
{
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private Sex sex;

        protected Animal(int age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.AnimalSex = sex;
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Sex AnimalSex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        public abstract string animalSound();

        public static double AverageAge(Animal[] animals)
        {
            double total = 0;
            int allAnimals = animals.Length;
            for (int i = 0; i < allAnimals; i++)
            {
                total += animals[i].Age;
            }

            return total / (double)allAnimals;
        }
    }
}
