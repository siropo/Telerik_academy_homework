using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolScope
{
    public class Teacher : Person, IComment
    {
        private List<Disciplines> disciplines;
        private string additionalInfo;

        public Teacher(string firstName, string lastName, List<Disciplines> disciplines)
            : this(firstName, lastName, disciplines, null)
        {
           
        }

        public Teacher(string firstName, string lastName, List<Disciplines> disciplines, string additionalInfo)
            : base(firstName, lastName)
        {
            this.disciplines = new List<Disciplines>(disciplines);
            this.additionalInfo = additionalInfo;
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
            StringBuilder teacherInfo = new StringBuilder();

            teacherInfo.AppendFormat("\nTeacher: {0}", base.ToString());

            teacherInfo.Append("\nCourses:");

            foreach (Disciplines item in this.disciplines)
            {
                teacherInfo.AppendFormat("\r\n{0}", item);
            }

            return teacherInfo.ToString();
        }

    }
}
