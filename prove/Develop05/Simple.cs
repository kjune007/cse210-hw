public class Simple:Goal
{
    protected bool _complete = false;
    public Simple(string name, int points, bool end): base(name, points, end)
    {
        
    }
    public override void GetStatus()
    {

    }

    public void SetGoal(int _points, string _name)
    {
        _pointValue  = _points;
        _goalName = _name;
        _ending = true;
        _complete = false;
    }
    public override string SaveString()
    {
        if (_complete == false)
        {
            return $"[ ]--{_goalName}--{_pointValue}"; 
        }
        else
        {
            return $"[x]--{_goalName}--{_pointValue}";
        }

    }

    public override void MarkComplete()
    {
        _complete = true;
    }

}