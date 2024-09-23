namespace C.Fundamentals.Module08.Polymorphism.Question04;

/// <summary>
/// Crie uma interface IAreaCalculavel com um método CalcularArea() e crie classes de figuras
/// geométricas que implementam este método(como quadrado, circunferência e retângulo).
/// Depois crie uma classe com um método Main() para exercitar as chamadas aos métodos que
/// calculam a área.
/// </summary>
internal static class Answer
{
    internal static void Run()
    {
        ICalculableArea square = new Square(5);
        ICalculableArea circumference = new Circumference(2);
        ICalculableArea rectangle = new Rectancle(2, 4);

        Console.WriteLine($"Square area: {square.CalculateArea()}");
        Console.WriteLine($"Circumference area: {circumference.CalculateArea()}");
        Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
    }
}

internal interface ICalculableArea
{
    double CalculateArea();
}

internal class Square : ICalculableArea
{
    public Square(double side)
    {
        Side = side;
    }

    public double Side { get; private set; }

    public double CalculateArea()
    {
        return Math.Pow(Side, 2);
    }
}

internal class Circumference : ICalculableArea
{
    public Circumference(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; private set; }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

internal class Rectancle : ICalculableArea
{
    public Rectancle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    public double Base { get; private set; }
    public double Height { get; private set; }

    public double CalculateArea()
    {
        return Base * Height;
    }
}
