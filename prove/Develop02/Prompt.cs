using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class Prompt
{

    public int _random;
    public List<string> _prompts = new List<string>()
    {
        "What was the most important thing you did today?",
        "What did you improve in your life today?",
        "If you could change something about your day, what would it be?",
        "Who was the most interesting person you interacted with today?",
        "What was the strongest emotion you felt today and why?"
    };

    public Prompt()
    {   
    }
    public void Display()
    {
        Console.WriteLine($"{_prompts.ElementAt(_random)}");
    }
}