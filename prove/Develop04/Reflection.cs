public class Reflection:Activity
{
    protected List<string>_prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    protected List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection()
    {   
    }

    public void DisplayActivity()
    {
        Console.Clear();
        Console.Write("Get ready... ");
        Pause();
        Console.WriteLine("");
        Console.WriteLine("");

        Random Random1 = new Random();
        int _randomPrompt = Random1.Next(0,4);
        string _currentPrompt = _prompts[_randomPrompt];
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"--- {_currentPrompt} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, Press Enter to continue");

        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if(keyInfo.Key == ConsoleKey.Enter)
        {
            Console.Write("You may begin in a moment...  ");
            Pause();
            Console.Clear();
            Random Random2 = new Random();
            int _randomQuestion = Random2.Next(0,9);
            string _currentQuestion = _questions[_randomQuestion];
            Console.Write($"--- {_currentQuestion} ---  ");
            float _timePerQuestion = _duration / 3;
            for(int i = 0; i < _timePerQuestion; i++)
            {
                Pause();
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Random Random3 = new Random();
            int _randomQuestion2 = Random3.Next(0,9);
            string _currentQuestion2 = _questions[_randomQuestion2];
            Console.Write($"--- {_currentQuestion2} ---  ");
            for(int i = 0; i < _timePerQuestion; i++)
            {
                Pause();
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Random Random4 = new Random();
            int _randomQuestion3 = Random4.Next(0,9);
            string _currentQuestion3 = _questions[_randomQuestion3];
            Console.Write($"--- {_currentQuestion3} ---  ");
            for(int i = 0; i < _timePerQuestion; i++)
            {
                Pause();
            }


            Console.WriteLine("Well Done!");


        }
        else
        {

        }
        Thread.Sleep(1500);
        Console.Clear();
    }

}