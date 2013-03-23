using System;
using System.Linq;

//01.Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone, e-mail, course,
//specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. 
//Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//02.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
//03.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).

namespace _01.Students
{
    class TestStudents
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Ivan", "Ivanov", "Geogriev","002-21-23","Sofia,Bulgaria","088888888","ivan@iv.bg",3,
                University.SofiaUniversity,Faculty.MathematicsAndInformatics,Specialty.ComputerScience);
            Student secondStudent = new Student("Deyan", "Ivanov", "Geogriev", "002-61-51", "Sofia,Bulgaria", "098888988", "deyan@de.bg", 3,
                University.SofiaUniversity, Faculty.MathematicsAndInformatics, Specialty.ComputerScience);

            //Equals
            Console.WriteLine(firstStudent.Equals(secondStudent)? "Students are equal" : "Students are not equal");
            Console.WriteLine();

            //== !=
            Console.WriteLine("== {0}",firstStudent==secondStudent);
            Console.WriteLine("!= {0}", firstStudent != secondStudent);
            Console.WriteLine();

            //ToString
            Console.WriteLine(firstStudent);

            //GetHashCode
            Console.WriteLine("Hash code of the first student: " + firstStudent.GetHashCode());
            Console.WriteLine();

            //Deep copy
            Student cloned = firstStudent.Clone();
            cloned.MobilePhone = "CHANGED Number";
            Console.WriteLine("CLONED :");
            Console.WriteLine(cloned);

            //Compare
            Console.WriteLine("Comparing first student to second one:");
            Console.WriteLine(firstStudent.CompareTo(secondStudent));
            Console.WriteLine();
        }
    }
}
