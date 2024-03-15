using System;
using System.Globalization;
using System.Linq.Expressions;
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
            bool _menuFlag = MemorizeScripture();
            return _menuFlag;
                

            case "2":
            Console.Clear();
            Console.WriteLine("Program Terminated ");
            System.Threading.Thread.Sleep(1500);
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
    
                string word = _scripture[i];
                Word ScriptureWord = new Word(word,true);
                string displayWord = ScriptureWord.GetWord();
                Console.Write($"{displayWord} ");
            
            }
        }
    Console.WriteLine("");
    }

    public static bool MemorizeScripture()
    {
        Console.Clear();
        Passage Passage = new Passage();
        Scripture NewScripture2 = new Scripture();
        List<string> _scripture2 = NewScripture2.GetScripture();


        for (int i = 0; i < _scripture2.Count(); i++)
        {
            string word = _scripture2[i];
            Word ScriptureWord = new Word(word, true);
            Passage.PassageAdd(ScriptureWord);
            
        }

        for (int j = 0; j < 27; j++)
        {
            Word word1 = new Word();
            word1 = Passage.GetWordFromPassage(j);
            string _word = word1.GetWord();
            Console.Write($"{_word} ");
        }

        string _j = ReadUserInput();
        
        while(_j == "1")
        {
            Console.Clear();
        

            if (_j == "1")
            {
                Passage.SetFlag();
                
                for (int j = 0; j < 27; j++)
                {
                    Word word1 = new Word();
                    word1 = Passage.GetWordFromPassage(j);
                    string _word = word1.GetWord();
                    Console.Write($"{_word} ");
                }
                _j = ReadUserInput();
                
            }
            
            else
            {
                return false;
            }
        }
        return false;


        
    }

} 