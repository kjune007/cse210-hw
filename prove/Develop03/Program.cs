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
        int _loopcount = 0;
        bool _continue = true;
        while(_continue)
        {
            _continue = MainMenu(_loopcount);
        }

    }

    public static bool MainMenu(int _loopcount)
    {
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue or type 'quit' to end the program");

        string input = ReadUserInput();

        switch(input)
        {
            case "1":    
            MemorizeScripture(_loopcount);
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
    
                string word = _scripture[i];
                Word ScriptureWord = new Word(word,true);
                string displayWord = ScriptureWord.GetWord();
                Console.Write($"{displayWord} ");
            
            }
        }
    Console.WriteLine("");
    }

    public static void MemorizeScripture(int _loopcount)
    {
        Console.Clear();
        Passage Passage = new Passage();
        Scripture NewScripture2 = new Scripture();
        List<string> _scripture2 = NewScripture2.GetScripture();
        
        static bool FlagSet(int _loopcount)
        {
            if (_loopcount < 25)
            {
                return true;
            }

            else if (_loopcount <= 60)
            {
                return false;
            }
            return false;
        }

        for (int i = 0; i < _scripture2.Count(); i++)
        {
            bool _flag = FlagSet(_loopcount);
            string word = _scripture2[i];
            Word ScriptureWord = new Word(word, _flag);
            Passage.PassageAdd(ScriptureWord);
            _loopcount++;
            
        }

        
        List<string> _passageWords = new List<string>();
        
        for (int i = 0; i < 27; i++)
        {
            Word _currentword = Passage.GetWordFromPassage(i);
            string _word = _currentword.GetWord();
            _passageWords.Add(_word);

            Console.Write($"{_passageWords[i]} ");
        }
        
    }

} 