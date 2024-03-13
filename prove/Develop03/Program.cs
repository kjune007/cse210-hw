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
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue or type 'quit' to quit");

        string input = ReadUserInput();

        switch(input)
        {
            case "1":
            CreateScripture();
            return true;

            case "2":
            Console.Clear();
            Console.WriteLine("Option 2. You typed 'quit' ");
            return false;

            case "3":
            Console.Clear();
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

    public static void CreateScripture()
    {
        Console.Clear();
        Scripture _newScripture = new Scripture();
        List<string> scripture = _newScripture.GetScripture();
        
        for (int i = 0; i < scripture.Count(); i++)
        {
            Word scriptureWord = new Word();
            string word = scripture[i];
            scriptureWord._word = word;
            string displayWord = scriptureWord.GetWord(true);
            Console.Write($"{displayWord} ");

        }
    Console.WriteLine("");
    }
}