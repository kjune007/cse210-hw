public class Eternal:Goal
{

    protected bool _complete = false;
    int _timesCompleted = 0;
    public Eternal(string name, int points, bool end): base(name, points, end)
    {
    }
    public override bool GetStatus()
    {
        return _complete;
    }

        public override int ReturnPoints()
    {
        return _pointValue * _timesCompleted;
    }

    public override string SaveString()
    {
        return $"[{_timesCompleted}]--{_goalName}--{_pointValue}"; 
    }

    public override void MarkComplete()
    {
        _complete = false;
        _timesCompleted ++;
    }
}