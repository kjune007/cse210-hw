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
            journal1._journalEntries.Add($"{_newEntry._date} -- Prompt: {_newEntry._prompt} -- {_newEntry._entry}"); 
            return true;

            case "2":
            journal1.Display();
            return true;

            case "3":
            string fileName1 = "Journal.txt";
            string[] lines = System.IO.File.ReadAllLines(fileName1);

            foreach (string line in lines)
            {
                string[] parts = line.Split("--");
                Entry loadEntry = new Entry();
                loadEntry._date = parts[0];
                loadEntry._prompt = parts[1];
                loadEntry._entry = parts[2];
                Journal loadJournal = new Journal();
                loadJournal._journalEntries.Add($"{loadEntry._date} -- {loadEntry._prompt} -- {loadEntry._entry}");
                loadJournal.Display();
            }
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