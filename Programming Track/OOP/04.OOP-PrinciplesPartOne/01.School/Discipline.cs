using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Discipline : ICommentable
    {
        public string Name { get; private set; }
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                this.numberOfExercises = value;
            }
        }

        public string Comment()
        {
            return string.Format("Comment about {0}(discipline)",this.Name);
        }

        public override string ToString()
        {
            return string.Format("\n  Name: {0}; \n  Number of lectures: {1}; \n  Number of exercises: {2}; \n  Comments: {3};",this.Name,this.NumberOfLectures,this.NumberOfExercises,this.Comment());
        }
    }
}
