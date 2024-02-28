using System;
using System.Reflection.Metadata.Ecma335;

class Program
{    
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PrompUserNumber();
        int numberSquared = SquareNumber(userNumber);
        DisplayResult(numberSquared, userName);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string Username = Console.ReadLine();
        
        return Username;
    }
    static int PrompUserNumber()
    {
        Console.Write("What is your favorite number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);

        return number;
    }
    static int SquareNumber(int userNumber)
    {
        int numberSquared = userNumber * userNumber;

        return numberSquared;
    }
    static void DisplayResult(int numberSquared, string Username)
    {
        Console.WriteLine($"{Username}, your number squared is {numberSquared}");
    }

}
