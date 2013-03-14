using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.People
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value != string.Empty)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("Username cannot be empty");
                }
                
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
            StringBuilder humanInfo = new StringBuilder();
            humanInfo.AppendFormat("HUMAN");
            humanInfo.AppendFormat("\nFirst Name{0}", this.FirstName);
            humanInfo.AppendFormat("\nLast Name : {0}", this.LastName);
            return humanInfo.ToString();
        }
    }
}
