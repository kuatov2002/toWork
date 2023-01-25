namespace toWork;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        this._radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}