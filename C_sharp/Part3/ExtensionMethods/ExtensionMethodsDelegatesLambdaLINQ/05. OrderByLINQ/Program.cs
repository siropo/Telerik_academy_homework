using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StudentSortLINQ
{
    public class Student
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName)
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = 
            {
                new Student("Pesho", "Goshev"),
                new Student("Gosho", "Goshev"),
                new Student("Tincko", "Vestov"),
                new Student("Lubo", "Peshev"),
                new Student("Vesko", "Rubov")
            };

            var sortStudents =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var selectedStudent in sortStudents)
            {
                Console.WriteLine("{0} {1}", selectedStudent.FirstName, selectedStudent.LastName);
            }
        }
    }
}
