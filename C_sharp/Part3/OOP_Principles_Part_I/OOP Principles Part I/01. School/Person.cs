using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolScope
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;

        protected Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName; 
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder personInfo = new StringBuilder();
            personInfo.AppendFormat("\n First Name: {0} ", this.firstName);
            personInfo.AppendFormat("\n Last Name: {0} ", this.lastName);

            return personInfo.ToString();

        }
    }
}
