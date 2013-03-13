using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolScope;

namespace SchoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Disciplines> teacherPeshoDisciplines = new List<Disciplines>
            {
                new Disciplines("C#", 3, 4, "hgfsdfsdf"),
                new Disciplines("PHP", 1, 2)
            };

            List<Disciplines> teacherLelqDisciplines = new List<Disciplines>
            {
                new Disciplines("C#", 3, 4, "hgfsdfsdf"),
                new Disciplines("PHP", 1, 2)
            };

            Teacher teacherPesho = new Teacher("Pesho", "Ivanov", teacherPeshoDisciplines);
            Teacher teacherLelq = new Teacher("Lelq", "Peshva", teacherLelqDisciplines);

            Student studentChocho = new Student("Chocho", "Goshev", 111);
            Student studentLucho = new Student("Lucho", "Peshev", 1111);

            List<Teacher> donatelloTeachers = new List<Teacher>
            {
                teacherPesho,
                teacherLelq
            };

            List<Student> donatelloStudents = new List<Student>
            {
                studentChocho,
                studentLucho
            };

            List<SchoolClasses> donatello = new List<SchoolClasses>
            {
                new SchoolClasses("donatelo", donatelloTeachers, donatelloStudents)
            };

            School telerik = new School("Telerik", donatello);

            Console.WriteLine(telerik.ToString());
        }
    }
}
