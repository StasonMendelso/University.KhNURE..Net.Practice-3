namespace Practice3.entity.task7;

public class Rectangle
{
    private double _X1, _Y1, _X2, _Y2;

    public Rectangle(double x1, double y1, double x2, double y2)
    {
        _X1 = x1;
        _Y1 = y1;
        _X2 = x2;
        _Y2 = y2;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        if (obj is not Rectangle rectangle)
        {
            return false;
        }

        if (obj == this)
        {
            return true;
        }

        return rectangle._X1.Equals(_X1) &&
               rectangle._X2.Equals(_X2) &&
               rectangle._Y1.Equals(_Y1) &&
               rectangle._Y2.Equals(_Y2);
    }

    public override int GetHashCode()
    {
        return _X1.GetHashCode() * 31 +
               _X2.GetHashCode() * 31 +
               _Y1.GetHashCode() * 31 +
               _Y2.GetHashCode() * 31;
    }

    public override string ToString()
    {
        return $"Rectangle{{\nX1 = {_X1},\nX2 = {_X2},\nY1 = {_Y1},\nY2 = {_Y2}}}";
    }
}