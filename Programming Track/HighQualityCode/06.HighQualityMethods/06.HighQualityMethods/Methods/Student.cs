using System;

class Student
{
    private string firstName;
    private string lastName;
    private string otherInfo;

    public string FirstName
    {
        get 
        { 
            return firstName;
        }
        set 
        {
            if (value!=null && value!=string.Empty)
            {
                firstName = value;
            }
            else
            {
                throw new ArgumentException("The input first name is either null or empty string!");
            }
        }
    }

    public string LastName
    {
        get
        {
            return lastName; 
        }
        set
        {
            if (value != null && value != string.Empty)
            {
                lastName = value;
            }
            else
            {
                throw new ArgumentException("The input last name is either null or empty string!");
            }
        }
    }

    public string OtherInfo
    {
        get 
        {
            return otherInfo; 
        }
        set 
        {
            otherInfo = value;                
        }
                
    }

    public bool IsOlderThan(Student otherStudent)
    {
        DateTime firstDate = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
        DateTime secondDate = DateTime.Parse(otherStudent.OtherInfo.Substring(otherStudent.OtherInfo.Length - 10));

        if ((firstDate<DateTime.Now)&&(secondDate<DateTime.Now))
        {
            return firstDate > secondDate;
        }
        else
        {
            throw new ArgumentException("The input dates must be before current date");
        }
    }
}
