namespace Practice3.entity.task6;

public class Cube : Square
{
    public Cube(double a) : base(a)
    {
    }

    public override double CalculatePerimeter()
    {
        return _a * 12;
    }
}