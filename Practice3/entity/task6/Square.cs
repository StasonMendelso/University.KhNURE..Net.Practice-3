namespace Practice3.entity.task6;

public class Square
{
    protected double _a;

    public Square(double a)
    {
        _a = a;
    }

    public virtual double CalculatePerimeter()
    {
        return _a * 4;
    }
}