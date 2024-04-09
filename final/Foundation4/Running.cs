public class Running:Activity
{
    private double _distance;

    public Running()
    {
    }

    public void SetRunning(DateTime date, float time, double distance)
    {
        base.SetActivity(date,time);
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

}