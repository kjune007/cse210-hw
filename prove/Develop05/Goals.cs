using System.Diagnostics.Contracts;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Goals
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public Goals()
    {
    }

    public void DisplyGoals()
    {
        foreach (Goal goal in _goals)
        {
            string _string = goal.SaveString();
            Console.WriteLine($"{_string}");
        }
    }

    public void Load()
    {
        string _filename = "Goals.txt";
        
        
        using (StreamReader read = new StreamReader(_filename))
        {
            string _readLine;
            while ((_readLine = read.ReadLine()) != null)
            {
                string[] parts = _readLine.Split("--");
            }
        }
        Console.WriteLine($"Goals loaded!");
        Thread.Sleep(1500);
            
        
    }

    public void Save()
    {
        try
        {
            string fileName = "Goals.txt";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach(Goal goal in _goals)
                {
                    writer.WriteLine(goal.SaveString());
                }
            }
            Console.WriteLine($"Goals Saved!");
        }
        catch (Exception)
        {
            Console.WriteLine($"Error occured while saving goals:");
        }    
    }

    public void MarkDone()
    {
        Console.WriteLine("What goal did you complete?: ");
        string goalName = Console.ReadLine(); 
        foreach (Goal goal in _goals)
        {
            if (goalName == goal.GetName())
            {
                goal.MarkComplete();
                
            }
        }
        for (int i = 0; i < _goals.Count(); i++)
        {
            _score += _goals[i].ReturnPoints();
        }
        Console.WriteLine($"You have {_score} points");

    }
    public void NewGoal()
    {
        Console.Clear();
        Console.WriteLine("What type of Goal would you like to create?");
        Console.WriteLine();
        Console.WriteLine("Goal Options:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Checklist");
        Console.WriteLine("3. Eternal");
        string userinput = Console.ReadLine();

        switch (userinput)
        {
            case "1":
            {
                Console.WriteLine("What is the name of this Goal? ");
                string _name = Console.ReadLine();
                Console.WriteLine("What is the point value for this goal? ");
                string _pointstring = Console.ReadLine();
                int _points = int.Parse(_pointstring);
                Simple SimpleGoal = new Simple(_name, _points, true);
                _goals.Add(SimpleGoal);
                break;
            }
            case "2":
            {
                Console.WriteLine("What is the name of this Goal? ");
                string _name = Console.ReadLine();
                Console.WriteLine("What is the point value for this goal? ");
                string _pointstring = Console.ReadLine();
                int _points = int.Parse(_pointstring);
                Console.WriteLine("How many times must this be completed? ");
                string _number = Console.ReadLine();
                int _timestoComplete = int.Parse(_number);
                Checklist CheckList = new Checklist(_name,_points, true, _timestoComplete);
                _goals.Add(CheckList);
                break;
            }
            case "3":
            {
                Console.WriteLine("What is the name of this Goal? ");
                string _name = Console.ReadLine();
                Console.WriteLine("What is the point value for each compleation of this goal? ");
                string _pointstring = Console.ReadLine();
                int _points = int.Parse(_pointstring);
                Eternal EternalGoal = new Eternal(_name, _points, false);
                _goals.Add(EternalGoal);
                break;
            }
            default:
            {
                Console.WriteLine("That was not a valid Option");
                break;
            }
        }
    }
}
