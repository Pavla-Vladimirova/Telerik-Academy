using System;
using System.Linq;

public class Figure
{
    private double width;
    private double height;

    public Figure(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    
    public static Figure GetSurroundingFigure(Figure figure, double angleOfRotation)
    {
        double widthAfterRotation= Math.Abs(Math.Cos(angleOfRotation)) * figure.width + Math.Abs(Math.Sin(angleOfRotation)) * figure.height;
        double heightAfterRotation = Math.Abs(Math.Sin(angleOfRotation)) * figure.width + Math.Abs(Math.Cos(angleOfRotation)) * figure.height;
        Figure rotatedFigure = new Figure(widthAfterRotation, heightAfterRotation);
        return rotatedFigure;
    }

    //Added this method just to be able to see the results from method RotateFigure
    public override string ToString()
    {
        return String.Format("Figure Width:{0} and Height:{1}",this.width,this.height);
    }
}

class TestFigureRotation 
{
    static void Main(string[] args)
    {
        Figure figure = new Figure(30, 40);
        Console.WriteLine("Before Rotation:\n{0}",figure);
        double angle = 10;
        Figure surroundingFigure=Figure.GetSurroundingFigure(figure, angle);
        Console.WriteLine("AfterRotation:\n{0}",surroundingFigure);
    }
}

