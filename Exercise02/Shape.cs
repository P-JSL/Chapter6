using static System.Console;

namespace Exercise02;

public class Program
{
    static void Main(string[] args)
    {
        Rectangle r = new(height: 3, width: 4.5);
        Square s = new(5);
        Circle c = new(radius: 2.5);

        WriteLine($"Rectangle H : {r.Height}, W : {r.Width} , Area : {r.Area}");
        WriteLine($"Square H : {s.Height}, W : {s.Width} , Area : {s.Area}");
        WriteLine($"Circle H : {c.Height}, W : {c.Width} , Area : {c.Area}");
    }
}

public class Shape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Area
    {
        get { return Height * Width; }
    }

}

public class Rectangle : Shape
{
    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }
    public new double Area
        { get
            {
                return Width * Height;
            } 
        }
    
}
public class Square : Shape
{
    public Square(double r)
    {
        Height = r;
        Width = r;
    }
    public new double Area
    {
        get
        {
            return Height * Height;
        }
    }
}
public class Circle : Shape
{
    public Circle(double radius)
    {
        Height = radius * 2;
        Width = radius * 2;
    }
    public new double Area
    {
        get
        {
            return Math.Exp((Height / 2)) * Math.PI/2;
        }
    }
}
