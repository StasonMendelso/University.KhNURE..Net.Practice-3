namespace Practice3.entity;

public class TriangleShape : Shape
{
    private double _a, _b, _c;

    public TriangleShape(double centreX, double centreY, double a, double b, double c) : base(centreX, centreY)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public override void Draw()
    {
        Console.WriteLine($"Це TriangleShape зі сторонами a={_a},b={_b},c={_c}");
    }
}