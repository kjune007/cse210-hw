public class Simple:Goal
{
    protected bool _complete = false;
    public Simple(string name, int points, bool end): base(name, points, end)
    {
        
    }
    public override bool GetStatus()
    {
        return _complete;
    }

    public override int ReturnPoints()
    {
        if (_complete == true)
        {
            return _pointValue;
        }
        else
        {
            return 0;
        }
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