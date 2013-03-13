using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolScope
{
    public class Student : Person, IComment
    {
        private int classNumber;
        private string additionalInfo;

        public Student(string firstName, string lastName, int classNumber)
            : this(firstName, lastName, classNumber, null) 
        {

        }

        public Student(string firstName, string lastName, int classNumber, string additionalInfo) 
            : base(firstName, lastName)
        {
            this.classNumber = classNumber;
            this.additionalInfo = additionalInfo;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                this.classNumber = value;
            }
        }

        public string AdditionalInfo
        {
            get
            {
                return this.additionalInfo;
            }
            set
            {
                this.additionalInfo = value;
            }
        }

        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();
            studentInfo.AppendFormat("\nStudent {0}", base.ToString());
            studentInfo.AppendFormat("\nUnique class number {0} ", this.classNumber);

            return studentInfo.ToString();
        }
    }
}
