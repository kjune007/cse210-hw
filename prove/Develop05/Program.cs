using System;

class Program
{
    static void Main(string[] args)
    {
        bool _continue = true;
        Goals GoalList = new Goals();
        while(_continue)
        {
            _continue = MainMenu(GoalList);
        }
    }       
    public static bool MainMenu(Goals GoalList)
    {
        //Goals GoalList = new Goals();
        Console.WriteLine("");
        Console.WriteLine("Please Select a menu option:");
        Console.WriteLine("");
        Console.WriteLine("1. Load Goals");
        Console.WriteLine("2. Save Goals");
        Console.WriteLine("3. New Goal");
        Console.WriteLine("4. Record Event");
        Console.WriteLine("5. Display Goals");
        Console.WriteLine("0. Quit");
        string _userInput = Console.ReadLine();

        switch (_userInput)
        {
            case "1":
            {
                return true;
            }
            case "2":
            {
                GoalList.Save();
                return true;
            }
            case "3":
            {
                GoalList.NewGoal();
                return true;
            }
            case "4":
            {
                GoalList.MarkComplete();
                return true;
            }
            case "5":
            {
                GoalList.DisplyGoals();
                return true;
            }
            case "0":
            {
                return false;
            }
            default:
            {
                return true;
            }

        }
    }
}