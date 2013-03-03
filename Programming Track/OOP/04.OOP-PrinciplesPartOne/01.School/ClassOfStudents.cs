using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class ClassOfStudents : ICommentable
    {
        private List<Student> listOfStudents;
        private Teacher teacher;
        public string ClassIdentifier { get; private set; }
      
        public ClassOfStudents(List<Student> listOfStudents, Teacher techer, string classIdentifier)
        {
            this.ListOfStudents = listOfStudents;
            this.Teacher = techer;
            this.ClassIdentifier = classIdentifier;
        }

        public List<Student> ListOfStudents
        {
            get
            {
                return this.listOfStudents;
            }
            set
            {
                this.listOfStudents = value;
            }
        }

        public Teacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        public string Comment()
        {
            return string.Format("Comment about class");
        }

        public void PrintClass()
        {
            Console.WriteLine("Class identifier: {0}",this.ClassIdentifier);
            Console.WriteLine("Comments: {0}\n",this.Comment());
            Console.WriteLine("Class teacher: {0}",this.Teacher);
            foreach (var discipline in Teacher.ListOfDisciplines)
            {
                Console.WriteLine(" Discipline: {0}",discipline);
            }
            Console.WriteLine("\nStudents:");
            foreach (var student in this.ListOfStudents)
            {
                Console.WriteLine(" Student: {0}",student);
            }
        }

        public Student Student
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal Teacher Teacher1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
