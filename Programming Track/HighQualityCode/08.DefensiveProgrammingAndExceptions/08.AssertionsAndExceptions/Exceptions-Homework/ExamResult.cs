using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentException("The grade of ExamResult cannot be negative number");
        }
        if (minGrade < 0)
        {
            throw new ArgumentException("The minimum grade of ExamResult cannot be negative number");
        }
        if (maxGrade < 0)
        {
            throw new ArgumentException("The maximum grade of ExamResult cannot be negative number");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("The maximum grade of ExamResult must be bigger than the minimum grade");
        }
        if (comments == null)
        {
            throw new NullReferenceException("The comments of ExamResult does nto refer to any object");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
