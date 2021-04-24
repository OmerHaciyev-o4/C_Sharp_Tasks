#region Task1
//double a, b, c;
//int count = 0, count1 = 0;

//Console.Write("Enter the first side: ");
//a = double.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);

//Console.Write("Enter the second side: ");
//b = double.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);

//Console.Write("Enter the third side: ");
//c = double.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);

//while (a >= c)
//{
//    a = a - c;
//    count++;
//}

//while (b >= c)
//{
//    b = b - c;
//    count1++;
//}

//Console.WriteLine("\n\nThe number of quadrants that can be formed as a result of the given values = {0}", count * count1);
#endregion

#region Task2
    //public partial class Train
    //{
    //    private string _model;
    //    private string _marka;
    //    private int _passanger;
    //    private int _fuelType;
    //    private int _line;
    //    static private int _temp;

    //    static Train() { _temp = 0; }
    //    public Train() { }
    //    public Train(string model)
    //    {
    //        _model = model;
    //        _marka = null;
    //        _passanger = 0;
    //        _fuelType = 0;
    //        _temp++;
    //        _line = _temp;
    //    }
    //    public Train(string model, string marka)
    //    {
    //        _model = model;
    //        _marka = marka;
    //        _passanger = 0;
    //        _fuelType = 0;
    //        _temp++;
    //        _line = _temp;
    //    }
    //    public Train(string model, string marka, int passanger)
    //    {
    //        _model = model;
    //        _marka = marka;
    //        _passanger = passanger;
    //        _fuelType = 0;
    //        _temp++;
    //        _line = _temp;
    //    }
    //    public Train(string model, string marka, int passanger, int fuelType)
    //    {
    //        _model = model;
    //        _marka = marka;
    //        _passanger = passanger;
    //        _fuelType = fuelType;
    //        _temp++;
    //        _line = _temp;
    //    }

    //    public Train(string model, string marka, int passanger, int fuelType, int line)
    //    {
    //        _model = model;
    //        _marka = marka;
    //        _passanger = passanger;
    //        _fuelType = fuelType;
    //        _line = line;
    //    }

    //    public void SetModel(string model) { _model = model; }
    //    public void SetMarka(string marka) { _marka = marka; }
    //    public void SetPassenger(int passanger) { _passanger = passanger; }
    //    public void SetfuelType(int fuelType) { _fuelType = fuelType; }
    //    public void SetLine() { _line++; }

    //    public string GetModel() { return _model; }
    //    public string GetMarka() { return _marka; }
    //    public int GetPassenger() { return _passanger; }
    //    public int GetFuelType() { return _fuelType; }
    //    public int GetLine() { return _line; }
    //}

    //partial class Train
    //{
    //    public void addTrain(Train other)
    //    {
    //        _model = other._model;
    //        _marka = other._marka;
    //        _passanger = other._passanger;
    //        _fuelType = other._fuelType;
    //        _line = other.GetLine();
    //    }
    //}

    // MAIN();
    //Train[] trains = new Train[5];
    //trains[0] = new Train("Carolwood Pacific Railroad1");
    //trains[1] = new Train("Carolwood Pacific Railroad2", "bilmir1");
    //trains[2] = new Train("Carolwood Pacific Railroad3", "bilmir2", 50);
    //trains[3] = new Train("Carolwood Pacific Railroad4", "bilmir3", 50, 900);
    //trains[4] = new Train("Carolwood Pacific Railroad5", "bilmir4", 50, 900, 5);

    //foreach (var item in trains)
    //{
    //    Console.WriteLine(item.GetModel() + ' ' + item.GetMarka() + ' ' + item.GetPassenger() + ' ' + item.GetFuelType() + ' ' + item.GetLine());
    //}
#endregion