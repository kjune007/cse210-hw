using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment();
        WritingAssignment writingAssignment = new WritingAssignment();

        mathAssignment.SetMathAssignment("John", "Calculus", "2.2", "1-12");
        writingAssignment.SetWritingAssignment("James","American History","The Civil War");

        Console.Clear();
        mathAssignment.GetHomework();
        Console.WriteLine();
        writingAssignment.GetWritingInformation();




    }
}