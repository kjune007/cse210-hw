public class Checklist:Goal
{
    protected bool _complete = false;
    protected int _HowManyTimes;
    protected int _timesCompleted = 0;
    public Checklist(string name, int points, bool end, int _timesToComplete): base(name, points, end)
    {
        _HowManyTimes = _timesToComplete;
    }
    public override bool GetStatus()
    {
        return _complete;
    }

        public override int ReturnPoints()
    {
        if (_complete == true)
        {
            return _pointValue * _timesCompleted + 100;
        }
        else
        {
            return _pointValue * _timesCompleted;
        }
    }

    public override string SaveString()
    {
        if (_HowManyTimes == _timesCompleted)
        {
            return $"[x]--{_goalName}--{_pointValue}"; 
        }
        else
        {
            return $"[ ]--{_goalName}--{_pointValue}--times completed: {_timesCompleted}/{_HowManyTimes}";
        }
    }

    public override void MarkComplete()
    {
        Console.WriteLine("How many times have you completed this activity? ");
        string timesCompletedString = Console.ReadLine();
        int timesCompleted = int.Parse(timesCompletedString);
        _timesCompleted = timesCompleted;
        
        if (timesCompleted == _HowManyTimes)
        {
            _complete = true;
        }
        else
        {
            _complete = false;
        }

    }
}