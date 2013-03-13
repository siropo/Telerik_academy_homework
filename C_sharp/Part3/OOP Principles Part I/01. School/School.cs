using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolScope
{
    public class School
    {
        private string name;
        private List<SchoolClasses> schoolClasses;

        public School(string name, List<SchoolClasses> schoolClasses)
        {
            this.name = name;
            this.schoolClasses = schoolClasses;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public override string ToString()
        {
            StringBuilder schoolInfo = new StringBuilder();
            schoolInfo.AppendFormat("School Name: {0}", this.name);
            foreach (SchoolClasses schoolClass in this.schoolClasses)
            {
                schoolInfo.AppendFormat("\n{0}", schoolClass.ToString());
            }
            return schoolInfo.ToString();
        }
    }
}
