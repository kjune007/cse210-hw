using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
            Console.WriteLine("Good Job! You have passed the class");
        } 
        else if (grade >= 80)
        {
            letter = "B";
            Console.WriteLine("Good Job! You have passed the class");
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine("Good Job! You have passed the class");
        }
        else if (grade >= 60)
        {
            letter = "D";
            Console.WriteLine("You have failed the class. Study harder next time!");

        }
        else
        {
            letter = "F";
            Console.WriteLine("You have failed the class. Study harder next time!");
        }

        Console.WriteLine($"Your grade is {letter}");
    }
}