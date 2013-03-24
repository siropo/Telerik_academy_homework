using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.People;

namespace _02.PeopleDemo
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Pesho", "Ivanov", 4),
                new Student("Vesko", "Peshev", 41),
                new Student("Lucho", "Gushev", 5),
                new Student("Pesho", "Ivanov", 4),
                new Student("Vuicho", "Peshev", 41),
                new Student("Lucho", "Gushev", 5),
                new Student("Pesho", "Ivanov", 4),
                new Student("Mecho", "Peshev", 41),
                new Student("Lucho", "Rubev", 5),
                new Student("Pucho", "Gushev", 5)
            };

            List<Worker> workers = new List<Worker>
            {
                new Worker("Macho", "Goshev", 200, 5),
                new Worker("Petio", "Gurov", 30000, 7),
                new Worker("Micho", "Chushkov", 400, 8),
                new Worker("Macho", "Goshev", 200, 5),
                new Worker("Petio", "Gurov", 30000, 7),
                new Worker("Micho", "Chushkov", 400, 8),
                new Worker("Macho", "Goshev", 200, 5),
                new Worker("Petio", "Gurov", 30000, 7),
                new Worker("Micho", "Chushkov", 400, 8),
                new Worker("Micho", "Chushkov", 400, 8)
            };

            var orderStudents = from student in students
                                orderby student.Grade ascending
                                select student;
            /*
            foreach (var student in orderStudents)
            {
                Console.WriteLine(student);
            }
            */
            var orderWorkers = from worker in workers
                                orderby worker.MoneyPerHour() descending
                                select worker;
            /*
            foreach (var worker in orderWorkers)
            {
                Console.WriteLine(worker);
            }
            */
            List<Human> humansStudents = new List<Human>(students);
            List<Human> humansWorkers = new List<Human>(workers);

            List<Human> humans = humansStudents.Concat(humansWorkers).ToList();

            var orderHumans = from human in humans
                              orderby human.FirstName ascending, human.LastName ascending
                              select human;

            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
