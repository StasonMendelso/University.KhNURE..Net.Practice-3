namespace Practice3.entity;

public class Circle
{
    private double _x;
    private double _y;
    private double _radius;

    public Circle()
    {
    }

    public Circle(double x, double y, double radius)
    {
        _x = x;
        _y = y;
        _radius = radius;
    }

    public double CalculateLength()
    {
        return Math.PI * _radius;
    }

    public double CalculateLength(double radius)
    {
        return Math.PI * radius;
    }

    public Circle GetObject()
    {
        return new Circle(_x, _y, _radius);
    }

    public Circle GetObject(double x, double y, double radius)
    {
        return new Circle(x, y, radius);
    }

    public bool IsPointInCircle(double x, double y)
    {
        var distance = Math.Sqrt(Math.Pow(_x - x, 2) + Math.Pow(_y - y, 2));
        return distance <= _radius;
    }

    public override string ToString()
    {
        return this.GetType().Name + $"{{\nx = {_x}\ny = {_y}\nradius = {_radius}}}";
    }
}