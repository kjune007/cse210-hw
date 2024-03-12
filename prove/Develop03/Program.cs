using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool _continue = true;
        while(_continue)
        {
            _continue = MainMenu();
        }

    }

    public static bool MainMenu()
    {
        Console.WriteLine("Press Enter to continue or type 'quit' to quit");

        string input = ReadUserInput();

        switch(input)
        {
            case "1":
            Console.WriteLine("Option 1. you pressed enter:");
            return true;

            case "2":
            Console.WriteLine("Option 2. You typed 'quit' ");
            return false;

            case "3":
            Console.WriteLine("Option 3. Please select a valid option");
            return true;

            default:
            return true;
        }

    }

    public static string ReadUserInput()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();
    
        if (keyInfo.Key == ConsoleKey.Enter)
        {
            return "1";
        }
        if (keyInfo.Key != ConsoleKey.Enter)
        {
            string userInput = Console.ReadLine();
            string quit = "uit";
            if (String.Equals(userInput, quit))
            {
                return "2";
            }
            else
            {
                return "3";
            }
        }
        else 
        {
            return "3";
        }
    }

}   