using System;
using System.Linq;

//03.Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.

namespace _03.LINQFromArrayOfStudents
{
    class TestLINQ
    {
        static void Main(string[] args)
        {
            var students = new Student[]
            {
                new Student("Ivan","Ivanov"),
                new Student("Anna","Draganova"),
                new Student("Gosho","Petrov"),
                new Student("Yulian","Marinov"),
                new Student("Marin","Ivanov")
            };

            var foundStudents =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;
            Console.WriteLine("Students whose first name is before its last name alphabetically");
            foreach (var student in foundStudents)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
            }

            //with Lambda Expression
            //var resultLambda = students.Where(student => student.FirstName.CompareTo(student.LastName) == -1).Select(student => student);
            //foreach (var student in resultLambda)
            //{
            //    Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            //}
        }
    }
}
