public class Checklist:Goal
{
    protected bool _complete = false;
    protected int _HowManyTimes;
    protected int _timesCompleted = 0;
    public Checklist(string name, int points, bool end, int _timesToComplete): base(name, points, end)
    {
        _HowManyTimes = _timesToComplete;
    }
    public override void GetStatus()
    {
        throw new NotImplementedException();
    }

    public void SetGoal(int _points, string _name, int _HowManyTimes2)
    {
        _pointValue  = _points;
        _goalName = _name;
        _HowManyTimes = _HowManyTimes2;
    }

    public override string SaveString()
    {
        return $"{_goalName}--{_pointValue}--{_timesCompleted}/{_HowManyTimes}"; 
        
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