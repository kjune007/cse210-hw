using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        CreateScripture(0);
        bool _continue = true;
        while(_continue)
        {
            _continue = MainMenu();
        }

    }

    public static bool MainMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue or type 'quit' to end the program");

        string input = ReadUserInput();

        switch(input)
        {
            case "1":    
            CreateScripture(1);
            return true;
                

            case "2":
            Console.Clear();
            Console.WriteLine("Program Terminated ");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
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

    public static void CreateScripture(int number)
    {
        Console.Clear();
        Scripture NewScripture = new Scripture();
        List<string> _scripture = NewScripture.GetScripture();
        Reference NewReference = new Reference();
        string _reference =  NewReference.GetReference();
        Console.Write($"{_reference}: -- ");
        
        if (number == 0)
        {
            for (int i = 0; i < _scripture.Count(); i++)
            {
                Random random = new Random();
                int r = random.Next(0,2);
        
                Word scriptureWord = new Word();
                string word = _scripture[i];
                scriptureWord._word = word;
                string displayWord = scriptureWord.GetWord(0);
                Console.Write($"{displayWord} ");
            
            }
        }
        else
        {
            for (int i = 0; i < _scripture.Count(); i++)
            {
                Random random = new Random();
                int r = random.Next(0,2);
        
                Word ScriptureWord = new Word();
                string word = _scripture[i];
                ScriptureWord._word = word;
                string displayWord = ScriptureWord.GetWord(r);
                Console.Write($"{displayWord} ");
            
            }
        }
    Console.WriteLine("");
    }
} 