public class Car
{
    public static void Main(string[] args)
    {
        string? myCarName;
        string? myPlateNymber;
        Console.WriteLine("Enter Car Model Name:");
        myCarName = Console.ReadLine();
        Console.WriteLine("Enter Car Plate Number:");
        myPlateNymber = Console.ReadLine();
        Car myCar = new Car(myCarName, myPlateNymber);
        Console.WriteLine("Car Model is: " + myCar.CarName + ", it's Plate No.: " + myCar.PlateNumber);

        string? carYear;
        string? carCountry;
        string? carHorsePower;
        Console.WriteLine("Enter Second Car Model Name:");
        myCarName = Console.ReadLine();
        Console.WriteLine("Enter Car Plate Number:");
        myPlateNymber = Console.ReadLine();
        Console.WriteLine("Enter Car Model year");
        carYear = Console.ReadLine();
        Console.WriteLine("Enter Country of origine");
        carCountry = Console.ReadLine();
        Console.WriteLine("Enter car Horse Power");
        carHorsePower = Console.ReadLine();
        CarDetails _carDetail = new CarDetails(myCarName, myPlateNymber, carYear, carCountry, carHorsePower);
        Console.WriteLine("Second Car Details: " + _carDetail.Display());

    }
    public Car(string _carName, string _plateNumber)
    {
        this.carName = _carName;
        this.plateNumber = _plateNumber;
    }
    private string carName;
    private string plateNumber;
    public string CarName
    {
        get { return carName; } 
        set { carName = value; }
    }
    public string PlateNumber
    {
        get { return plateNumber; }
        set { plateNumber = value; }
    }

}
public class CarDetails : Car
{
    public CarDetails(string _year, string _countryOfOrigine, string _horsePower ,string _carName, string _plateNumber) : base(_carName, _plateNumber)
    {
        this.year = _year;
        this.countryOfOrigine = _countryOfOrigine;
        this.horsePower = _horsePower;
    }
    string year;
    string countryOfOrigine;
    string horsePower;

    public string Year
    {
        get { return year; }
        set { year = value; }
    }
    public string CountryOfOrigine
    {
        get { return countryOfOrigine; }
        set { countryOfOrigine = value; }
    }
    public string HorsePower
    {
       get { return horsePower; }
       set { horsePower = value; }
    }
    public string Display()
    {
        return CarName + " " + PlateNumber + " " + Year + " " + CountryOfOrigine + " " + HorsePower;
    }
}