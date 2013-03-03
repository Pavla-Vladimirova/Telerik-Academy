using System;
using System.Collections.Generic;
using System.Linq;

//02Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade.
//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour()
//that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Intialize a list of 10 workers and sort them by money per hour in descending order. Merge the lists and sort them by first name and last name.

namespace _02.AbstractHuman
{
    public class TestClass
    {
        static void Main(string[] args)
        {
            //Students
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("Peter", "Petrov", 7));
            listOfStudents.Add(new Student("Georgi", "Petrov", 9));
            listOfStudents.Add(new Student("Peter", "Ivanov", 4));
            listOfStudents.Add(new Student("Boris", "Draganov", 2));
            listOfStudents.Add(new Student("Dragan", "Petkov", 1));
            listOfStudents.Add(new Student("Cvetan", "Boyanov", 10));
            listOfStudents.Add(new Student("Yulian", "Borisov", 6));
            listOfStudents.Add(new Student("Mihail", "Cvetanov", 12));
            listOfStudents.Add(new Student("Atanas", "Penchev", 11));
            listOfStudents.Add(new Student("Andrei", "Ivanov", 11));

            var sortedStudents=listOfStudents.OrderBy(student => student.Grade);
            Console.WriteLine("Sorted students by grade(ascending):\n");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //Workers
            List<Worker> listOfWorkers = new List<Worker>();
            listOfWorkers.Add(new Worker("Ivan", "Petrov", 120, 6.5));
            listOfWorkers.Add(new Worker("Georgi", "Ivanov", 150, 7.5));
            listOfWorkers.Add(new Worker("Petra", "Ivanov", 120, 5.5));
            listOfWorkers.Add(new Worker("Borisa", "Draganov", 100, 4));
            listOfWorkers.Add(new Worker("Dragana", "Petkova", 80, 4));
            listOfWorkers.Add(new Worker("Cvetelina", "Boyanova", 320, 10));
            listOfWorkers.Add(new Worker("Yulian", "Borisov", 190, 7.5));
            listOfWorkers.Add(new Worker("Misha", "Cvetanova", 110, 4.5));
            listOfWorkers.Add(new Worker("Atanas", "Penchev", 145, 7));
            listOfWorkers.Add(new Worker("Andrei", "Ivanov", 135, 6));

            var sortedWorkers =
                from worker in listOfWorkers
                orderby worker.MoneyPerHour() descending
                select worker;
            Console.WriteLine("Sorted workers by money per hour(descending):\n");
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            //merge list
            Console.WriteLine("Merged lists(sorted by names):\n");
            var merged = listOfStudents.Union<Human>(listOfWorkers).ToList();
            var sortedMegre = merged.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);
            foreach (var item in sortedMegre)
            {
                Console.WriteLine(item);
            }
        }
    }
}
