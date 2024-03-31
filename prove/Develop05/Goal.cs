using System.Dynamic;

public abstract class Goal
{
    protected int _pointValue;
    protected string _goalName;
    protected bool _ending;

    public Goal(string name, int points, bool end)
    {
        _pointValue = points;
        _goalName = name;
        _ending = end;

    }

    public string GetName()
    {
        return _goalName;
    }

    public abstract int ReturnPoints();

    public abstract string  SaveString();

    public abstract bool GetStatus();

    public abstract void MarkComplete();


}