using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animals
{
    public class Tomcat : Cat, ISound
    {
        public Tomcat(int age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        public override string animalSound()
        {
            return "Miay Miay";
        }
    }
}
