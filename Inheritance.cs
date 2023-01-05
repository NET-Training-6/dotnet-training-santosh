//Write a class for rectangle, this class should have methods to calculate area and perimeter

class Rectangle : IDisplayMessage
{
    double length;
    double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double Area() => this.length * this.width;

    public double Perimeter() => 2 * (this.length + this.width);

    public virtual void PrintDetails()
    {
        Console.WriteLine($"I am rectangle with length={length} and width={width}");
    }
}

//Write a class for square, this class should have methods to calculate area and perimeter
class Square : Rectangle
{
    double side;
    public Square(double side) : base(side, side)
    {
        this.side = side;
    }

    public override void PrintDetails() //new basically overrides PrintDetails method implemented from rectangle
    {
        Console.WriteLine($"I am square with side={side}");
    }
}

//Write a class for triangle, this class should have methods to calculate area and perimeter

class Triangle
{
    double a, b, c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double Perimeter() => a + b + c;
    public double Area()
    {
        double s = this.Perimeter() / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return area;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"I am triangle with sides a={a}, b={b} and c={c}");
    }
}

interface IDisplayMessage
{
    public void PrintDetails();
}