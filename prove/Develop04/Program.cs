using System;
using System.Collections;

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
        Console.WriteLine("Please Select an Activity:");
        Console.WriteLine("");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflection Activity");
        Console.WriteLine("3. Start Listening Activity");
        Console.WriteLine("0. Quit");
        string _userInput = Console.ReadLine();

        switch (_userInput)
        {
            case "1":
            {
                Breathing Breathing1 = new Breathing();
                string _description = "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.";
                Breathing1.StartMessage("Breathing", _description);
                Breathing1.DisplayActivity();
                Breathing1.EndMessage();

                return true;
            }

            case "2":
            {
                Reflection Reflect1 = new Reflection();
                string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
                Reflect1.StartMessage("Reflection", _description);
                Reflect1.DisplayActivity();
                Reflect1.EndMessage();

                return true;
            }

            case "3":
            {
                Listing Listing1 = new Listing();
                string _description = "This activity will help you reflect on the good things in your life \nby having you list as many things as you can in a certain area.";
                Listing1.StartMessage("Listing", _description);
                Listing1.DisplayActivity();
                Listing1.EndMessage();
                return true;;
            }

            case "0":
            {
                Console.Write("Terminating Program:  ");
                Activity activity = new Activity();
                activity.Pause();
                Console.Clear();
                return false;
            }

            default:
            {
                return true;
            }
                
        }
    }
}