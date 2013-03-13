using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolScope
{
    public class SchoolClasses
    {
        private string name;
        private List<Teacher> teachers;
        private List<Student> students;

        public SchoolClasses(string name, List<Teacher> teachers, List<Student> students)
        {
            this.name = name;
            this.teachers = teachers;
            this.students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = name;
            }
        }

        public override string ToString()
        {
            StringBuilder schoolClassInfo = new StringBuilder();

            schoolClassInfo.AppendFormat("Class {0}:", this.name);

            schoolClassInfo.Append("\n\nStudents:");

            foreach (Student student in this.students)
            {
                schoolClassInfo.AppendFormat("\n{0}", student);
            }

            schoolClassInfo.Append("\n\nTeachers:");

            foreach (Teacher teacher in this.teachers)
            {
                schoolClassInfo.AppendFormat("\n{0}", teacher);
            }

            return schoolClassInfo.ToString();
        }
    }
}
