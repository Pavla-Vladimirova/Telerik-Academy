using _03.LINQFromArrayOfStudents;
using System;
using System.Linq;

//04.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace _04.LINQFromArrayOfStudentsAge
{
    class TestLINQ
    {
        static void Main(string[] args)
        {
            var students = new Student[]
            {
                 new Student("Ivan","Ivanov",12),
                new Student("Anna","Draganova",18),
                new Student("Gosho","Petrov",23),
                new Student("Yulian","Marinov",25),
                new Student("Marin","Ivanov",20)
            };

            var foundStudents =
                from student in students
                where (student.Age >= 18 && student.Age <= 24)
                select student;
            Console.WriteLine("Students age(18-24)");
            foreach (var student in foundStudents)
            {
                Console.WriteLine("{0} {1} age: {2}", student.FirstName, student.LastName,student.Age);
            }

            //with Lambda Expression
            //var result = students.Where(student => student.Age >= 18 && student.Age <= 24).Select(student => student);
            //foreach (var student in result) 
            //{
            //    Console.WriteLine("{0} {1} age: {2}", student.FirstName, student.LastName, student.Age);
            //}
        }
    }
}
