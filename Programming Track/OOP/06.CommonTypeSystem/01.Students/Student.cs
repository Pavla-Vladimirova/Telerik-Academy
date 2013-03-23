using System;
using System.Linq;

namespace _01.Students
{
    public class Student : ICloneable,IComparable<Student>
    {
        public string FirstName {get;private set;}
        public string MiddleName  {get;private set;}
        public string LastName  {get; private set;}
        public string SSN { get; private set; }
        public string Address { get; set; }
        public string MobilePhone  {get;set;}
        public string Email { get; set; }
        public int Course { get; set; }
        public University StudentUniversity { get; private set; }
        public Faculty StudentFaculty { get; private set; }
        public Specialty StudentSpecialty { get; private set; }

        public Student(string firstName, string middleName, string lastName, string ssn, string address, string mobilePhone, string email, int course, University studentUniversity, Faculty studentFaculty, Specialty studentSpecialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.StudentUniversity = studentUniversity;
            this.StudentFaculty = studentFaculty;
            this.StudentSpecialty = studentSpecialty;
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student==null)
            {
                return false;
            }
            else if (!Object.Equals(this.SSN,student.SSN))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override string ToString()
        {
            return String.Format("Student:\n Name: {0} {1} {2};\n SSN: {3};\n Address: {4};\n Mobile: {5};\n Email: {6};\n University: {7};\n Faculty: {8};\n Specialty: {9};\n Course: {10};\n",
                this.FirstName,this.MiddleName,this.LastName,this.SSN,this.Address,this.MobilePhone,this.Email,this.StudentUniversity,this.StudentFaculty,this.StudentSpecialty,this.Course);
        }

        public override int GetHashCode()
        {
            return (this.FirstName.GetHashCode() * this.LastName.GetHashCode()) ^ this.SSN.GetHashCode();
        }

        object ICloneable.Clone() 
        {
            return this.Clone();
        }

        public Student Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone, this.Email, this.Course, this.StudentUniversity, this.StudentFaculty, this.StudentSpecialty);
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName)!=0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            else if (this.MiddleName.CompareTo(other.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            else if (this.LastName.CompareTo(other.LastName) != 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            else if (this.SSN.CompareTo(other.SSN)!=0)
            {
                return this.SSN.CompareTo(other.SSN);
            }
            else
            {
                return 0;
            }
        }
    }
}
