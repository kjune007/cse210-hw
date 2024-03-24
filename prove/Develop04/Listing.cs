using Microsoft.VisualBasic;

public class Listing:Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    public Listing()
    {
    }

    public void DisplayActivity()
    {
        Random _random = new Random();
        int _randomPrompt = _random.Next(0,5);
        string _currentPrompt = _prompts[_randomPrompt];

        Console.Clear();
        Console.WriteLine("Get ready... ");
        Console.WriteLine("");
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine("");
        Console.Write($"--- {_currentPrompt} ---");
        Console.WriteLine("");
        Console.Write("You may begin:  ");
        Pause();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        int i =0;

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write(" > ");
            Console.ReadLine();
            Console.WriteLine("");

            i++;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {i} items!");

    }
}