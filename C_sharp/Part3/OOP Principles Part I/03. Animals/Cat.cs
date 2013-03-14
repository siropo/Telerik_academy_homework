using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animals
{
    public class Cat : Animal, ISound
    {
        public Cat(int age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        public override string animalSound()
        {
            return "Murr Murr";
        }
    }
}
