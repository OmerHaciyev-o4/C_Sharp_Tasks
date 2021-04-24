#region Tasks
abstract class Figure
{
    protected double side1 { get; set; }
    protected double side2 { get; set; }
    protected double side3 { get; set; }


    protected Figure(double _side1, double _side2, double _side3)
    {
        side1 = _side1;
        side2 = _side2;
        side3 = _side3;
    }


    protected abstract double Area();
    protected abstract double Perimeter();
}

class Triangle : Figure
{
    public double _height = -1;


    public Triangle(double side1, double side2, double side3, double height) : base(side1, side2, side3)
    {
        _height = height;
        Console.WriteLine($"{this.Area()}\t{this.Perimeter()}");
    }


    protected override double Area()
    {
        if (_height == -1) { throw new Exception("You did not enter the height"); }
        else { return (_height * side2) / 2; }
    }

    protected override double Perimeter()
    {
        return side1 + side2 + side3;
    }
}

class Siquare : Figure
{
    public Siquare(double side) : base(side, 0, 0) { Console.WriteLine($"{this.Area()}\t{this.Perimeter()}"); }

    protected override double Area()
    {

        if (side1 == 0)
        {
            return 0;
        }
        else
        {
            return side1 * 2;
        }
    }

    protected override double Perimeter()
    {
        return side1 * 4;
    }
}

class Rhombus : Figure
{
    private double _d1 = -1;
    private double _d2 = -1;


    public Rhombus(double side, double diagonal1, double diagonal2) : base(side, 0, 0)
    {
        _d1 = diagonal1;
        _d2 = diagonal2;
        Console.WriteLine($"{this.Area()}\t{this.Perimeter()}");
    }


    protected override double Area()
    {
        if (_d1 == -1 || _d2 == -1)
        {
            throw new Exception("You have not entered any diagonal or entered any diagonal.");
        }
        else { return (_d1 * _d2) / 2; }
    }

    protected override double Perimeter()
    {
        return side1 * 4;
    }
}

class Rectangle : Figure
{
    private double _side4;

    public Rectangle(double side1, double side2, double side3, double side4) : base(side1, side2, side3)
    {
        _side4 = side4;
        Console.WriteLine($"{this.Area()}\t{this.Perimeter()}");
    }

    protected override double Area()
    {
        return side1 * side2;
    }

    protected override double Perimeter()
    {
        return side1 + side2 + side3 + _side4;
    }
}

class Paralleogram : Figure
{
    private double _side4;
    public double _height = -1;


    public Paralleogram(double side1, double side2, double side3, double side4, double height) : base(side1, side2, side3)
    {
        _side4 = side4;
        _height = height;
        Console.WriteLine($"{this.Area()}\t{this.Perimeter()}");
    }

    protected override double Area()
    {
        if (_height == -1) { throw new Exception("You did not enter the height"); }
        else { return _height * side3; }
    }

    protected override double Perimeter()
    {
        return side1 + side2 + side3 + _side4;
    }
}

//Console.WriteLine("Area\tPerimetre");
//Triangle triangle = new Triangle(0, 3, 1, 6.5);

//Siquare siquare = new Siquare(4);

//Rhombus rhombus = new Rhombus(5, 3.5, 6.3);

//Rectangle rectangle = new Rectangle(4, 5, 4, 5);

//Paralleogram paralleogram = new Paralleogram(5, 5, 9, 5, 8);

#endregion