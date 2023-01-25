namespace toWork;

public class Triangle : IShape
{
    private readonly double _side1;
    private readonly double _side2;
    private readonly double _side3;

    public Triangle(double side1, double side2, double side3)
    {
        this._side1 = side1;
        this._side2 = side2;
        this._side3 = side3;
    }

    public double GetArea()
    {
        double s = (_side1 + _side2 + _side3) / 2;
        return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
    }

    public bool IsRight()
    {
        return _side1 * _side1 + _side2 * _side2 == _side3 * _side3 ||
               _side1 * _side1 + _side3 * _side3 == _side2 * _side2 ||
               _side2 * _side2 + _side3 * _side3 == _side1 * _side1;
    }
}