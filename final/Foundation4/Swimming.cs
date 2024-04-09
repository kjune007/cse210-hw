public class Swimming:Activity
{
    private double _laps;
    public Swimming()
    {
    }

    public void SetSwimming(DateTime date, float time, double laps)
    {
        base.SetActivity(date,time);
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        double pace = GetPace();
        return 60 / pace; 
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return _length / distance;
    }

}