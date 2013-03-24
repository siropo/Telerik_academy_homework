using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animals
{
    public class Frog : Animal, ISound
    {
        public Frog(int age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        public override string animalSound()
        {
            return "Kriak Kriak";
        }
    }
}
