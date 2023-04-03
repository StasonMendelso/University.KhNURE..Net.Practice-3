namespace Practice3.entity;

public class CircleShape : Shape
{
    private double _radius;

    public CircleShape(double centreX, double centreY, double radius) : base(centreX, centreY)
    {
        _radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Це CircleShape з радіусом {_radius}");
    }
}