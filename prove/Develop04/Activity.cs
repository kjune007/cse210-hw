using System;
public class Activity
{
    protected string _description;
    protected string _name;
    protected int _duration;

    public Activity()
    {
    }

    public  void Pause()
    {
        Console.Write("[-----]");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("%----]");

        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("%---]");

        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("%--]");

        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("%-]");

        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("%]");
        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");

    }

    public void StartMessage(string _activity, string _descriptionName)
    {
        _name = $"Welcome to the {_activity} activity!";

        _description = $"{_descriptionName}";

        Console.Clear();
        Console.WriteLine($"{_name}");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        Console.WriteLine("How long would you like this activity to last in seconds? ");
        string _durationString = Console.ReadLine();
        _duration = int.Parse(_durationString);




    }
}