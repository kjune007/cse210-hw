public class Shape
{
    protected string _color;


    public Shape()
    {
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return $"{_color}";
    }

    public virtual double GetArea()
    {
        return 0;
    }

}