namespace toWork;
//using NUnit.Framework;

class Program
{
    public static void Main()
    {
        Circle c = new Circle(2);
        Console.WriteLine(ShapeLibrary.GetArea(c));

        Triangle t = new Triangle(3, 4, 5); 
        Console.WriteLine(ShapeLibrary.GetArea(t)); // 6
        Console.WriteLine(t.IsRight()); // true
    }

}