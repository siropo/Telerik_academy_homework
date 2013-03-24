using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animals
{
    public class Dog : Animal, ISound
    {
        public Dog(int age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        public override string animalSound()
        {
            return "Bay Bay";
        }
    }
}
