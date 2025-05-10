using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage?  ");
        string gradeInPer = Console.ReadLine();
        int noGrade = int.Parse(gradeInPer);

        string grade;

        if (noGrade >= 90)
        {
            grade = "A";
        }
        else if (noGrade >= 80)
        {
            grade = "B";
        }
        else if (noGrade >= 70)
        {
            grade = "C";
        }
        else if (noGrade >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Grade: {grade}");

        if (noGrade >= 70)
        {
            Console.WriteLine("Congratulation you passed the class 🥳");
        }
        else
        {
            Console.WriteLine("You failed the course, try again next time 🙁");
        }
    }
}