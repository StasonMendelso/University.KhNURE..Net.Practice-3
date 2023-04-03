namespace Practice3.entity;

public abstract class Shape
{
    private double _centreX;
    private double _centreY;

    protected Shape(double centreX, double centreY)
    {
        _centreX = centreX;
        _centreY = centreY;
    }

    public abstract void Draw();
}