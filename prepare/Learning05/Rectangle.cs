public class Rectangle:Shape
{
    private double _length;
    private double _width;

    public Rectangle()
    {
    }

    public void SetRectangle(string color, double length,double width)
    {
        base.SetColor(color);
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }

}