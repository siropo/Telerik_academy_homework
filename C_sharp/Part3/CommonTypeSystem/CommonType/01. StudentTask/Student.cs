using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentTask
{
    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public uint SSN { get; set; }
        public string PermanentAddress { get; set; }
        public uint MobilePhone { get; set; }
        public string EMail { get; set; }
        public byte Course { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }
        public Specialties Specialty { get; set; }

        //Constructor
        public Student(string firstName, string middleName, string lastName, uint ssn, string permanentAddress,
            uint mobilePhone, string eMail, byte course, Universities university, Faculties faculty, Specialties specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.EMail = eMail;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        //Methods
        public override bool Equals(object param)
        {
            Student student = param as Student;

            if ((object)student == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (this.MiddleName != student.MiddleName)
            {
                return false;
            }
            if (this.LastName != student.LastName)
            {
                return false;
            }
            if (this.SSN != student.SSN)
            {
                return false;
            }
            return true;
        }
        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ SSN.GetHashCode();
        }
        public override string ToString()
        {
            return String.Format("Student: {0} {1} {2} \nSSN: {3}, \nAdress : {4}, \nPhone : {5}, \nE-mail : {6}, \nstudent in : {7} {8}, \nspecialty : {9}, \ncourse : {10}",
                this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, this.MobilePhone, this.EMail,
                this.University, this.Faculty, this.Specialty, this.Course);
        }

        public Student Clone()
        {
            Student newStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress,
                this.MobilePhone, this.EMail, this.Course, this.University, this.Faculty, this.Specialty);
            return newStudent;
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName != otherStudent.FirstName)
            {
                return (string.Compare(this.FirstName, otherStudent.FirstName));
            }
            if (this.MiddleName != otherStudent.MiddleName)
            {
                return (string.Compare(this.MiddleName, otherStudent.MiddleName));
            }
            if (this.LastName != otherStudent.LastName)
            {
                return (string.Compare(this.LastName, otherStudent.LastName));
            }
            if (this.SSN != otherStudent.SSN)
            {
                return (int)(this.SSN - otherStudent.SSN);
            }
            return 0;
        }
    }

}
