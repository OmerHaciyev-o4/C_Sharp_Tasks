#region Task1 and Task7
//enum ArticleType
//{
//    METAL,
//    GOLD,
//    RUBBER,
//    WHEAT,
//    COFFEE,
//    SUGAR,
//}
//
//enum ClientType
//{
//    BEGINNER,
//    NORMAL,
//    IMPORTANT
//}
//
//enum PayType
//{
//    CREDITCARD,
//    CASH
//}
//struct Article
//{
//    string prouduct_code;
//    string prouduct_name;
//    double prouduct_price;
//
//    ArticleType articleType;
//
//    public Article(string ID, string name, double price)
//    {
//        prouduct_code = ID;
//        prouduct_name = name;
//        prouduct_price = price;
//        articleType = ArticleType.METAL;
//    }
//}
//
//
//struct Client
//{
//    string cilent_code;
//    string cilent_name;
//    string cilent_lastName;
//    string address;
//    string telephone;
//    int prouduct_count;
//    int prouduct_price;
//    
//
//    public Client(string code, string name, string lastName, string addr, string th, int prouductCount, int prouduuctPrice)
//    {
//        cilent_code = code;
//        cilent_name = name;
//        cilent_lastName = lastName;
//        address = addr;
//        telephone = th;
//        prouduct_count = prouductCount;
//        prouduct_price = prouduuctPrice;
//    }
//}
//
//
//struct RequestItem
//{
//    string commodity;
//    int commodity_count;
//
//
//    public RequestItem(string comodity, int commodityCount)
//    {
//        commodity = comodity;
//        commodity_count = commodityCount;
//    }
//}
//
//struct Request
//{
//    string order_code;
//    string client_order;
//    string order_date;
//    string[] list;
//    double order_price;
//
//
//    public Request(string code, string client, string data, string[] list1, double price)
//    {
//        order_code = code;
//        client_order = client;
//        order_date = data;
//        list = new string[list1.Length];
//        list = list1;
//        order_price = price;
//    }
//}
#endregion

#region Task8
class Student
{
    ////add {using System.Collections.Generic}
    //private Dictionary<string, int> marksTable;
    //private string temp;
    //private int days;
    //
    //
    //public string name { get; set; }
    //public string lastName { get; set; }
    //public string fatherName { get; set; }
    //public int age { get; set; }
    //public string group { get; set; }
    //
    //
    //public Student(string _name, string _lastName, string _fatherName, int _age)
    //{
    //    name = _name;
    //    lastName = _lastName;
    //    fatherName = _fatherName;
    //    age = _age;
    //    days = 0;
    //    temp = "";
    //    marksTable = new Dictionary<string, int>();
    //}
    //
    //public Student(string _name, string _lastName, string _fatherName, int _age, string _group)
    //{
    //    name = _name;
    //    lastName = _lastName;
    //    fatherName = _fatherName;
    //    age = _age;
    //    group = _group;
    //    days = 0;
    //    temp = "";
    //    marksTable = new Dictionary<string, int>();
    //}
    //
    //
    //public void addMark(int mark)
    //{
    //    days++;
    //    temp = Convert.ToString(days) + " day";
    //    marksTable.Add(temp, mark); 
    //
    //}
    //
    //public void printStudentInformation()
    //{
    //    Console.WriteLine("~~~~~~~~~~~~~~~~ Student ~~~~~~~~~~~~~~~~");
    //    Console.WriteLine("Last Name: {0}", lastName);
    //    Console.WriteLine("Name: {0}", name);
    //    Console.WriteLine("Father Name: {0}", fatherName);
    //    Console.WriteLine("Group Name: {0}\n", group);
    //    Console.WriteLine("                MarksTable                ");
    //    int tempCount = 0;
    //    foreach (var item in marksTable)
    //    {
    //        tempCount++;
    //        if (tempCount == 7)
    //        {
    //            Console.WriteLine(" {0} --> {1}", item.Key, item.Value);
    //            tempCount = 0;
    //        }
    //        else
    //        {
    //            Console.Write(" {0} --> {1}|", item.Key, item.Value);
    //        }
    //    }
    //}
    ////Student omer = new Student("Omer", "Haciyev", "Nicat", 17, "Programing");
    ////omer.addMark(5);
    ////omer.addMark(3);
    ////omer.addMark(7);
    ////omer.addMark(4);
    ////omer.addMark(3);
    ////omer.addMark(6);
    ////omer.addMark(8);
    ////omer.addMark(9);
    ////omer.addMark(17);
    ////omer.addMark(13);

    ////omer.printStudentInformation();
}
#endregion

#region Task10
//namespace Citys
//{
//    class City
//    {
//        public string cityName { get; set; }
//        public double thePopulationNumbers { get; set; }


//        public City() { }

//        public City(string _cityName, double _thePopulationNumbers)
//        {
//            cityName = _cityName;
//            thePopulationNumbers = _thePopulationNumbers;
//        }
//    }

//    class City1
//    {
//        public string cityName { get; set; }
//        public double thePopulationNumbers { get; set; }


//        public City1() { }

//        public City1(string _cityName, double _thePopulationNumbers)
//        {
//            cityName = _cityName;
//            thePopulationNumbers = _thePopulationNumbers;
//        }
//    }

//    class City2
//    {
//        public string cityName { get; set; }
//        public double thePopulationNumbers { get; set; }


//        public City2() { }
//        public City2(string _cityName, double _thePopulationNumbers)
//        {
//            cityName = _cityName;
//            thePopulationNumbers = _thePopulationNumbers;
//        }
//    }




//// add using Citys
////City city = new City();
////City1 city1 = new City1();
////City2 city2 = new City2();
////Console.WriteLine("Please enter three morning names and population numbers.");
////Console.Write("Enter City1 Name: "); city.cityName = Console.ReadLine();
////Console.Write("Enter City1 the population numbers: "); city.thePopulationNumbers = Convert.ToDouble(Console.ReadLine());
////Console.Write("Enter City2 Name: "); city1.cityName = Console.ReadLine();
////Console.Write("Enter City2 the population numbers: "); city1.thePopulationNumbers = Convert.ToDouble(Console.ReadLine());
////Console.Write("Enter City3 Name: "); city2.cityName = Console.ReadLine();
////Console.Write("Enter City3 the population numbers: "); city2.thePopulationNumbers = Convert.ToDouble(Console.ReadLine());


////Console.WriteLine();
////string temp;
////double temp1;

////for (int i = 0; i < 3; i++)
////{
////    if (city.thePopulationNumbers.CompareTo(city1.thePopulationNumbers) == -1)
////    {
////        temp = city.cityName;
////        temp1 = city.thePopulationNumbers;
////        city.cityName = city1.cityName;
////        city.thePopulationNumbers =  city1.thePopulationNumbers;
////        city1.cityName = temp;
////        city1.thePopulationNumbers = temp1;
////    }
////    else if (city.thePopulationNumbers.CompareTo(city2.thePopulationNumbers) == -1)
////    {
////        temp = city.cityName;
////        temp1 = city.thePopulationNumbers;
////        city.cityName = city2.cityName;
////        city.thePopulationNumbers = city2.thePopulationNumbers;
////        city2.cityName = temp;
////        city2.thePopulationNumbers = temp1;
////    }
////    else if (city1.thePopulationNumbers.CompareTo(city2.thePopulationNumbers) == -1)
////    {
////        temp = city1.cityName;
////        temp1 = city1.thePopulationNumbers;
////        city1.cityName = city2.cityName;
////        city1.thePopulationNumbers = city2.thePopulationNumbers;
////        city2.cityName = temp;
////        city2.thePopulationNumbers = temp1;
////    }
////}
////Console.WriteLine("1) {0} --> {1}", city.cityName, city.thePopulationNumbers);       
////Console.WriteLine("2) {0} --> {1}", city1.cityName, city1.thePopulationNumbers);       
////Console.WriteLine("3) {0} --> {1}", city2.cityName, city2.thePopulationNumbers);       


//}
#endregion