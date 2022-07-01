// See https://aka.ms/new-console-template for more information
abstract class ishape
{
    abstract public double calculatearea();
    abstract public double calculateparameter();
}
class circle : ishape
{
    public static readonly double pi = 3.14;
    public int radius { set; get; }

    public override double calculatearea()
    {
        double area = radius * pi;
        return area;
    }

    public override double calculateparameter()
    {
        double parameter = 2 * pi * radius * radius;
        return parameter;
    }

}
class rectangle : ishape
{
    public int length { set; get; }
    public int weidth { set; get; }
    public override double calculatearea()
    {
        double area = length * weidth;
        return area;
    }

    public override double calculateparameter()
    {
        double Parameter = 2 * (length + weidth);
        return Parameter;
    }
}
class calculate
{
    static void Main(string[] args)
    {
        circle c = new circle();
        c.radius = 2;
        Console.WriteLine("circle area=" + c.calculatearea());
        Console.WriteLine("circle parameter=" + c.calculateparameter());
        rectangle r = new rectangle();
        r.length = 2;
        r.weidth = 2;
        Console.WriteLine("rectangle area=" + r.calculatearea());
        Console.WriteLine("rectangle perimeter=" + r.calculateparameter());

    }
}
