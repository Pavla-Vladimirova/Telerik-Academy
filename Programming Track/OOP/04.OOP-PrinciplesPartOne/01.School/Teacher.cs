using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Teacher : Person, ICommentable
    {
        private List<Discipline> listOfDisciplines;

        public Teacher(string name, int age, List<Discipline> listOfDisciplines) : base(name, age)
        {
            this.ListOfDisciplines = listOfDisciplines;
        }

        public List<Discipline> ListOfDisciplines
        {
            get
            {
                return this.listOfDisciplines;
            }
            set
            {
                this.listOfDisciplines = value;
            }
        }

        public string Comment()
        {
            return string.Format("Comment about {0}(teacher)",this.Name);
        }

        public override string ToString()
        {
            return string.Format("\n Name: {0}; \n Age: {1}; \n Comments: {2}; \n List of disciplines: ",this.Name,this.Age,this.Comment());
        }
    }
}
