public class Cycling:Activity
{

    private float _speed;
    public Cycling()
    {
    }

 public void SetCycling(DateTime date, float time, float speed)
    {
        base.SetActivity(date,time);
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _length) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

}