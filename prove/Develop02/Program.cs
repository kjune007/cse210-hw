using System;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool _continue = true;
        Journal journal1 = new Journal();
        while(_continue)
        {
            _continue = MainMenu(journal1);
        }
    }   
    public static bool MainMenu(Journal journal1)
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");           
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string userInput = Console.ReadLine();

        switch(userInput)
        {
            case "1":
            DateTime _dateTime = DateTime.Now;
            Random _r = new Random();
            Prompt prompt1 = new Prompt();
            prompt1._random = _r.Next(0,4);
            prompt1.Display();

            string _datestring = _dateTime.ToShortDateString();
            
            Entry _newEntry = new Entry();
            _newEntry._date = _datestring;
            _newEntry._prompt = prompt1._prompts.ElementAt(prompt1._random);
            _newEntry._entry = Console.ReadLine(); 
            journal1._journalEntries.Add($"{_newEntry._date} -- {_newEntry._prompt}, {_newEntry._entry}"); 
            return true;

            case "2":
            journal1.Display();
            return true;

            case "3":

            return true;

            case "4":
            string fileName = "Journal.txt";
            using (TextWriter tw = new StreamWriter(fileName))
            {
                foreach(String s in journal1._journalEntries)
                {
                    tw.WriteLine(s);
                }
            }
             return true;

            case "5":
            return false;
                
            default:
            Console.WriteLine("Please choose a valid option!");
            return true;

        }
    }
    
}