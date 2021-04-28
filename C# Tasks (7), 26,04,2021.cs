#region Taks
    interface ISimpleNAngleFigure
    {
        public double Height { get; set; }
        public double SidesCount { get; set; }
        public double Sides { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }
    }

    abstract class GeometricFigure
    {
        private double _area;
        private double _perimeter;


        public GeometricFigure() { }

        public GeometricFigure(double area, double perimeter)
        {
            _area = area;
            _perimeter = perimeter;
        }


        protected void setArea(double area) { _area = area; }
        protected void setPerimeter(double perimeter) { _perimeter = perimeter; }
    }


    class Rectangle : GeometricFigure
    {
        public double area { get; set; }
        public double perimeter { get; set; }

        public Rectangle(double side1, double side2) : base((side1 * side2), ((side1 * 2) + (side2 * 2))) 
        {
            area = side1 * side2;
            perimeter = (side1 * 2) + (side2 * 2);
        }
    }

    class Triangle : GeometricFigure
    {
        public double area { get; set; }
        public double perimeter { get; set; }


        public Triangle(double side1, double side2, double side3, double height) : base(((side1 * height) * 0.5), (side1 + side2 + side3))
        {
            area = ((side1 * height) * 0.5);
            perimeter = side1 + side2 + side3;
        }
    }

    class Square : GeometricFigure
    {
        public double area { get; set; }
        public double perimeter { get; set; }


        public Square(double side) : base((side * side), (side * 4))
        {
            area = side * side;
            perimeter = side * 4;
        }
    }

    class Rhombus : GeometricFigure
    {
        public double area { get; set; }
        public double perimeter { get; set; }


        public Rhombus(double side, double d1, double d2) : base((d1 * d2) / 2, (side * 4))
        {
            area = (d1 * d2) / 2;
            perimeter = side * 4;
        }
    }

    class Parallelogram : GeometricFigure
    {
        public double area { get; set; }
        public double perimeter { get; set; }

        public Parallelogram(double side1, double side2, double height) : base((side2 * height), ((side1 * 2) + (side2 * 2)))
        {
            area = side2 * height;
            perimeter = (side1 * 2) + (side2 * 2);
        }
    }

    class Trapezium : GeometricFigure
    {
        public double area { get; set; }
        public double perimeter { get; set; }


        public Trapezium(double side1, double side2, double side3, double height) : base(0.5 * (side1 + side2) * height, (side1 + side2 + side3 + side3))
        {
            area = 0.5 * (side1 + side2) * height;
            perimeter = side1 + side2 + side3 + side3;
        }
    }

    class Cricle : GeometricFigure
    {
        public double area { get; set; }
        public double perimeter { get; set; }

        public Cricle(double PI, double R) : base(PI * (R * R), 2 * PI * R)
        {
            area = PI * (R * R);
            perimeter = 2 * PI * R;
        }
    }



//Rectangle rectangle = new Rectangle(9, 4);
//Triangle triangle = new Triangle(5, 6, 7, 5);
//Square square = new Square(4);
//Rhombus rhombus = new Rhombus(5, 5.6, 4.6);
//Parallelogram parallelogram = new Parallelogram(5, 8, 4);
//Trapezium trapezium = new Trapezium(6, 9, 3, 3.5);
//Cricle cricle = new Cricle(3.14, 8);

//Console.WriteLine("Area: " + rectangle.area + "\tPerimeter: " + rectangle.perimeter);
//Console.WriteLine("Area: " + triangle.area + "\tPerimeter: " + triangle.perimeter);
//Console.WriteLine("Area: " + square.area + "\tPerimeter: " + square.perimeter);
//Console.WriteLine("Area: " + rhombus.area + "\tPerimeter: " + rhombus.perimeter);
//Console.WriteLine("Area: " + parallelogram.area + "\tPerimeter: " + parallelogram.perimeter);
//Console.WriteLine("Area: " + trapezium.area + "\tPerimeter: " + trapezium.perimeter);
//Console.WriteLine("Area: " + cricle.area + "\tPerimeter: " + cricle.perimeter);
#endregion

#region Task2
//abstract class FigureFeatures
//{
//    protected double area;
//    protected double perimeter;
//    protected int color;
//
//    protected abstract void SetArea(double value); 
//    protected abstract double GetArea(); 
//    protected abstract void SetPerimeter(double value);
//    protected abstract double GetPerimeter();
//    protected abstract void SetColor(int value);
//    protected abstract int GetColor();
//}
//
//
//class Rectangle : FigureFeatures
//{   
//    public Rectangle(double _side1, double _side2, int _color)
//    {
//        this.SetArea((_side1 * _side2));
//        this.SetPerimeter((_side1 * 2) + (_side2 * 2));
//        this.SetColor(_color);
//    }
//
//    protected override double GetArea() { return area; }
//
//    protected override int GetColor() { return color; }
//
//    protected override double GetPerimeter() { return perimeter; }
//
//    protected override void SetArea(double value) { area = value; }
//
//    protected override void SetColor(int value) { color = value; }
//
//    protected override void SetPerimeter(double value) { perimeter = value; }
//
//
//    public void Print()
//    {
//        if (this.GetColor() == 12){ Console.ForegroundColor = ConsoleColor.Red; }
//        else if (this.GetColor() == 10){ Console.ForegroundColor = ConsoleColor.Green; }
//        else if (this.GetColor() == 14){ Console.ForegroundColor = ConsoleColor.Yellow; }
//        else if (this.GetColor() == 15){ Console.ForegroundColor = ConsoleColor.White; }
//        else if (this.GetColor() == 7){ Console.ForegroundColor = ConsoleColor.Gray; }
//        else if (this.GetColor() == 0){ Console.ForegroundColor = ConsoleColor.Black; }
//        else if (this.GetColor() == 9){ Console.ForegroundColor = ConsoleColor.Blue; }
//
//        Console.WriteLine("* * * * * * * * * * * * * * *");
//        Console.WriteLine("*                           *");
//        Console.WriteLine("*                           *");
//        Console.WriteLine("*                           *");
//        Console.WriteLine("* * * * * * * * * * * * * * *");
//        
//        Console.WriteLine();
//        
//        Console.ForegroundColor = ConsoleColor.Black;
//        Console.BackgroundColor = ConsoleColor.White;
//
//        Console.WriteLine("Area: " + area + "\tPerimeter: " + perimeter);
//
//        Console.ForegroundColor = ConsoleColor.White;
//        Console.BackgroundColor = ConsoleColor.Black;
//    }
//}
//
//class Rhombus : FigureFeatures
//{
//    public Rhombus(double _side, double _dioqnal1, double _dioqnal2, int _color)
//    {
//        this.SetArea((_dioqnal1 * _dioqnal2) / 2);
//        this.SetPerimeter((_side * 4));
//        this.SetColor(_color);
//    }
//
//    protected override double GetArea() { return area; }
//
//    protected override int GetColor() { return color; }
//
//    protected override double GetPerimeter() { return perimeter; }
//
//    protected override void SetArea(double value) { area = value; }
//
//    protected override void SetColor(int value) { color = value; }
//
//    protected override void SetPerimeter(double value) { perimeter = value; }
//
//
//    public void Print()
//    {
//        if (this.GetColor() == 12) { Console.ForegroundColor = ConsoleColor.Red; }
//        else if (this.GetColor() == 10) { Console.ForegroundColor = ConsoleColor.Green; }
//        else if (this.GetColor() == 14) { Console.ForegroundColor = ConsoleColor.Yellow; }
//        else if (this.GetColor() == 15) { Console.ForegroundColor = ConsoleColor.White; }
//        else if (this.GetColor() == 7) { Console.ForegroundColor = ConsoleColor.Gray; }
//        else if (this.GetColor() == 0) { Console.ForegroundColor = ConsoleColor.Black; }
//        else if (this.GetColor() == 9) { Console.ForegroundColor = ConsoleColor.Blue; }
//
//        Console.WriteLine("      *     ");
//        Console.WriteLine("     * *    ");
//        Console.WriteLine("    *   *   ");
//        Console.WriteLine("   *     *  ");
//        Console.WriteLine("  *       * ");
//        Console.WriteLine(" *         *");
//        Console.WriteLine("  *       * ");
//        Console.WriteLine("   *     *  ");
//        Console.WriteLine("    *   *   ");
//        Console.WriteLine("     * *    ");
//        Console.WriteLine("      *     ");
//    
//        Console.ForegroundColor = ConsoleColor.Black;
//        Console.BackgroundColor = ConsoleColor.White;
//
//        Console.WriteLine("Area: " + area + "\tPerimeter: " + perimeter);
//
//        Console.ForegroundColor = ConsoleColor.White;
//        Console.BackgroundColor = ConsoleColor.Black;
//    }
//}
//
//class Triangle : FigureFeatures
//{
//    public Triangle(double _side1, double _side2, double _side3, double height, int _color)
//    {
//        this.SetArea((_side2 * height) * 0.5);
//        this.SetPerimeter((_side1 + _side2 + _side3));
//        this.SetColor(_color);
//    }
//
//    protected override double GetArea() { return area; }
//
//    protected override int GetColor() { return color; }
//
//    protected override double GetPerimeter() { return perimeter; }
//
//    protected override void SetArea(double value) { area = value; }
//
//    protected override void SetColor(int value) { color = value; }
//
//    protected override void SetPerimeter(double value) { perimeter = value; }
//
//
//    public void Print()
//    {
//        if (this.GetColor() == 12) { Console.ForegroundColor = ConsoleColor.Red; }
//        else if (this.GetColor() == 10) { Console.ForegroundColor = ConsoleColor.Green; }
//        else if (this.GetColor() == 14) { Console.ForegroundColor = ConsoleColor.Yellow; }
//        else if (this.GetColor() == 15) { Console.ForegroundColor = ConsoleColor.White; }
//        else if (this.GetColor() == 7) { Console.ForegroundColor = ConsoleColor.Gray; }
//        else if (this.GetColor() == 0) { Console.ForegroundColor = ConsoleColor.Black; }
//        else if (this.GetColor() == 9) { Console.ForegroundColor = ConsoleColor.Blue; }
//
//        Console.WriteLine("          *          ");
//        Console.WriteLine("         * *         ");
//        Console.WriteLine("        *   *        ");
//        Console.WriteLine("       *     *       ");
//        Console.WriteLine("      *       *      ");
//        Console.WriteLine("     *         *     ");
//        Console.WriteLine("    *           *    ");
//        Console.WriteLine("   *             *   ");
//        Console.WriteLine("  *               *  ");
//        Console.WriteLine(" *                 * ");
//        Console.WriteLine("* * * * * * * * * * *");
//
//        Console.ForegroundColor = ConsoleColor.Black;
//        Console.BackgroundColor = ConsoleColor.White;
//
//        Console.WriteLine("Area: " + area + "\tPerimeter: " + perimeter);
//
//        Console.ForegroundColor = ConsoleColor.White;
//        Console.BackgroundColor = ConsoleColor.Black;
//    }
//}
//
//class Trapezoid : FigureFeatures
//{
//    public Trapezoid(double _side1, double _side2, double _side3, double height, int _color)
//    {
//        this.SetArea((_side1 + _side3) * height * 0.5);
//        this.SetPerimeter((_side1 + _side2 + _side3 + _side3));
//        this.SetColor(_color);
//    }
//
//    protected override double GetArea() { return area; }
//
//    protected override int GetColor() { return color; }
//
//    protected override double GetPerimeter() { return perimeter; }
//
//    protected override void SetArea(double value) { area = value; }
//
//    protected override void SetColor(int value) { color = value; }
//
//    protected override void SetPerimeter(double value) { perimeter = value; }
//
//
//    public void Print()
//    {
//        if (this.GetColor() == 12) { Console.ForegroundColor = ConsoleColor.Red; }
//        else if (this.GetColor() == 10) { Console.ForegroundColor = ConsoleColor.Green; }
//        else if (this.GetColor() == 14) { Console.ForegroundColor = ConsoleColor.Yellow; }
//        else if (this.GetColor() == 15) { Console.ForegroundColor = ConsoleColor.White; }
//        else if (this.GetColor() == 7) { Console.ForegroundColor = ConsoleColor.Gray; }
//        else if (this.GetColor() == 0) { Console.ForegroundColor = ConsoleColor.Black; }
//        else if (this.GetColor() == 9) { Console.ForegroundColor = ConsoleColor.Blue; }
//
//        Console.WriteLine("          * * * * * * * * * * * * * * * * * * * * * * * * * *");
//        Console.WriteLine("         *                                                 * ");
//        Console.WriteLine("        *                                                 *  ");
//        Console.WriteLine("       *                                                 *   ");
//        Console.WriteLine("      *                                                 *    ");
//        Console.WriteLine("     *                                                 *     ");
//        Console.WriteLine("    *                                                 *      ");
//        Console.WriteLine("   *                                                 *       ");
//        Console.WriteLine("  *                                                 *        ");
//        Console.WriteLine(" *                                                 *         ");
//        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * *          ");
//
//        Console.ForegroundColor = ConsoleColor.Black;
//        Console.BackgroundColor = ConsoleColor.White;
//
//        Console.WriteLine("Area: " + area + "\tPerimeter: " + perimeter);
//
//        Console.ForegroundColor = ConsoleColor.White;
//        Console.BackgroundColor = ConsoleColor.Black;
//    }
//}
//
//class Polygon : FigureFeatures
//{
//    public Polygon(double _side, double height, int _color)
//    {
//        this.SetArea(_side * height * 0.5);
//        this.SetPerimeter(this.GetArea() * 6);
//        this.SetColor(_color);
//    }
//
//    protected override double GetArea() { return area; }
//
//    protected override int GetColor() { return color; }
//
//    protected override double GetPerimeter() { return perimeter; }
//
//    protected override void SetArea(double value) { area = value; }
//
//    protected override void SetColor(int value) { color = value; }
//
//    protected override void SetPerimeter(double value) { perimeter = value; }
//
//
//    public void Print()
//    {
//        if (this.GetColor() == 12) { Console.ForegroundColor = ConsoleColor.Red; }
//        else if (this.GetColor() == 10) { Console.ForegroundColor = ConsoleColor.Green; }
//        else if (this.GetColor() == 14) { Console.ForegroundColor = ConsoleColor.Yellow; }
//        else if (this.GetColor() == 15) { Console.ForegroundColor = ConsoleColor.White; }
//        else if (this.GetColor() == 7) { Console.ForegroundColor = ConsoleColor.Gray; }
//        else if (this.GetColor() == 0) { Console.ForegroundColor = ConsoleColor.Black; }
//        else if (this.GetColor() == 9) { Console.ForegroundColor = ConsoleColor.Blue; }
//
//        Console.WriteLine("      * * * * * * * * *      ");
//        Console.WriteLine("    *                   *    ");
//        Console.WriteLine("  *                       *  ");
//        Console.WriteLine("*                           *");
//        Console.WriteLine("*                           *");
//        Console.WriteLine("*                           *");
//        Console.WriteLine("*                           *");
//        Console.WriteLine("*                           *");
//        Console.WriteLine("*                           *");
//        Console.WriteLine("  *                       *  ");
//        Console.WriteLine("    *                   *    ");
//        Console.WriteLine("      * * * * * * * * *      ");
//
//        Console.ForegroundColor = ConsoleColor.Black;
//        Console.BackgroundColor = ConsoleColor.White;
//
//        Console.WriteLine("Area: " + area + "\tPerimeter: " + perimeter);
//
//        Console.ForegroundColor = ConsoleColor.White;
//        Console.BackgroundColor = ConsoleColor.Black;
//    }
//}


////Console.WriteLine("Figure names: Rectangle, Rhombus, Triangle, Trapezoid, Polygon");
////Console.WriteLine("Color code: Red = 12, Green = 10, Yellow = 14, White = 15, Gray = 7, Black = 0, Blue = 9");

////Console.Write("Enter figure name: ");
////string name = Console.ReadLine();
////Console.Write("Enter figure color: ");
////int color = Convert.ToInt32(Console.ReadLine());

////if (name == "Rectangle" || name == "rectangle")
////{
////    Console.Write("Enter side1 lenght: ");
////    double side1 = Convert.ToDouble(Console.ReadLine());

////    Console.Write("Enter side2 lenght: ");
////    double side2 = Convert.ToDouble(Console.ReadLine());

////    Rectangle rectangle = new Rectangle(side1, side2, color);

////    rectangle.Print();
////}
////else if (name == "Rhombus" || name == "rhombus")
////{
////    Console.Write("Enter side lenght: ");
////    double side = Convert.ToDouble(Console.ReadLine());

////    Console.Write("Enter diognal1 lenght: ");
////    double diognal1 = Convert.ToDouble(Console.ReadLine());

////    Console.Write("Enter diognal2 lenght: ");
////    double diognal2 = Convert.ToDouble(Console.ReadLine());

////    Rhombus rhombus = new Rhombus(side, diognal1, diognal2, color);
////    rhombus.Print();
////}
////else if (name == "Triangle" || name == "triangle")
////{
////    Console.Write("Enter side1 lenght (left): ");
////    double side1 = Convert.ToDouble(Console.ReadLine());

////    Console.Write("Enter side2 lenght (right): ");
////    double side2 = Convert.ToDouble(Console.ReadLine());

////    Console.Write("Enter side3 lenght (bottom): ");
////    double side3 = Convert.ToDouble(Console.ReadLine());

////    Console.Write("Enter height lenght: ");
////    double height = Convert.ToDouble(Console.ReadLine());

////    Triangle triangle = new Triangle(side1, side2, side3, height, color);
////    triangle.Print();
////}
////else if (name == "Trapezoid" || name == "trapezoid")
////{
////    Console.Write("Enter side1 lenght (top): ");
////    double side1 = Convert.ToDouble(Console.ReadLine());

////    Console.Write("Enter side2 lenght (left or right): ");
////    double side2 = Convert.ToDouble(Console.ReadLine());

////    Console.Write("Enter side3 lenght (bottom): ");
////    double side3 = Convert.ToDouble(Console.ReadLine());

////    Console.Write("Enter height lenght (merging on top of gold): ");
////    double height = Convert.ToDouble(Console.ReadLine());

////    Trapezoid trapezoid = new Trapezoid(side1, side2, side3, height, color);
////    trapezoid.Print();
////}
////else if (name == "Polygon" || name == "polygon")
////{
////    Console.Write("Enter side1 lenght: ");
////    double side1 = Convert.ToDouble(Console.ReadLine());

////    Console.Write("Enter height lenght: ");
////    double height = Convert.ToDouble(Console.ReadLine());

////    Polygon polygon = new Polygon(side1, height,color);
////    polygon.Print();
////}
////else
////{
////    Console.WriteLine("No correct figure :(");
////}

#endregion

/*
//interface ISimpleNGon
//    {
//        public double Height { get; set; }
//        public double Base { get; set; }
//        public double AngleBetweenBaseAndAdjacentSide { get; set; }
//        public double NumberOfSides { get; set; }
//        public double SidesLength { get; set; }
//        public double Area { get; set; }
//        public double Perimeter { get; set; }
//    }

//    class CompoundShape : ISimpleNGon
//    {
//        public double Height { get { return Height; } set { Height = value; } }
//        public double Base { get { return Base; } set { Base = value; } }
//        public double AngleBetweenBaseAndAdjacentSide { get { return AngleBetweenBaseAndAdjacentSide; } set { AngleBetweenBaseAndAdjacentSide = value; } }
//        public double NumberOfSides { get { return NumberOfSides; } set { NumberOfSides = value; } }
//        public double SidesLength { get { return SidesLength; } set { SidesLength = value; } }
//        public double Area { get { return Area; } set { Area = value; } }
//        public double Perimeter { get { return Perimeter; } set { Perimeter = value; } }


//        public CompoundShape(double height, double @base, double angleBetweenBaseAndAdjacentSide, double numberOfSides, double sidesLength)
//        {
//            Height = height;
//            Base = @base;
//            AngleBetweenBaseAndAdjacentSide = angleBetweenBaseAndAdjacentSide;
//            NumberOfSides = numberOfSides;
//            SidesLength = sidesLength;
//        }
//    }*/