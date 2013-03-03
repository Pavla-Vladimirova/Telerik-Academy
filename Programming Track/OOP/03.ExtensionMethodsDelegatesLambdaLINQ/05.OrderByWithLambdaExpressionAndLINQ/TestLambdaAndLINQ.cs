using _03.LINQFromArrayOfStudents;
using System;
using System.Linq;

//05.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. 
//Rewrite the same with LINQ.

namespace _05.OrderByWithLambdaExpressionAndLINQ
{
    class TestLambdaAndLINQ
    {
        static void Main(string[] args)
        {
            var students = new Student[]
            {
                new Student("Ivan","Ivanov"),
                new Student("Ivan","Draganov"),
                new Student("Anna","Draganova"),
                new Student("Gosho","Petrov"),
                new Student("Yulian","Marinov"),
                new Student("Marin","Ivanov")
            };

            //with Lambda Expression
            var sortedStudentsWithLambda = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
            Console.WriteLine("Students sorted(with lambda expression)");
            foreach (var student in sortedStudentsWithLambda)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
            }
            Console.WriteLine();

            //with LINQ
            var sortedStudentsWithLinq =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;
            Console.WriteLine("Students sorted(with LINQ)");
            foreach (var student in sortedStudentsWithLinq)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
            }
        }
    }
}
