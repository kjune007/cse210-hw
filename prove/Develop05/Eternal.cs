public class Eternal:Goal
{

    protected bool _complete = false;
    public Eternal(string name, int points, bool end): base(name, points, end)
    {
    }
    public override void GetStatus()
    {
        throw new NotImplementedException();
    }

    public void SetGoal(int _points, string _name)
    {
        _pointValue  = _points;
        _goalName = _name;
        _ending = false;
        _complete = false;
    }

    public override string SaveString()
    {
        return $"[]--{_goalName}--{_pointValue}"; 
    }

    public override void MarkComplete()
    {
        _complete = false;
    }
}