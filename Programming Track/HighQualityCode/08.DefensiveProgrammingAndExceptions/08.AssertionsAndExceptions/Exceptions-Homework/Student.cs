using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public IList<Exam> Exams { get; private set; }

    public Student(string firstName, string lastName, IList<Exam> exams)
    {
        if (firstName == null)
        {
            throw new NullReferenceException("The input first name does not refer to any object");
        }

        if (lastName == null)
        {
            throw new NullReferenceException("The input last name does not refer to any object");
        }

        if (this.Exams == null)
        {
            throw new NullReferenceException("The list of exams of the student does nto refer to any object");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentException("The list of exams of the student is empty(it has zero exams)");
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    //The "set" to Exams is set to private and tha data is already checked - in the constructor so there is no need to check it again in these methods

    public IList<ExamResult> CheckExams()
    {
        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
