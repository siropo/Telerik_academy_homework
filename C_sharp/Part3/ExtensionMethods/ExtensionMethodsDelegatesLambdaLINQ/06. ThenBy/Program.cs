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
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
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

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = 
            {
                new Student("Pesho", "Goshev", 15),
                new Student("Gosho", "Goshev", 31),
                new Student("Tincko", "Vestov", 12),
                new Student("Lubo", "Peshev", 22),
                new Student("Vesko", "Rubov", 12)
            };

            var sortStudents = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            foreach (var selectedStudent in sortStudents)
            {
                Console.WriteLine("{0} {1}", selectedStudent.FirstName, selectedStudent.LastName);
            }
        }
    }
}
