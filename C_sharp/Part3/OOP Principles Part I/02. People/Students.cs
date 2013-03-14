using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.People
{
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade) :
            base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value > 0)
                {
                    this.grade = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();
            studentInfo.AppendFormat("{0}", base.ToString());
            studentInfo.AppendFormat("\nSTUDENT");
            studentInfo.AppendFormat("\nGrade: {0}", this.Grade);
            studentInfo.AppendFormat("\n\n");
            return studentInfo.ToString();
        }
    }
}
