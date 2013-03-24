using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PersonTask
{
    public class Person
    {
        private string name;
        private int? age;

        //Constructor
        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int? Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The age must be > 0!");
                }
                this.age = value;
            }
        }

        //Methods
        public override string ToString()
        {
            string ageOutput;
            if (this.Age == null)
            {
                ageOutput = "Unknown age";
            }
            else
            {
                ageOutput = this.Age.ToString();
            }
            return string.Format("Name: {0}\nAge: {1}\n", this.Name, ageOutput);
        }
    }
}
