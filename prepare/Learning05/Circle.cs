public class Circle:Shape
{
    private double _radius;

    public Circle()
    {
    }

    public void SetCircle(string color,double radius)
    {
        base.SetColor(color);
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.14 * _radius * _radius;
    }

}