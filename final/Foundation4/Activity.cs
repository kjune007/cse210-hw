public class Activity
{
    protected DateTime _date;
    protected float _length;

    public Activity()
    {
    }

    public void SetActivity(DateTime date, float time)
    {
        _date = date;
        _length = time;

    }

    public virtual double GetDistance()
    {
        return 0;
    } 

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public void GetSummary()
    {
        double distance = double.Round(GetDistance(),2,MidpointRounding.AwayFromZero);
        double speed = double.Round(GetSpeed(),2,MidpointRounding.AwayFromZero);
        double pace = double.Round(GetPace(),2,MidpointRounding.AwayFromZero);

        Console.WriteLine($"{_date:dd MMM yyy} {GetType().Name} ({_length} min)-Distance {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile");
    }

}