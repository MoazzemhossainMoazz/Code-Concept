class Circle
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double Area
    {
        get { return Math.PI * radius * radius; }
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Console.WriteLine($"Area: {circle.Area}");
    }
}