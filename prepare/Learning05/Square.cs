public class Square:Shape
{
    private double _side;

    public Square()
    {
    }

    public void SetSquare(string color,double side)
    {
        base.SetColor(color);
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }

}